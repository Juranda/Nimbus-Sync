namespace NimbusSync.Client.Forms
{
    partial class VizualizarDados
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            searchButton = new Button();
            label1 = new Label();
            drawsGrid = new DataGridView();
            codeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            descriptionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            authorDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            creationDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            tecnicalDrawBindingSource = new BindingSource(components);
            GridPanel = new Panel();
            label2 = new Label();
            codeField = new TextBox();
            nameField = new TextBox();
            label3 = new Label();
            authorField = new TextBox();
            label4 = new Label();
            creationDateField = new DateTimePicker();
            label5 = new Label();
            newDrawButton = new Button();
            editDrawButton = new Button();
            deleteDrawButton = new Button();
            vizualizeDrawButton = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            useDataCheckBox = new CheckBox();
            descField = new TextBox();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)drawsGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tecnicalDrawBindingSource).BeginInit();
            GridPanel.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // searchButton
            // 
            searchButton.BackColor = Color.FromArgb(12, 192, 223);
            searchButton.FlatStyle = FlatStyle.Flat;
            searchButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            searchButton.Location = new Point(362, 66);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(133, 46);
            searchButton.TabIndex = 0;
            searchButton.Text = "Pesquisar";
            searchButton.UseVisualStyleBackColor = false;
            searchButton.Click += FilterList;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Bottom;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonShadow;
            label1.Location = new Point(0, 356);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Padding = new Padding(0, 0, 5, 0);
            label1.Size = new Size(617, 37);
            label1.TabIndex = 1;
            label1.Text = "Nimbus Sync 1.0";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // drawsGrid
            // 
            drawsGrid.AllowUserToAddRows = false;
            drawsGrid.AutoGenerateColumns = false;
            drawsGrid.BorderStyle = BorderStyle.None;
            drawsGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            drawsGrid.Columns.AddRange(new DataGridViewColumn[] { codeDataGridViewTextBoxColumn, nameDataGridViewTextBoxColumn, descriptionDataGridViewTextBoxColumn, authorDataGridViewTextBoxColumn, creationDateDataGridViewTextBoxColumn });
            drawsGrid.DataSource = tecnicalDrawBindingSource;
            drawsGrid.Dock = DockStyle.Fill;
            drawsGrid.Location = new Point(0, 0);
            drawsGrid.Margin = new Padding(0);
            drawsGrid.Name = "drawsGrid";
            drawsGrid.RowTemplate.Height = 25;
            drawsGrid.Size = new Size(593, 235);
            drawsGrid.TabIndex = 2;
            // 
            // codeDataGridViewTextBoxColumn
            // 
            codeDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            codeDataGridViewTextBoxColumn.DataPropertyName = "Code";
            codeDataGridViewTextBoxColumn.HeaderText = "Codigo";
            codeDataGridViewTextBoxColumn.Name = "codeDataGridViewTextBoxColumn";
            codeDataGridViewTextBoxColumn.Width = 71;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn.HeaderText = "Nome do desenho";
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            nameDataGridViewTextBoxColumn.Width = 119;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            descriptionDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            descriptionDataGridViewTextBoxColumn.HeaderText = "Descrição";
            descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            descriptionDataGridViewTextBoxColumn.Width = 65;
            // 
            // authorDataGridViewTextBoxColumn
            // 
            authorDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            authorDataGridViewTextBoxColumn.DataPropertyName = "Author";
            authorDataGridViewTextBoxColumn.HeaderText = "Autor";
            authorDataGridViewTextBoxColumn.Name = "authorDataGridViewTextBoxColumn";
            authorDataGridViewTextBoxColumn.Width = 62;
            // 
            // creationDateDataGridViewTextBoxColumn
            // 
            creationDateDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            creationDateDataGridViewTextBoxColumn.DataPropertyName = "CreationDate";
            creationDateDataGridViewTextBoxColumn.HeaderText = "Data criação";
            creationDateDataGridViewTextBoxColumn.Name = "creationDateDataGridViewTextBoxColumn";
            creationDateDataGridViewTextBoxColumn.Width = 72;
            // 
            // tecnicalDrawBindingSource
            // 
            tecnicalDrawBindingSource.DataSource = typeof(TecnicalDraw);
            // 
            // GridPanel
            // 
            GridPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            GridPanel.Controls.Add(drawsGrid);
            GridPanel.Location = new Point(12, 118);
            GridPanel.Name = "GridPanel";
            GridPanel.Size = new Size(593, 235);
            GridPanel.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 10);
            label2.Margin = new Padding(3);
            label2.Name = "label2";
            label2.Size = new Size(60, 21);
            label2.TabIndex = 4;
            label2.Text = "Codigo";
            // 
            // codeField
            // 
            codeField.BackColor = Color.FromArgb(165, 161, 161);
            codeField.BorderStyle = BorderStyle.None;
            codeField.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            codeField.Location = new Point(12, 37);
            codeField.Name = "codeField";
            codeField.Size = new Size(170, 22);
            codeField.TabIndex = 5;
            // 
            // nameField
            // 
            nameField.BackColor = Color.FromArgb(165, 161, 161);
            nameField.BorderStyle = BorderStyle.None;
            nameField.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            nameField.Location = new Point(12, 90);
            nameField.Name = "nameField";
            nameField.Size = new Size(170, 22);
            nameField.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(12, 63);
            label3.Margin = new Padding(3);
            label3.Name = "label3";
            label3.Size = new Size(138, 21);
            label3.TabIndex = 6;
            label3.Text = "Nome do desenho";
            // 
            // authorField
            // 
            authorField.BackColor = Color.FromArgb(165, 161, 161);
            authorField.BorderStyle = BorderStyle.None;
            authorField.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            authorField.Location = new Point(188, 90);
            authorField.Name = "authorField";
            authorField.Size = new Size(168, 22);
            authorField.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(188, 63);
            label4.Margin = new Padding(3);
            label4.Name = "label4";
            label4.Size = new Size(49, 21);
            label4.TabIndex = 8;
            label4.Text = "Autor";
            // 
            // creationDateField
            // 
            creationDateField.CalendarFont = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            creationDateField.CalendarMonthBackground = Color.FromArgb(165, 161, 161);
            creationDateField.Enabled = false;
            creationDateField.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            creationDateField.Format = DateTimePickerFormat.Short;
            creationDateField.Location = new Point(362, 37);
            creationDateField.Name = "creationDateField";
            creationDateField.Size = new Size(133, 23);
            creationDateField.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(362, 12);
            label5.Margin = new Padding(3);
            label5.Name = "label5";
            label5.Size = new Size(42, 21);
            label5.TabIndex = 11;
            label5.Text = "Data";
            // 
            // newDrawButton
            // 
            newDrawButton.Dock = DockStyle.Fill;
            newDrawButton.Location = new Point(2, 2);
            newDrawButton.Margin = new Padding(2);
            newDrawButton.Name = "newDrawButton";
            newDrawButton.Size = new Size(46, 46);
            newDrawButton.TabIndex = 0;
            newDrawButton.Text = "Criar";
            newDrawButton.UseVisualStyleBackColor = true;
            newDrawButton.Click += RegisterNewDraw;
            // 
            // editDrawButton
            // 
            editDrawButton.Dock = DockStyle.Fill;
            editDrawButton.Location = new Point(52, 2);
            editDrawButton.Margin = new Padding(2);
            editDrawButton.Name = "editDrawButton";
            editDrawButton.Size = new Size(46, 46);
            editDrawButton.TabIndex = 1;
            editDrawButton.Text = "Editar";
            editDrawButton.UseVisualStyleBackColor = true;
            editDrawButton.Click += editDrawButton_Click;
            // 
            // deleteDrawButton
            // 
            deleteDrawButton.Dock = DockStyle.Fill;
            deleteDrawButton.Location = new Point(2, 52);
            deleteDrawButton.Margin = new Padding(2);
            deleteDrawButton.Name = "deleteDrawButton";
            deleteDrawButton.Size = new Size(46, 46);
            deleteDrawButton.TabIndex = 2;
            deleteDrawButton.Text = "Deletar";
            deleteDrawButton.UseVisualStyleBackColor = true;
            deleteDrawButton.Click += deleteDrawButton_Click;
            // 
            // vizualizeDrawButton
            // 
            vizualizeDrawButton.Dock = DockStyle.Fill;
            vizualizeDrawButton.Location = new Point(52, 52);
            vizualizeDrawButton.Margin = new Padding(2);
            vizualizeDrawButton.Name = "vizualizeDrawButton";
            vizualizeDrawButton.Size = new Size(46, 46);
            vizualizeDrawButton.TabIndex = 3;
            vizualizeDrawButton.Text = "Vizualizar";
            vizualizeDrawButton.UseVisualStyleBackColor = true;
            vizualizeDrawButton.Click += OpenFile;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(vizualizeDrawButton, 1, 1);
            tableLayoutPanel1.Controls.Add(editDrawButton, 1, 0);
            tableLayoutPanel1.Controls.Add(newDrawButton, 0, 0);
            tableLayoutPanel1.Controls.Add(deleteDrawButton, 0, 1);
            tableLayoutPanel1.GrowStyle = TableLayoutPanelGrowStyle.FixedSize;
            tableLayoutPanel1.Location = new Point(505, 12);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(100, 100);
            tableLayoutPanel1.TabIndex = 13;
            // 
            // useDataCheckBox
            // 
            useDataCheckBox.FlatStyle = FlatStyle.System;
            useDataCheckBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            useDataCheckBox.Location = new Point(407, 12);
            useDataCheckBox.Margin = new Padding(0);
            useDataCheckBox.Name = "useDataCheckBox";
            useDataCheckBox.Size = new Size(88, 22);
            useDataCheckBox.TabIndex = 14;
            useDataCheckBox.Text = "Usar data";
            useDataCheckBox.UseVisualStyleBackColor = true;
            useDataCheckBox.CheckedChanged += ToggleUsingDate;
            // 
            // descField
            // 
            descField.BackColor = Color.FromArgb(165, 161, 161);
            descField.BorderStyle = BorderStyle.None;
            descField.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            descField.Location = new Point(188, 37);
            descField.Name = "descField";
            descField.Size = new Size(168, 22);
            descField.TabIndex = 16;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(188, 10);
            label6.Margin = new Padding(3);
            label6.Name = "label6";
            label6.Size = new Size(77, 21);
            label6.TabIndex = 15;
            label6.Text = "Descrição";
            // 
            // VizualizarDados
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(617, 393);
            Controls.Add(descField);
            Controls.Add(label6);
            Controls.Add(useDataCheckBox);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(label5);
            Controls.Add(creationDateField);
            Controls.Add(authorField);
            Controls.Add(label4);
            Controls.Add(nameField);
            Controls.Add(label3);
            Controls.Add(codeField);
            Controls.Add(label2);
            Controls.Add(GridPanel);
            Controls.Add(label1);
            Controls.Add(searchButton);
            ForeColor = SystemColors.ControlText;
            Name = "VizualizarDados";
            Text = "Nimbus Sync";
            ((System.ComponentModel.ISupportInitialize)drawsGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)tecnicalDrawBindingSource).EndInit();
            GridPanel.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button searchButton;
        private Label label1;
        private DataGridView drawsGrid;
        private Panel GridPanel;
        private Label label2;
        private TextBox codeField;
        private TextBox nameField;
        private Label label3;
        private TextBox authorField;
        private Label label4;
        private DateTimePicker creationDateField;
        private Label label5;
        private Button newDrawButton;
        private Button editDrawButton;
        private Button deleteDrawButton;
        private Button vizualizeDrawButton;
        private TableLayoutPanel tableLayoutPanel1;
        private CheckBox useDataCheckBox;
        private BindingSource tecnicalDrawBindingSource;
        private TextBox descField;
        private Label label6;
        private DataGridViewTextBoxColumn codeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn authorDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn creationDateDataGridViewTextBoxColumn;
    }
}