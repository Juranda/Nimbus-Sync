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
            // L�gica para fechar o formul�rio quando o bot�o personalizado for clicado
            Close();
        }
    }
}