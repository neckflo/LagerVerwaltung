namespace LagerVerwaltung
{
    partial class anzeigen
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
            this.dataGridViewLager = new System.Windows.Forms.DataGridView();
            this.button_zuruck_lagerverwaltung = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button_anzeigen_lagerverwaltung = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLager)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewLager
            // 
            this.dataGridViewLager.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLager.Location = new System.Drawing.Point(12, 63);
            this.dataGridViewLager.Name = "dataGridViewLager";
            this.dataGridViewLager.Size = new System.Drawing.Size(680, 279);
            this.dataGridViewLager.TabIndex = 0;
            // 
            // button_zuruck_lagerverwaltung
            // 
            this.button_zuruck_lagerverwaltung.Location = new System.Drawing.Point(617, 365);
            this.button_zuruck_lagerverwaltung.Name = "button_zuruck_lagerverwaltung";
            this.button_zuruck_lagerverwaltung.Size = new System.Drawing.Size(75, 23);
            this.button_zuruck_lagerverwaltung.TabIndex = 1;
            this.button_zuruck_lagerverwaltung.Text = "Zurück";
            this.button_zuruck_lagerverwaltung.UseVisualStyleBackColor = true;
            this.button_zuruck_lagerverwaltung.Click += new System.EventHandler(this.button_zuruck_lagerverwaltung_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 365);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(121, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Daten Sichern";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Lagerverwaltung";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 36);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 4;
            // 
            // button_anzeigen_lagerverwaltung
            // 
            this.button_anzeigen_lagerverwaltung.Location = new System.Drawing.Point(139, 36);
            this.button_anzeigen_lagerverwaltung.Name = "button_anzeigen_lagerverwaltung";
            this.button_anzeigen_lagerverwaltung.Size = new System.Drawing.Size(75, 23);
            this.button_anzeigen_lagerverwaltung.TabIndex = 5;
            this.button_anzeigen_lagerverwaltung.Text = "Anzeigen";
            this.button_anzeigen_lagerverwaltung.UseVisualStyleBackColor = true;
            this.button_anzeigen_lagerverwaltung.Click += new System.EventHandler(this.button_anzeigen_lagerverwaltung_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(582, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 30);
            this.button1.TabIndex = 6;
            this.button1.Text = "Karte zeigen";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // anzeigen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 400);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button_anzeigen_lagerverwaltung);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button_zuruck_lagerverwaltung);
            this.Controls.Add(this.dataGridViewLager);
            this.Name = "anzeigen";
            this.Text = "anzeigen";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLager)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewLager;
        private System.Windows.Forms.Button button_zuruck_lagerverwaltung;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button_anzeigen_lagerverwaltung;
        private System.Windows.Forms.Button button1;
    }
}