using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NimbusSync.Client.Forms
{
    public partial class EditarDesenho : Form
    {
        private readonly TecnicalDraw tecnicalDraw;

        public EditarDesenho(TecnicalDraw tecnicalDraw)
        {
            InitializeComponent();

            code.Text = tecnicalDraw.Code;
            name.Text = tecnicalDraw.Name;
            description.Text = tecnicalDraw.Description;
            date.Value = date.Value.Date;
            selectedFileLabel.Text = $"{tecnicalDraw.FilePath.Split("\\").Last()} selecionado";
            this.tecnicalDraw = tecnicalDraw;
        }

        private void SelecionarArquivo(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            var fileName = openFileDialog.FileName.Split('\\').Last();

            selectedFileLabel.Text = $"{fileName} selecionado.";

        }

        private void AlterarDesenho(object sender, EventArgs e)
        {
            tecnicalDraw.Code = code.Text;
            tecnicalDraw.Name = name.Text;
            tecnicalDraw.Description = description.Text;
            tecnicalDraw.CreationDate = DateOnly.FromDateTime(date.Value.Date);
            tecnicalDraw.FilePath = openFileDialog.FileName;
            DialogResult = DialogResult.OK;
        }
    }
}
