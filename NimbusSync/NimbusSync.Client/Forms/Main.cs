using NimbusSync.Client.Logic;
using OfficeOpenXml;
using OfficeOpenXml.FormulaParsing.Excel.Functions.Math;
using OfficeOpenXml.FormulaParsing.Excel.Functions.Text;
using System.IO.Packaging;
using System.Reflection;

namespace NimbusSync.Client
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void openFileButton_Click(object sender, EventArgs e)
        {
            // Pedir o arquivo
            if (openFile.ShowDialog(this) != DialogResult.OK) return;
            string filePath = openFile.FileName;

            // Abrir o arquivo
            List<string> names = ExcelFile.GetSheetNames(filePath).ToList();
            var selectedSheetIndex = SelectExcelSheet.SelectSheet(names.ToArray());

            List<FromExcelTableTecnicalDraw> fromExcelTecnicalDraws = ExcelFile.ReadTable<FromExcelTableTecnicalDraw>(filePath, selectedSheetIndex);

            if (fromExcelTecnicalDraws == null)
            {
                MessageBox.Show("Não foi possivel transforma os registros!");
                return;
            }

            var tecnicalDraws = fromExcelTecnicalDraws
                .Select(td => new TecnicalDraw(td.Codigo, td.Nome, td.Descricao, td.Caminho))
                .ToList();

            mainTable.DataSource = tecnicalDraws;
        }

        private void mainTable_CellValidated(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void mainPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void RegisterDataToDatabase(object sender, EventArgs e)
        {
            List<TecnicalDraw> tecnicalDraws = new List<TecnicalDraw>();

            // Obtém o tipo do objeto Dados
            Type dadosType = typeof(TecnicalDraw);

            // Obtém as propriedades do objeto Dados
            PropertyInfo[] properties = dadosType.GetProperties();

            foreach (DataGridViewRow row in mainTable.Rows)
            {
                TecnicalDraw tecnicalDraw = new TecnicalDraw();
                int nullFields = 0;

                foreach (PropertyInfo property in properties)
                {
                    // Obtém o nome da propriedade
                    string propertyName = property.Name;

                    // Obtém o índice da coluna pelo nome
                    int columnIndex = GetColumnIndex(propertyName);

                    if (columnIndex >= 0)
                    {
                        var value = row.Cells[columnIndex].Value;
                        if(value == null) nullFields++;
                        property.SetValue(tecnicalDraw, value);
                    }
                }

                if (nullFields >= properties.Length) continue;

                tecnicalDraws.Add(tecnicalDraw);
            }
        }

        private int GetColumnIndex(string columnName)
        {
            for (int i = 0; i < mainTable.Columns.Count; i++)
            {
                if (mainTable.Columns[i].HeaderText.Equals(columnName, StringComparison.OrdinalIgnoreCase))
                {
                    return i;
                }
            }

            return -1;
        }
    }
}