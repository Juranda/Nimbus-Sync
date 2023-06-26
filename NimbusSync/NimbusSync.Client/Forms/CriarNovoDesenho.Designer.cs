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
            SuspendLayout();
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dateLabel.Location = new Point(154, 12);
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
            date.Location = new Point(154, 33);
            date.Name = "date";
            date.Size = new Size(142, 29);
            date.TabIndex = 18;
            // 
            // description
            // 
            description.BackColor = Color.FromArgb(165, 161, 161);
            description.BorderStyle = BorderStyle.None;
            description.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            description.Location = new Point(12, 185);
            description.Multiline = true;
            description.Name = "description";
            description.Size = new Size(284, 155);
            description.TabIndex = 17;
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            descriptionLabel.Location = new Point(10, 158);
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
            name.Location = new Point(10, 119);
            name.Name = "name";
            name.Size = new Size(284, 22);
            name.TabIndex = 15;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            nameLabel.Location = new Point(10, 92);
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
            code.Location = new Point(12, 39);
            code.Name = "code";
            code.Size = new Size(136, 22);
            code.TabIndex = 13;
            // 
            // codeLabel
            // 
            codeLabel.AutoSize = true;
            codeLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            codeLabel.Location = new Point(12, 12);
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
            useFileDataCheckBox.Location = new Point(154, 65);
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
            createCodeCheckBox.Location = new Point(12, 65);
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
            selectDrawButton.Location = new Point(12, 345);
            selectDrawButton.Margin = new Padding(2);
            selectDrawButton.Name = "selectDrawButton";
            selectDrawButton.Size = new Size(148, 38);
            selectDrawButton.TabIndex = 22;
            selectDrawButton.Text = "Selecionar arquivo";
            selectDrawButton.UseVisualStyleBackColor = true;
            selectDrawButton.Click += selectDrawButton_Click;
            // 
            // selectedFileLabel
            // 
            selectedFileLabel.AutoSize = true;
            selectedFileLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            selectedFileLabel.Location = new Point(12, 388);
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
            registerButton.Location = new Point(193, 408);
            registerButton.Name = "registerButton";
            registerButton.Size = new Size(103, 38);
            registerButton.TabIndex = 24;
            registerButton.Text = "Registrar";
            registerButton.UseVisualStyleBackColor = false;
            registerButton.Click += RegisterDraw;
            // 
            // openFileDialog
            // 
            openFileDialog.FileName = "Desenho 1";
            // 
            // CriarNovoDesenho
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(308, 458);
            Controls.Add(registerButton);
            Controls.Add(selectedFileLabel);
            Controls.Add(selectDrawButton);
            Controls.Add(createCodeCheckBox);
            Controls.Add(useFileDataCheckBox);
            Controls.Add(dateLabel);
            Controls.Add(date);
            Controls.Add(description);
            Controls.Add(descriptionLabel);
            Controls.Add(name);
            Controls.Add(nameLabel);
            Controls.Add(code);
            Controls.Add(codeLabel);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "CriarNovoDesenho";
            Text = "Registrar Novo Desenho";
            KeyDown += Enter;
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
    }
}