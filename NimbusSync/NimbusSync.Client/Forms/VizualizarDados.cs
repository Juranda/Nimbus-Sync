using NimbusSync.Client.Logic;
using NimbusSync.Server.Repositories;
using System.CodeDom;

namespace NimbusSync.Client.Forms
{
    public partial class VizualizarDados : Form
    {
        private Action<TecnicalDraw?> OnItemSelected;
        private Random random = new Random();
        private TecnicalDraw? selectedDraw = null;
        private readonly List<TecnicalDraw> tecnicalDraws = new List<TecnicalDraw>();
        private readonly TecnicalDrawStaticRepository repository = new();

        public VizualizarDados()
        {
            InitializeComponent();
            drawsGrid.CellClick += SelectDraw;
            OnItemSelected += UIDrawSelected;
            tecnicalDraws = GenerateRandomDraws(10);
            drawsGrid.DataSource = tecnicalDraws;

            tecnicalDraws.Add(new TecnicalDraw("1", "Nimbus Sync", "App incrivel", "C:\\Users\\felip\\Downloads\\Nimbus Sync.pdf"));
        }

        private void UIDrawSelected(TecnicalDraw? draw)
        {
            if (draw == null)
            {
                editDrawButton.Enabled = false;
                deleteDrawButton.Enabled = false;
                vizualizeDrawButton.Enabled = false;
            }
            else
            {
                editDrawButton.Enabled = true;
                deleteDrawButton.Enabled = true;
                vizualizeDrawButton.Enabled = true;
            }
        }

        private void SelectDraw(object? sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;

            var vizibleItens = (List<TecnicalDraw>)drawsGrid.DataSource;

            if(rowIndex >= 0 && rowIndex < vizibleItens.Count)
            {
                selectedDraw = vizibleItens[rowIndex];
                OnItemSelected.Invoke(selectedDraw);
            } else
            {
                selectedDraw = null;
                OnItemSelected.Invoke(null);
            }
        }

        private void FilterList(object sender, EventArgs e)
        {
            var code = codeField.Text;
            var name = nameField.Text;
            var desc = descField.Text;
            var author = authorField.Text;
            var date = creationDateField.Value;

            if (string.IsNullOrEmpty(codeField.Text + nameField.Text + authorField.Text +
                (useDataCheckBox.Checked ? creationDateField.Value : string.Empty)))
            {
                UpdateGrid();
                return;
            }

            var tecDraw = new TecnicalDraw(code, name, desc, DateOnly.FromDateTime(date), author, "");
            var filteredDraws = tecnicalDraws.Where(x =>
                x.Code.Contains(code) &&
                x.Name.ToLower().Contains(name.ToLower()) &&
                x.Author.ToLower().Contains(author.ToLower()))
                .ToList();

            if (useDataCheckBox.Checked && filteredDraws.Count > 0)
            {
                filteredDraws = filteredDraws
                    .Where(tecnicalDraw =>
                    {
                        if (!tecnicalDraw.CreationDate.HasValue)
                            return false;

                        if (tecnicalDraw.CreationDate.Value.DayNumber != DateOnly.FromDateTime(date).DayNumber)
                            return false;

                        else return true;
                    })
                    .ToList();
            }

            UpdateGrid(filteredDraws);
        }

        private void UpdateGrid()
        {
            drawsGrid.DataSource = null;
            drawsGrid.DataSource = tecnicalDraws;
        }

        private void UpdateGrid(List<TecnicalDraw> tecnicalDraws)
        {
            drawsGrid.DataSource = null;
            drawsGrid.DataSource = tecnicalDraws;
        }

        private void ToggleUsingDate(object sender, EventArgs e)
        {
            creationDateField.Enabled = !creationDateField.Enabled;
        }

        private List<TecnicalDraw> GenerateRandomDraws(int quantity)
        {
            return new TecnicalDrawStaticDraws().CreateTecnicalDraws();
        }

        private string GenerateRandomNumberString(int length)
        {
            return string.Join("", Enumerable.Range(0, length).Select(x => random.Next(0, 10)));
        }

        private void RegisterNewDraw(object sender, EventArgs e)
        { 
            CriarNovoDesenho criarNovoDesenho = new CriarNovoDesenho();

            if (criarNovoDesenho.ShowDialog() != DialogResult.OK) return;
            
            if(criarNovoDesenho.IsSingle)
            {
                tecnicalDraws.Add(criarNovoDesenho.Draw);
                UpdateGrid();
                MessageBox.Show("Desenho registrado!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else
            {
                tecnicalDraws.AddRange(criarNovoDesenho.DrawList);
                UpdateGrid();
                MessageBox.Show($"{criarNovoDesenho.DrawList.Count} desenhos registrados!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

        }

        private void DeleteDraw(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Tem certeza que deseja remover?", "Atenção", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            if (result == DialogResult.OK)
            {
                tecnicalDraws.Remove(selectedDraw);
                selectedDraw = null;
                UpdateGrid();
            }
        }

        private void OpenFile(object sender, EventArgs e)
        {
            if (selectedDraw is not null && File.Exists(selectedDraw.FilePath))
            {
                var processInfo = new System.Diagnostics.ProcessStartInfo(selectedDraw.FilePath);
                System.Diagnostics.Process.Start(processInfo);
            }
        }

        private void editDrawButton_Click(object sender, EventArgs e)
        {
            EditarDesenho editarDesenho = new EditarDesenho(selectedDraw);

            if (editarDesenho.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Desenho alterado");
            }
        }
    }
}
