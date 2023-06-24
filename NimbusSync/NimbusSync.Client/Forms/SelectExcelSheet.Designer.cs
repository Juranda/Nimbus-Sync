namespace NimbusSync.Client
{
    partial class SelectExcelSheet
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
            selectSheet = new ComboBox();
            okButton = new Button();
            SuspendLayout();
            // 
            // selectSheet
            // 
            selectSheet.FormattingEnabled = true;
            selectSheet.ImeMode = ImeMode.NoControl;
            selectSheet.Location = new Point(12, 12);
            selectSheet.Name = "selectSheet";
            selectSheet.Size = new Size(221, 23);
            selectSheet.TabIndex = 0;
            selectSheet.SelectedIndexChanged += LoadExcelSheet;
            // 
            // okButton
            // 
            okButton.Location = new Point(239, 12);
            okButton.Name = "okButton";
            okButton.Size = new Size(75, 23);
            okButton.TabIndex = 1;
            okButton.Text = "Ok";
            okButton.UseVisualStyleBackColor = true;
            okButton.Click += okButton_Click;
            // 
            // SelectExcelSheet
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Snow;
            ClientSize = new Size(324, 47);
            Controls.Add(okButton);
            Controls.Add(selectSheet);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "SelectExcelSheet";
            Text = "Selecione a planilha";
            ResumeLayout(false);
        }

        #endregion

        private ComboBox selectSheet;
        private Button okButton;
    }
}