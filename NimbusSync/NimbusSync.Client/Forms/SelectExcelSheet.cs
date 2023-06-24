namespace NimbusSync.Client
{
    public partial class SelectExcelSheet : Form
    {
        public Action<string> onSelected;
        string selected;
        public SelectExcelSheet(string[] options)
        {
            InitializeComponent();

            selectSheet.DataSource = options;
        }

        private void LoadExcelSheet(object sender, EventArgs e)
        {
            selected = (string)selectSheet.SelectedItem;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();

            onSelected?.Invoke(selected);
        }

        /// <summary>
        /// Cria uma lista usando as tabelas da planilha e retorna o index selecionado
        /// </summary>
        /// <param name="names"></param>
        /// <returns></returns>
        public static int SelectSheet(string[] names)
        {
            SelectExcelSheet selectExcelSheet = new SelectExcelSheet(names);
            if (selectExcelSheet.ShowDialog() == DialogResult.OK)
            {
                var selected = selectExcelSheet.selectSheet.SelectedIndex;
                return selected;
            }

            return -1;
        }
    }
}
