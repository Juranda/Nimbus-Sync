using NimbusSync.Client.Logic;
using System;
using System.Collections;
using System.Xml.Linq;

namespace NimbusSync.Client.Forms
{
    public partial class CriarNovoDesenho : Form
    {
        public TecnicalDraw? Draw { get; private set; }
        public List<TecnicalDraw>? DrawList { get; private set; }

        public bool IsSingle { get; private set; }
        public CriarNovoDesenho()
        {
            InitializeComponent();

            Draw = null;
            DrawList = null;

            selectExcelFileSheetCombox.SelectedIndexChanged += SetGridView;
        }

        private void SetGridView(object? sender, EventArgs e)
        {
            excelTablePreview.DataSource = null;
            var fromExcelTableTecnicalDraws = ExcelFile.ReadSheet<FromExcelTableTecnicalDraw>(openExcelFileDialog.FileName, selectExcelFileSheetCombox.SelectedIndex);

            if (fromExcelTableTecnicalDraws is null) return;

            var tecnicalDraws = fromExcelTableTecnicalDraws
                .Select(x => new TecnicalDraw(
                    code: x.Codigo,
                    name: x.Nome,
                    description: x.Descricao,
                    filePath: x.Caminho
                    ))
                .ToList();
            excelTablePreview.DataSource = tecnicalDraws;
            DrawList = tecnicalDraws;
        }

        private void ToggleCodeField(object sender, EventArgs e)
        {
            code.Enabled = !code.Enabled;
        }

        private void ToggleDateField(object sender, EventArgs e)
        {
            date.Enabled = !date.Enabled;
        }

        private void SelectFile(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            var fileName = openFileDialog.FileName.Split('\\').Last();

            selectedFileLabel.Text = $"{fileName} selecionado.";
        }

        private void RegisterDraw(object sender, EventArgs e)
        {
            if(createOption1.Checked)
            {
                RegisterSingleDraw();
            } else if(createOption2.Checked)
            {
                IsSingle = false;
            }

            DialogResult = DialogResult.OK;
        }

        private void RegisterSingleDraw()
        {
            var _code = createCodeCheckBox.Checked ? Guid.NewGuid().ToString() : code.Text;
            var _name = name.Text;
            var _desc = description.Text;
            var _filePath = openFileDialog.FileName;
            var _date = DateOnly.FromDateTime(date.Value);

            if (!File.Exists(_filePath))
            {
                MessageBox.Show("Selecione um arquivo.", "Arquivo não encontrado");
                return;
            }

            var _author = new FileInfo(_filePath).GetAccessControl().GetOwner(typeof(System.Security.Principal.NTAccount)).Value.Split('\\').Last();

            var draw = new TecnicalDraw(_code, _name, _desc, _date, _author, openFileDialog.FileName);

            if (IsInvalidDraw(draw, out List<string> invalidFieldNames))
            {
                MessageBox.Show("Campos invalidos:\n" + string.Join(".\n", invalidFieldNames), "Preencha os campos necessários");
                return;
            }
            IsSingle = true;
            Draw = draw;
        }

        private bool IsInvalidDraw(TecnicalDraw tecnicalDraw, out List<string> invalidFieldNames)
        {
            invalidFieldNames = new List<string>();

            if (!createCodeCheckBox.Checked && string.IsNullOrEmpty(tecnicalDraw.Code))
            {
                invalidFieldNames.Add("Código");
            }

            if (string.IsNullOrEmpty(tecnicalDraw.Name))
            {
                invalidFieldNames.Add("Nome");
            }

            if (string.IsNullOrEmpty(tecnicalDraw.FilePath))
            {
                invalidFieldNames.Add("Caminho do arquivo");
            }

            return invalidFieldNames.Any();
        }

        private void Enter(object sender, KeyEventArgs e)
        {
            RegisterDraw(sender, e);
        }

        private void CreateFromTableChecked(object sender, EventArgs e)
        {
            createFromTableGroup.Enabled = true;
            createSingleGroup.Enabled = false;
        }

        private void CreateSingleChecked(object sender, EventArgs e)
        {
            createFromTableGroup.Enabled = false;
            createSingleGroup.Enabled = true;
        }

        private void SelectExcelFile(object sender, EventArgs e)
        {
            var result = openExcelFileDialog.ShowDialog();

            if (result != DialogResult.OK) return;

            selectedExcelFileLabel.Text = $"{openExcelFileDialog.FileName.Split("\\").Last()} selecionado.";

            string[] sheets = ExcelFile.GetSheetNames(openExcelFileDialog.FileName);

            selectExcelFileSheetCombox.Items.Clear();
            selectExcelFileSheetCombox.Items.AddRange(sheets);
        }
    }
}
