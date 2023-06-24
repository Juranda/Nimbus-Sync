using NimbusSync.Client.Logic;

namespace NimbusSync.Client
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            generalPanel = new FlowLayoutPanel();
            closeButton = new Button();
            panel1 = new Panel();
            label1 = new Label();
            openFile = new OpenFileDialog();
            openFileButton = new Button();
            mainPanel = new Panel();
            mainTable = new DataGridView();
            tecnicalDrawBindingSource = new BindingSource(components);
            folderBrowserDialog = new FolderBrowserDialog();
            codeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            descriptionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            creationDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            authorDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            filePathDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            registerButton = new Button();
            generalPanel.SuspendLayout();
            panel1.SuspendLayout();
            mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)mainTable).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tecnicalDrawBindingSource).BeginInit();
            SuspendLayout();
            // 
            // generalPanel
            // 
            generalPanel.BackColor = Color.FromArgb(94, 23, 235);
            generalPanel.Controls.Add(closeButton);
            generalPanel.Controls.Add(panel1);
            generalPanel.Dock = DockStyle.Top;
            generalPanel.FlowDirection = FlowDirection.RightToLeft;
            generalPanel.Location = new Point(0, 0);
            generalPanel.Margin = new Padding(0);
            generalPanel.Name = "generalPanel";
            generalPanel.Size = new Size(800, 30);
            generalPanel.TabIndex = 0;
            // 
            // closeButton
            // 
            closeButton.BackColor = Color.Red;
            closeButton.BackgroundImageLayout = ImageLayout.None;
            closeButton.Cursor = Cursors.Hand;
            closeButton.FlatAppearance.BorderSize = 0;
            closeButton.FlatStyle = FlatStyle.Flat;
            closeButton.Location = new Point(770, 0);
            closeButton.Margin = new Padding(0);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(30, 30);
            closeButton.TabIndex = 0;
            closeButton.Text = "X";
            closeButton.UseVisualStyleBackColor = false;
            closeButton.Click += closeButton_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(770, 30);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(0, 0);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Size = new Size(143, 25);
            label1.TabIndex = 0;
            label1.Text = "NIMBUS SYNC";
            // 
            // openFile
            // 
            openFile.FileName = "Tabela";
            openFile.Filter = "All Files (*.*)|*.*";
            openFile.Title = "Selecione o desenho tecnico";
            // 
            // openFileButton
            // 
            openFileButton.BackColor = Color.FromArgb(12, 192, 223);
            openFileButton.Location = new Point(12, 19);
            openFileButton.Name = "openFileButton";
            openFileButton.Size = new Size(91, 23);
            openFileButton.TabIndex = 1;
            openFileButton.Text = "Abrir arquivo";
            openFileButton.UseVisualStyleBackColor = false;
            openFileButton.Click += openFileButton_Click;
            // 
            // mainPanel
            // 
            mainPanel.BackColor = Color.White;
            mainPanel.Controls.Add(registerButton);
            mainPanel.Controls.Add(mainTable);
            mainPanel.Controls.Add(openFileButton);
            mainPanel.Location = new Point(0, 30);
            mainPanel.Margin = new Padding(0);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(800, 420);
            mainPanel.TabIndex = 2;
            mainPanel.Paint += mainPanel_Paint;
            // 
            // mainTable
            // 
            mainTable.AllowUserToResizeRows = false;
            mainTable.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            mainTable.AutoGenerateColumns = false;
            mainTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            mainTable.Columns.AddRange(new DataGridViewColumn[] { codeDataGridViewTextBoxColumn, nameDataGridViewTextBoxColumn, descriptionDataGridViewTextBoxColumn, creationDateDataGridViewTextBoxColumn, authorDataGridViewTextBoxColumn, filePathDataGridViewTextBoxColumn });
            mainTable.DataSource = tecnicalDrawBindingSource;
            mainTable.Location = new Point(12, 94);
            mainTable.Name = "mainTable";
            mainTable.RowHeadersVisible = false;
            mainTable.RowTemplate.Height = 25;
            mainTable.Size = new Size(776, 314);
            mainTable.TabIndex = 2;
            mainTable.CellValidated += mainTable_CellValidated;
            // 
            // tecnicalDrawBindingSource
            // 
            tecnicalDrawBindingSource.DataSource = typeof(TecnicalDraw);
            // 
            // codeDataGridViewTextBoxColumn
            // 
            codeDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            codeDataGridViewTextBoxColumn.DataPropertyName = "Code";
            codeDataGridViewTextBoxColumn.HeaderText = "Code";
            codeDataGridViewTextBoxColumn.Name = "codeDataGridViewTextBoxColumn";
            codeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn.HeaderText = "Name";
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            descriptionDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // creationDateDataGridViewTextBoxColumn
            // 
            creationDateDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            creationDateDataGridViewTextBoxColumn.DataPropertyName = "CreationDate";
            creationDateDataGridViewTextBoxColumn.HeaderText = "CreationDate";
            creationDateDataGridViewTextBoxColumn.Name = "creationDateDataGridViewTextBoxColumn";
            // 
            // authorDataGridViewTextBoxColumn
            // 
            authorDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            authorDataGridViewTextBoxColumn.DataPropertyName = "Author";
            authorDataGridViewTextBoxColumn.HeaderText = "Author";
            authorDataGridViewTextBoxColumn.Name = "authorDataGridViewTextBoxColumn";
            // 
            // filePathDataGridViewTextBoxColumn
            // 
            filePathDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            filePathDataGridViewTextBoxColumn.DataPropertyName = "FilePath";
            filePathDataGridViewTextBoxColumn.HeaderText = "FilePath";
            filePathDataGridViewTextBoxColumn.Name = "filePathDataGridViewTextBoxColumn";
            // 
            // registerButton
            // 
            registerButton.BackColor = Color.FromArgb(12, 192, 223);
            registerButton.Location = new Point(12, 48);
            registerButton.Name = "registerButton";
            registerButton.Size = new Size(122, 23);
            registerButton.TabIndex = 3;
            registerButton.Text = "Registrar dados";
            registerButton.UseVisualStyleBackColor = false;
            registerButton.Click += RegisterDataToDatabase;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(800, 450);
            Controls.Add(mainPanel);
            Controls.Add(generalPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Main";
            Text = "Nimbus Sync";
            generalPanel.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            mainPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)mainTable).EndInit();
            ((System.ComponentModel.ISupportInitialize)tecnicalDrawBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel generalPanel;
        private OpenFileDialog openFile;
        private Button openFileButton;
        private Panel mainPanel;
        private DataGridView mainTable;
        private DataGridViewImageColumn byteFileDataGridViewImageColumn;
        private Button closeButton;
        private Panel panel1;
        private Label label1;
        private FolderBrowserDialog folderBrowserDialog;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private BindingSource tecnicalDrawBindingSource;
        private DataGridViewTextBoxColumn codeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn creationDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn authorDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn filePathDataGridViewTextBoxColumn;
        private Button registerButton;
    }
}