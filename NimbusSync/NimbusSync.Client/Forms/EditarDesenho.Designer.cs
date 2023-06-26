namespace NimbusSync.Client.Forms
{
    partial class EditarDesenho
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
            registerButton = new Button();
            selectedFileLabel = new Label();
            selectDrawButton = new Button();
            dateLabel = new Label();
            date = new DateTimePicker();
            description = new TextBox();
            descriptionLabel = new Label();
            name = new TextBox();
            nameLabel = new Label();
            code = new TextBox();
            codeLabel = new Label();
            openFileDialog = new OpenFileDialog();
            SuspendLayout();
            // 
            // registerButton
            // 
            registerButton.BackColor = Color.FromArgb(12, 192, 223);
            registerButton.FlatStyle = FlatStyle.Flat;
            registerButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            registerButton.Location = new Point(193, 344);
            registerButton.Name = "registerButton";
            registerButton.Size = new Size(103, 38);
            registerButton.TabIndex = 37;
            registerButton.Text = "Alterar";
            registerButton.UseVisualStyleBackColor = false;
            registerButton.Click += AlterarDesenho;
            // 
            // selectedFileLabel
            // 
            selectedFileLabel.AutoSize = true;
            selectedFileLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            selectedFileLabel.Location = new Point(12, 367);
            selectedFileLabel.Margin = new Padding(3);
            selectedFileLabel.Name = "selectedFileLabel";
            selectedFileLabel.Size = new Size(163, 15);
            selectedFileLabel.TabIndex = 36;
            selectedFileLabel.Text = "Nenhum arquivo selecionado";
            // 
            // selectDrawButton
            // 
            selectDrawButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            selectDrawButton.Location = new Point(12, 324);
            selectDrawButton.Margin = new Padding(2);
            selectDrawButton.Name = "selectDrawButton";
            selectDrawButton.Size = new Size(148, 38);
            selectDrawButton.TabIndex = 35;
            selectDrawButton.Text = "Selecionar arquivo";
            selectDrawButton.UseVisualStyleBackColor = true;
            selectDrawButton.Click += SelecionarArquivo;
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dateLabel.Location = new Point(154, 12);
            dateLabel.Margin = new Padding(3);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new Size(42, 21);
            dateLabel.TabIndex = 32;
            dateLabel.Text = "Data";
            // 
            // date
            // 
            date.CalendarFont = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            date.CalendarMonthBackground = Color.FromArgb(165, 161, 161);
            date.Enabled = false;
            date.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            date.Format = DateTimePickerFormat.Short;
            date.Location = new Point(154, 39);
            date.Name = "date";
            date.Size = new Size(142, 29);
            date.TabIndex = 31;
            // 
            // description
            // 
            description.BackColor = Color.FromArgb(165, 161, 161);
            description.BorderStyle = BorderStyle.None;
            description.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            description.Location = new Point(12, 164);
            description.Multiline = true;
            description.Name = "description";
            description.Size = new Size(284, 155);
            description.TabIndex = 30;
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            descriptionLabel.Location = new Point(12, 137);
            descriptionLabel.Margin = new Padding(3);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new Size(77, 21);
            descriptionLabel.TabIndex = 29;
            descriptionLabel.Text = "Descrição";
            // 
            // name
            // 
            name.BackColor = Color.FromArgb(165, 161, 161);
            name.BorderStyle = BorderStyle.None;
            name.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            name.Location = new Point(12, 109);
            name.Name = "name";
            name.Size = new Size(284, 22);
            name.TabIndex = 28;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            nameLabel.Location = new Point(12, 82);
            nameLabel.Margin = new Padding(3);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(138, 21);
            nameLabel.TabIndex = 27;
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
            code.TabIndex = 26;
            // 
            // codeLabel
            // 
            codeLabel.AutoSize = true;
            codeLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            codeLabel.Location = new Point(12, 12);
            codeLabel.Margin = new Padding(3);
            codeLabel.Name = "codeLabel";
            codeLabel.Size = new Size(60, 21);
            codeLabel.TabIndex = 25;
            codeLabel.Text = "Codigo";
            codeLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // openFileDialog
            // 
            openFileDialog.FileName = "openFileDialog";
            // 
            // EditarDesenho
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(311, 398);
            Controls.Add(registerButton);
            Controls.Add(selectedFileLabel);
            Controls.Add(selectDrawButton);
            Controls.Add(dateLabel);
            Controls.Add(date);
            Controls.Add(description);
            Controls.Add(descriptionLabel);
            Controls.Add(name);
            Controls.Add(nameLabel);
            Controls.Add(code);
            Controls.Add(codeLabel);
            Name = "EditarDesenho";
            Text = "EditarDesenho";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button registerButton;
        private Label selectedFileLabel;
        private Button selectDrawButton;
        private Label dateLabel;
        private DateTimePicker date;
        private TextBox description;
        private Label descriptionLabel;
        private TextBox name;
        private Label nameLabel;
        private TextBox code;
        private Label codeLabel;
        private OpenFileDialog openFileDialog;
    }
}