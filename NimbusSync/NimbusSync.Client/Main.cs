namespace NimbusSync.Client
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            InitializeManagerBar();
        }

        private void InitializeManagerBar()
        {
            ControlBox = false;

            Controls.Add(new Button());
        }
        private void CustomCloseButton_Click(object sender, EventArgs e)
        {
            // Lógica para fechar o formulário quando o botão personalizado for clicado
            Close();
        }
    }
}