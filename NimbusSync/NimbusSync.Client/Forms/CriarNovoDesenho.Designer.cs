namespace NimbusSync.Client.Forms
{
    partial class CriarNovoDesenho
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
            dateLabel = new Label();
            date = new DateTimePicker();
            description = new TextBox();
            descriptionLabel = new Label();
            name = new TextBox();
            nameLabel = new Label();
            code = new TextBox();
            codeLabel = new Label();
            useFileDataCheckBox = new CheckBox();
            createCodeCheckBox = new CheckBox();
            selectDrawButton = new Button();
            selectedFileLabel = new Label();
            registerButton = new Button();
            openFileDialog = new OpenFileDialog();
            createSingleGroup = new GroupBox();
            createFromTableGroup = new GroupBox();
            label1 = new Label();
            selectExcelFileSheetCombox = new ComboBox();
            selectedExcelFileLabel = new Label();
            selectExcelFile = new Button();
            excelTablePreview = new DataGridView();
            createOption1 = new RadioButton();
            createOption2 = new RadioButton();
            openExcelFileDialog = new OpenFileDialog();
            createSingleGroup.SuspendLayout();
            createFromTableGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)excelTablePreview).BeginInit();
            SuspendLayout();
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dateLabel.Location = new Point(151, 22);
            dateLabel.Margin = new Padding(3);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new Size(42, 21);
            dateLabel.TabIndex = 19;
            dateLabel.Text = "Data";
            // 
            // date
            // 
            date.CalendarFont = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            date.CalendarMonthBackground = Color.FromArgb(165, 161, 161);
            date.Enabled = false;
            date.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            date.Format = DateTimePickerFormat.Short;
            date.Location = new Point(151, 43);
            date.Name = "date";
            date.Size = new Size(142, 29);
            date.TabIndex = 18;
            // 
            // description
            // 
            description.BackColor = Color.FromArgb(165, 161, 161);
            description.BorderStyle = BorderStyle.None;
            description.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            description.Location = new Point(4, 195);
            description.Multiline = true;
            description.Name = "description";
            description.Size = new Size(284, 155);
            description.TabIndex = 17;
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            descriptionLabel.Location = new Point(4, 168);
            descriptionLabel.Margin = new Padding(3);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new Size(77, 21);
            descriptionLabel.TabIndex = 16;
            descriptionLabel.Text = "Descrição";
            // 
            // name
            // 
            name.BackColor = Color.FromArgb(165, 161, 161);
            name.BorderStyle = BorderStyle.None;
            name.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            name.Location = new Point(4, 129);
            name.Name = "name";
            name.Size = new Size(284, 22);
            name.TabIndex = 15;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            nameLabel.Location = new Point(4, 102);
            nameLabel.Margin = new Padding(3);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(138, 21);
            nameLabel.TabIndex = 14;
            nameLabel.Text = "Nome do desenho";
            // 
            // code
            // 
            code.BackColor = Color.FromArgb(165, 161, 161);
            code.BorderStyle = BorderStyle.None;
            code.Enabled = false;
            code.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            code.Location = new Point(6, 49);
            code.Name = "code";
            code.Size = new Size(136, 22);
            code.TabIndex = 13;
            // 
            // codeLabel
            // 
            codeLabel.AutoSize = true;
            codeLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            codeLabel.Location = new Point(6, 22);
            codeLabel.Margin = new Padding(3);
            codeLabel.Name = "codeLabel";
            codeLabel.Size = new Size(60, 21);
            codeLabel.TabIndex = 12;
            codeLabel.Text = "Codigo";
            // 
            // useFileDataCheckBox
            // 
            useFileDataCheckBox.Checked = true;
            useFileDataCheckBox.CheckState = CheckState.Checked;
            useFileDataCheckBox.FlatStyle = FlatStyle.System;
            useFileDataCheckBox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            useFileDataCheckBox.Location = new Point(151, 75);
            useFileDataCheckBox.Margin = new Padding(0);
            useFileDataCheckBox.Name = "useFileDataCheckBox";
            useFileDataCheckBox.Size = new Size(142, 33);
            useFileDataCheckBox.TabIndex = 20;
            useFileDataCheckBox.Text = "Usar data de criação do arquivo";
            useFileDataCheckBox.TextAlign = ContentAlignment.TopLeft;
            useFileDataCheckBox.UseVisualStyleBackColor = true;
            useFileDataCheckBox.CheckedChanged += ToggleDateField;
            // 
            // createCodeCheckBox
            // 
            createCodeCheckBox.Checked = true;
            createCodeCheckBox.CheckState = CheckState.Checked;
            createCodeCheckBox.FlatStyle = FlatStyle.System;
            createCodeCheckBox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            createCodeCheckBox.Location = new Point(6, 75);
            createCodeCheckBox.Margin = new Padding(0);
            createCodeCheckBox.Name = "createCodeCheckBox";
            createCodeCheckBox.Size = new Size(67, 24);
            createCodeCheckBox.TabIndex = 21;
            createCodeCheckBox.Text = "Gerar";
            createCodeCheckBox.TextAlign = ContentAlignment.TopLeft;
            createCodeCheckBox.UseVisualStyleBackColor = true;
            createCodeCheckBox.CheckedChanged += ToggleCodeField;
            // 
            // selectDrawButton
            // 
            selectDrawButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            selectDrawButton.Location = new Point(4, 355);
            selectDrawButton.Margin = new Padding(2);
            selectDrawButton.Name = "selectDrawButton";
            selectDrawButton.Size = new Size(148, 38);
            selectDrawButton.TabIndex = 22;
            selectDrawButton.Text = "Selecionar arquivo";
            selectDrawButton.UseVisualStyleBackColor = true;
            selectDrawButton.Click += SelectFile;
            // 
            // selectedFileLabel
            // 
            selectedFileLabel.AutoSize = true;
            selectedFileLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            selectedFileLabel.Location = new Point(4, 398);
            selectedFileLabel.Margin = new Padding(3);
            selectedFileLabel.Name = "selectedFileLabel";
            selectedFileLabel.Size = new Size(163, 15);
            selectedFileLabel.TabIndex = 23;
            selectedFileLabel.Text = "Nenhum arquivo selecionado";
            // 
            // registerButton
            // 
            registerButton.BackColor = Color.FromArgb(12, 192, 223);
            registerButton.FlatStyle = FlatStyle.Flat;
            registerButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            registerButton.Location = new Point(385, 483);
            registerButton.Name = "registerButton";
            registerButton.Size = new Size(148, 38);
            registerButton.TabIndex = 24;
            registerButton.Text = "Registrar";
            registerButton.UseVisualStyleBackColor = false;
            registerButton.Click += RegisterDraw;
            // 
            // openFileDialog
            // 
            openFileDialog.FileName = "Desenho 1";
            // 
            // createSingleGroup
            // 
            createSingleGroup.Controls.Add(codeLabel);
            createSingleGroup.Controls.Add(code);
            createSingleGroup.Controls.Add(selectedFileLabel);
            createSingleGroup.Controls.Add(nameLabel);
            createSingleGroup.Controls.Add(selectDrawButton);
            createSingleGroup.Controls.Add(name);
            createSingleGroup.Controls.Add(createCodeCheckBox);
            createSingleGroup.Controls.Add(descriptionLabel);
            createSingleGroup.Controls.Add(useFileDataCheckBox);
            createSingleGroup.Controls.Add(description);
            createSingleGroup.Controls.Add(dateLabel);
            createSingleGroup.Controls.Add(date);
            createSingleGroup.Location = new Point(12, 37);
            createSingleGroup.Name = "createSingleGroup";
            createSingleGroup.Size = new Size(317, 425);
            createSingleGroup.TabIndex = 25;
            createSingleGroup.TabStop = false;
            createSingleGroup.Text = "Criar unico";
            // 
            // createFromTableGroup
            // 
            createFromTableGroup.BackgroundImageLayout = ImageLayout.None;
            createFromTableGroup.Controls.Add(label1);
            createFromTableGroup.Controls.Add(selectExcelFileSheetCombox);
            createFromTableGroup.Controls.Add(selectedExcelFileLabel);
            createFromTableGroup.Controls.Add(selectExcelFile);
            createFromTableGroup.Controls.Add(excelTablePreview);
            createFromTableGroup.Enabled = false;
            createFromTableGroup.FlatStyle = FlatStyle.Flat;
            createFromTableGroup.Location = new Point(335, 37);
            createFromTableGroup.Name = "createFromTableGroup";
            createFromTableGroup.Size = new Size(625, 425);
            createFromTableGroup.TabIndex = 26;
            createFromTableGroup.TabStop = false;
            createFromTableGroup.Text = "Criar de tabela";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(372, 16);
            label1.Margin = new Padding(3);
            label1.Name = "label1";
            label1.Size = new Size(117, 15);
            label1.TabIndex = 26;
            label1.Text = "Planilha selecionada:\r\n";
            // 
            // selectExcelFileSheetCombox
            // 
            selectExcelFileSheetCombox.FormattingEnabled = true;
            selectExcelFileSheetCombox.Location = new Point(372, 37);
            selectExcelFileSheetCombox.Name = "selectExcelFileSheetCombox";
            selectExcelFileSheetCombox.Size = new Size(189, 23);
            selectExcelFileSheetCombox.TabIndex = 25;
            // 
            // selectedExcelFileLabel
            // 
            selectedExcelFileLabel.AutoSize = true;
            selectedExcelFileLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            selectedExcelFileLabel.Location = new Point(6, 40);
            selectedExcelFileLabel.Margin = new Padding(3);
            selectedExcelFileLabel.Name = "selectedExcelFileLabel";
            selectedExcelFileLabel.Size = new Size(163, 15);
            selectedExcelFileLabel.TabIndex = 24;
            selectedExcelFileLabel.Text = "Nenhum arquivo selecionado";
            // 
            // selectExcelFile
            // 
            selectExcelFile.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            selectExcelFile.Location = new Point(5, 59);
            selectExcelFile.Margin = new Padding(2);
            selectExcelFile.Name = "selectExcelFile";
            selectExcelFile.Size = new Size(193, 38);
            selectExcelFile.TabIndex = 24;
            selectExcelFile.Text = "Selecionar arquivo excel";
            selectExcelFile.UseVisualStyleBackColor = true;
            selectExcelFile.Click += SelectExcelFile;
            // 
            // excelTablePreview
            // 
            excelTablePreview.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            excelTablePreview.Location = new Point(5, 102);
            excelTablePreview.Name = "excelTablePreview";
            excelTablePreview.RowTemplate.Height = 25;
            excelTablePreview.Size = new Size(614, 317);
            excelTablePreview.TabIndex = 0;
            // 
            // createOption1
            // 
            createOption1.AutoSize = true;
            createOption1.Checked = true;
            createOption1.Location = new Point(18, 12);
            createOption1.Name = "createOption1";
            createOption1.Size = new Size(83, 19);
            createOption1.TabIndex = 27;
            createOption1.TabStop = true;
            createOption1.Text = "Criar unico";
            createOption1.UseVisualStyleBackColor = true;
            createOption1.CheckedChanged += CreateSingleChecked;
            // 
            // createOption2
            // 
            createOption2.AutoSize = true;
            createOption2.Location = new Point(335, 12);
            createOption2.Name = "createOption2";
            createOption2.Size = new Size(101, 19);
            createOption2.TabIndex = 28;
            createOption2.Text = "Criar de tabela";
            createOption2.UseVisualStyleBackColor = true;
            createOption2.CheckedChanged += CreateFromTableChecked;
            // 
            // CriarNovoDesenho
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(972, 533);
            Controls.Add(registerButton);
            Controls.Add(createOption2);
            Controls.Add(createOption1);
            Controls.Add(createFromTableGroup);
            Controls.Add(createSingleGroup);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "CriarNovoDesenho";
            Text = "Registrar Novo Desenho";
            KeyDown += Enter;
            createSingleGroup.ResumeLayout(false);
            createSingleGroup.PerformLayout();
            createFromTableGroup.ResumeLayout(false);
            createFromTableGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)excelTablePreview).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label dateLabel;
        private DateTimePicker date;
        private TextBox description;
        private Label descriptionLabel;
        private TextBox name;
        private Label nameLabel;
        private TextBox code;
        private Label codeLabel;
        private CheckBox useFileDataCheckBox;
        private CheckBox createCodeCheckBox;
        private Button selectDrawButton;
        private Label selectedFileLabel;
        private Button registerButton;
        private OpenFileDialog openFileDialog;
        private GroupBox createSingleGroup;
        private GroupBox createFromTableGroup;
        private RadioButton createOption1;
        private Label label1;
        private ComboBox selectExcelFileSheetCombox;
        private Label selectedExcelFileLabel;
        private Button selectExcelFile;
        private DataGridView excelTablePreview;
        private RadioButton createOption2;
        private OpenFileDialog openExcelFileDialog;
    }
}