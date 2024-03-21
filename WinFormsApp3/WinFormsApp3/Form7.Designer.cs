namespace WinFormsApp3
{
    partial class Form7
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
            textBoxNewValue = new TextBox();
            save = new Button();
            comboBoxFields = new ComboBox();
            SuspendLayout();
            // 
            // textBoxNewValue
            // 
            textBoxNewValue.Location = new Point(341, 106);
            textBoxNewValue.Name = "textBoxNewValue";
            textBoxNewValue.Size = new Size(100, 23);
            textBoxNewValue.TabIndex = 0;
            // 
            // save
            // 
            save.Location = new Point(351, 159);
            save.Name = "save";
            save.Size = new Size(75, 23);
            save.TabIndex = 1;
            save.Text = "save";
            save.UseVisualStyleBackColor = true;
            save.Click += save_Click;
            // 
            // comboBoxFields
            // 
            comboBoxFields.FormattingEnabled = true;
            comboBoxFields.Location = new Point(331, 63);
            comboBoxFields.Name = "comboBoxFields";
            comboBoxFields.Size = new Size(121, 23);
            comboBoxFields.TabIndex = 2;
            // 
            // Form7
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(comboBoxFields);
            Controls.Add(save);
            Controls.Add(textBoxNewValue);
            Name = "Form7";
            Text = " ";
            Load += Form7_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxNewValue;
        private Button save;
        private ComboBox comboBoxFields;
    }
}