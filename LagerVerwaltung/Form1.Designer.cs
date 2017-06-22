namespace LagerVerwaltung
{
    partial class Form1
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
            this.button_verbinden = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button_hinzufugen = new System.Windows.Forms.Button();
            this.button_loschen = new System.Windows.Forms.Button();
            this.label_meldung = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_verbinden
            // 
            this.button_verbinden.Location = new System.Drawing.Point(39, 30);
            this.button_verbinden.Name = "button_verbinden";
            this.button_verbinden.Size = new System.Drawing.Size(75, 23);
            this.button_verbinden.TabIndex = 2;
            this.button_verbinden.Text = "Verbinden";
            this.button_verbinden.UseVisualStyleBackColor = true;
            this.button_verbinden.Click += new System.EventHandler(this.button_verbinden_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(303, 37);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 3;
            this.button4.Text = "Anzeigen";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button_hinzufugen
            // 
            this.button_hinzufugen.Location = new System.Drawing.Point(303, 76);
            this.button_hinzufugen.Name = "button_hinzufugen";
            this.button_hinzufugen.Size = new System.Drawing.Size(75, 23);
            this.button_hinzufugen.TabIndex = 4;
            this.button_hinzufugen.Text = "Hinzufügen";
            this.button_hinzufugen.UseVisualStyleBackColor = true;
            this.button_hinzufugen.Click += new System.EventHandler(this.button_hinzufugen_Click);
            // 
            // button_loschen
            // 
            this.button_loschen.Location = new System.Drawing.Point(303, 114);
            this.button_loschen.Name = "button_loschen";
            this.button_loschen.Size = new System.Drawing.Size(75, 23);
            this.button_loschen.TabIndex = 5;
            this.button_loschen.Text = "Löschen";
            this.button_loschen.UseVisualStyleBackColor = true;
            // 
            // label_meldung
            // 
            this.label_meldung.AutoSize = true;
            this.label_meldung.Location = new System.Drawing.Point(135, 35);
            this.label_meldung.Name = "label_meldung";
            this.label_meldung.Size = new System.Drawing.Size(0, 13);
            this.label_meldung.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 375);
            this.Controls.Add(this.label_meldung);
            this.Controls.Add(this.button_loschen);
            this.Controls.Add(this.button_hinzufugen);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button_verbinden);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_verbinden;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button_hinzufugen;
        private System.Windows.Forms.Button button_loschen;
        private System.Windows.Forms.Label label_meldung;
    }
}

