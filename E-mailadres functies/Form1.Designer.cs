namespace E_mailadres_functies
{
    partial class Form1
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
            InvoerTextBox = new TextBox();
            SelectButton = new Button();
            label1 = new Label();
            label2 = new Label();
            GebruikerLabel = new Label();
            ServerLabel = new Label();
            SuspendLayout();
            // 
            // InvoerTextBox
            // 
            InvoerTextBox.Location = new Point(12, 12);
            InvoerTextBox.Name = "InvoerTextBox";
            InvoerTextBox.Size = new Size(283, 23);
            InvoerTextBox.TabIndex = 0;
            // 
            // SelectButton
            // 
            SelectButton.Location = new Point(12, 41);
            SelectButton.Name = "SelectButton";
            SelectButton.Size = new Size(283, 23);
            SelectButton.TabIndex = 1;
            SelectButton.Text = "selecteer gebruiker en server";
            SelectButton.UseVisualStyleBackColor = true;
            SelectButton.Click += SelectButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 67);
            label1.Name = "label1";
            label1.Size = new Size(61, 15);
            label1.TabIndex = 2;
            label1.Text = "Gebruiker:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 92);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 3;
            label2.Text = "Server:";
            // 
            // GebruikerLabel
            // 
            GebruikerLabel.AutoSize = true;
            GebruikerLabel.Location = new Point(79, 67);
            GebruikerLabel.Name = "GebruikerLabel";
            GebruikerLabel.Size = new Size(12, 15);
            GebruikerLabel.TabIndex = 4;
            GebruikerLabel.Text = "?";
            // 
            // ServerLabel
            // 
            ServerLabel.AutoSize = true;
            ServerLabel.Location = new Point(79, 92);
            ServerLabel.Name = "ServerLabel";
            ServerLabel.Size = new Size(12, 15);
            ServerLabel.TabIndex = 5;
            ServerLabel.Text = "?";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(318, 122);
            Controls.Add(ServerLabel);
            Controls.Add(GebruikerLabel);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(SelectButton);
            Controls.Add(InvoerTextBox);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox InvoerTextBox;
        private Button SelectButton;
        private Label label1;
        private Label label2;
        private Label GebruikerLabel;
        private Label ServerLabel;
    }
}
