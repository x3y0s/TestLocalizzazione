namespace TestLocalizzazione
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelCulture = new System.Windows.Forms.Label();
            this.labelCurrentCultureTitle = new System.Windows.Forms.Label();
            this.labelCurrentUICultureTitle = new System.Windows.Forms.Label();
            this.labelUICulture = new System.Windows.Forms.Label();
            this.labelTranslation = new System.Windows.Forms.Label();
            this.radioButtonEnglish = new System.Windows.Forms.RadioButton();
            this.radioButtonItalian = new System.Windows.Forms.RadioButton();
            this.radioButtonDeutch = new System.Windows.Forms.RadioButton();
            this.radioButtonSpanish = new System.Windows.Forms.RadioButton();
            this.radioButtonMalta = new System.Windows.Forms.RadioButton();
            this.labelTranslationCulture = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelCulture
            // 
            this.labelCulture.AutoSize = true;
            this.labelCulture.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelCulture.Location = new System.Drawing.Point(192, 44);
            this.labelCulture.Name = "labelCulture";
            this.labelCulture.Size = new System.Drawing.Size(39, 13);
            this.labelCulture.TabIndex = 0;
            this.labelCulture.Text = "culture";
            // 
            // labelCurrentCultureTitle
            // 
            this.labelCurrentCultureTitle.AutoSize = true;
            this.labelCurrentCultureTitle.Location = new System.Drawing.Point(47, 43);
            this.labelCurrentCultureTitle.Name = "labelCurrentCultureTitle";
            this.labelCurrentCultureTitle.Size = new System.Drawing.Size(128, 13);
            this.labelCurrentCultureTitle.TabIndex = 1;
            this.labelCurrentCultureTitle.Text = "CULTURA DEFAULT => ";
            // 
            // labelCurrentUICultureTitle
            // 
            this.labelCurrentUICultureTitle.AutoSize = true;
            this.labelCurrentUICultureTitle.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelCurrentUICultureTitle.Location = new System.Drawing.Point(47, 70);
            this.labelCurrentUICultureTitle.Name = "labelCurrentUICultureTitle";
            this.labelCurrentUICultureTitle.Size = new System.Drawing.Size(142, 13);
            this.labelCurrentUICultureTitle.TabIndex = 6;
            this.labelCurrentUICultureTitle.Text = "CULTURA DEFAULT UI => ";
            // 
            // labelUICulture
            // 
            this.labelUICulture.AutoSize = true;
            this.labelUICulture.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelUICulture.Location = new System.Drawing.Point(192, 70);
            this.labelUICulture.Name = "labelUICulture";
            this.labelUICulture.Size = new System.Drawing.Size(39, 13);
            this.labelUICulture.TabIndex = 7;
            this.labelUICulture.Text = "culture";
            // 
            // labelTranslation
            // 
            this.labelTranslation.AutoSize = true;
            this.labelTranslation.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.labelTranslation.Location = new System.Drawing.Point(45, 102);
            this.labelTranslation.Name = "labelTranslation";
            this.labelTranslation.Size = new System.Drawing.Size(217, 25);
            this.labelTranslation.TabIndex = 8;
            this.labelTranslation.Text = "TESTO TRADOTTO";
            // 
            // radioButtonEnglish
            // 
            this.radioButtonEnglish.AutoSize = true;
            this.radioButtonEnglish.Location = new System.Drawing.Point(355, 41);
            this.radioButtonEnglish.Name = "radioButtonEnglish";
            this.radioButtonEnglish.Size = new System.Drawing.Size(59, 17);
            this.radioButtonEnglish.TabIndex = 10;
            this.radioButtonEnglish.TabStop = true;
            this.radioButtonEnglish.Text = "Inglese";
            this.radioButtonEnglish.UseVisualStyleBackColor = true;
            this.radioButtonEnglish.CheckedChanged += new System.EventHandler(this.radioButtonEnglish_CheckedChanged);
            // 
            // radioButtonItalian
            // 
            this.radioButtonItalian.AutoSize = true;
            this.radioButtonItalian.Location = new System.Drawing.Point(355, 63);
            this.radioButtonItalian.Name = "radioButtonItalian";
            this.radioButtonItalian.Size = new System.Drawing.Size(59, 17);
            this.radioButtonItalian.TabIndex = 11;
            this.radioButtonItalian.TabStop = true;
            this.radioButtonItalian.Text = "Italiano";
            this.radioButtonItalian.UseVisualStyleBackColor = true;
            this.radioButtonItalian.CheckedChanged += new System.EventHandler(this.radioButtonItalian_CheckedChanged);
            // 
            // radioButtonDeutch
            // 
            this.radioButtonDeutch.AutoSize = true;
            this.radioButtonDeutch.Location = new System.Drawing.Point(355, 86);
            this.radioButtonDeutch.Name = "radioButtonDeutch";
            this.radioButtonDeutch.Size = new System.Drawing.Size(67, 17);
            this.radioButtonDeutch.TabIndex = 12;
            this.radioButtonDeutch.TabStop = true;
            this.radioButtonDeutch.Text = "Tedesco";
            this.radioButtonDeutch.UseVisualStyleBackColor = true;
            this.radioButtonDeutch.CheckedChanged += new System.EventHandler(this.radioButtonDeutch_CheckedChanged);
            // 
            // radioButtonSpanish
            // 
            this.radioButtonSpanish.AutoSize = true;
            this.radioButtonSpanish.Location = new System.Drawing.Point(355, 109);
            this.radioButtonSpanish.Name = "radioButtonSpanish";
            this.radioButtonSpanish.Size = new System.Drawing.Size(70, 17);
            this.radioButtonSpanish.TabIndex = 13;
            this.radioButtonSpanish.TabStop = true;
            this.radioButtonSpanish.Text = "Spagnolo";
            this.radioButtonSpanish.UseVisualStyleBackColor = true;
            this.radioButtonSpanish.CheckedChanged += new System.EventHandler(this.radioButtonSpanish_CheckedChanged);
            // 
            // radioButtonMalta
            // 
            this.radioButtonMalta.AutoSize = true;
            this.radioButtonMalta.Location = new System.Drawing.Point(355, 132);
            this.radioButtonMalta.Name = "radioButtonMalta";
            this.radioButtonMalta.Size = new System.Drawing.Size(51, 17);
            this.radioButtonMalta.TabIndex = 14;
            this.radioButtonMalta.TabStop = true;
            this.radioButtonMalta.Text = "Malta";
            this.radioButtonMalta.UseVisualStyleBackColor = true;
            this.radioButtonMalta.CheckedChanged += new System.EventHandler(this.radioButtonMalta_CheckedChanged);
            // 
            // labelTranslationCulture
            // 
            this.labelTranslationCulture.AutoSize = true;
            this.labelTranslationCulture.Location = new System.Drawing.Point(203, 136);
            this.labelTranslationCulture.Name = "labelTranslationCulture";
            this.labelTranslationCulture.Size = new System.Drawing.Size(39, 13);
            this.labelTranslationCulture.TabIndex = 15;
            this.labelTranslationCulture.Text = "culture";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(47, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "CULTURA TRADUZIONE => ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 175);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelTranslationCulture);
            this.Controls.Add(this.radioButtonMalta);
            this.Controls.Add(this.radioButtonSpanish);
            this.Controls.Add(this.radioButtonDeutch);
            this.Controls.Add(this.radioButtonItalian);
            this.Controls.Add(this.radioButtonEnglish);
            this.Controls.Add(this.labelTranslation);
            this.Controls.Add(this.labelUICulture);
            this.Controls.Add(this.labelCurrentUICultureTitle);
            this.Controls.Add(this.labelCurrentCultureTitle);
            this.Controls.Add(this.labelCulture);
            this.Name = "Form1";
            this.Text = "Localizzazione";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCulture;
        private System.Windows.Forms.Label labelCurrentCultureTitle;
        private System.Windows.Forms.Label labelCurrentUICultureTitle;
        private System.Windows.Forms.Label labelUICulture;
        private System.Windows.Forms.Label labelTranslation;
        private System.Windows.Forms.RadioButton radioButtonEnglish;
        private System.Windows.Forms.RadioButton radioButtonItalian;
        private System.Windows.Forms.RadioButton radioButtonDeutch;
        private System.Windows.Forms.RadioButton radioButtonSpanish;
        private System.Windows.Forms.RadioButton radioButtonMalta;
        private System.Windows.Forms.Label labelTranslationCulture;
        private System.Windows.Forms.Label label1;
    }
}

