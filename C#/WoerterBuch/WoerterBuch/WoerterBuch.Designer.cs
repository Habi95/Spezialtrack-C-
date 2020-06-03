namespace WoerterBuch
{
    partial class BackGround
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.labelTranslation = new System.Windows.Forms.Label();
            this.tbGermanWord = new System.Windows.Forms.TextBox();
            this.tbEnglishWord = new System.Windows.Forms.TextBox();
            this.lbGermanWords = new System.Windows.Forms.ListBox();
            this.tbTranslation = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(332, 53);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 0;
            this.button1.Text = "Hinzufügen";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelTranslation
            // 
            this.labelTranslation.AutoSize = true;
            this.labelTranslation.Location = new System.Drawing.Point(344, 18);
            this.labelTranslation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTranslation.Name = "labelTranslation";
            this.labelTranslation.Size = new System.Drawing.Size(85, 17);
            this.labelTranslation.TabIndex = 1;
            this.labelTranslation.Text = "DE < > ENG";
            // 
            // tbGermanWord
            // 
            this.tbGermanWord.Location = new System.Drawing.Point(73, 15);
            this.tbGermanWord.Margin = new System.Windows.Forms.Padding(4);
            this.tbGermanWord.Name = "tbGermanWord";
            this.tbGermanWord.Size = new System.Drawing.Size(195, 22);
            this.tbGermanWord.TabIndex = 2;
            // 
            // tbEnglishWord
            // 
            this.tbEnglishWord.Location = new System.Drawing.Point(528, 15);
            this.tbEnglishWord.Margin = new System.Windows.Forms.Padding(4);
            this.tbEnglishWord.Name = "tbEnglishWord";
            this.tbEnglishWord.Size = new System.Drawing.Size(243, 22);
            this.tbEnglishWord.TabIndex = 3;
            // 
            // lbGermanWords
            // 
            this.lbGermanWords.FormattingEnabled = true;
            this.lbGermanWords.ItemHeight = 16;
            this.lbGermanWords.Location = new System.Drawing.Point(73, 318);
            this.lbGermanWords.Margin = new System.Windows.Forms.Padding(4);
            this.lbGermanWords.Name = "lbGermanWords";
            this.lbGermanWords.Size = new System.Drawing.Size(159, 116);
            this.lbGermanWords.TabIndex = 4;
            this.lbGermanWords.SelectedIndexChanged += new System.EventHandler(this.lbGermanWords_SelectedIndexChanged);
            // 
            // tbTranslation
            // 
            this.tbTranslation.Location = new System.Drawing.Point(560, 318);
            this.tbTranslation.Name = "tbTranslation";
            this.tbTranslation.Size = new System.Drawing.Size(192, 22);
            this.tbTranslation.TabIndex = 5;
            // 
            // BackGround
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbTranslation);
            this.Controls.Add(this.lbGermanWords);
            this.Controls.Add(this.tbEnglishWord);
            this.Controls.Add(this.tbGermanWord);
            this.Controls.Add(this.labelTranslation);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "BackGround";
            this.Text = "WörterBuch";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelTranslation;
        private System.Windows.Forms.TextBox tbGermanWord;
        private System.Windows.Forms.TextBox tbEnglishWord;
        private System.Windows.Forms.ListBox lbGermanWords;
        private System.Windows.Forms.TextBox tbTranslation;
    }
}

