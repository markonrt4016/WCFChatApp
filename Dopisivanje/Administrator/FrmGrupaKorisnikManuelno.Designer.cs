namespace Administrator
{
    partial class FrmGrupaKorisnikManuelno
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
            this.cmbKorisnik = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbGrupa = new System.Windows.Forms.ComboBox();
            this.btnDodajKorisnikaGrupu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbKorisnik
            // 
            this.cmbKorisnik.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKorisnik.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbKorisnik.FormattingEnabled = true;
            this.cmbKorisnik.Location = new System.Drawing.Point(34, 64);
            this.cmbKorisnik.Name = "cmbKorisnik";
            this.cmbKorisnik.Size = new System.Drawing.Size(169, 26);
            this.cmbKorisnik.TabIndex = 0;
            this.cmbKorisnik.SelectedIndexChanged += new System.EventHandler(this.cmbKorisnik_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Odaberite korisnika";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(283, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Odaberite grupu";
            // 
            // cmbGrupa
            // 
            this.cmbGrupa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGrupa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbGrupa.FormattingEnabled = true;
            this.cmbGrupa.Location = new System.Drawing.Point(269, 64);
            this.cmbGrupa.Name = "cmbGrupa";
            this.cmbGrupa.Size = new System.Drawing.Size(169, 26);
            this.cmbGrupa.TabIndex = 2;
            // 
            // btnDodajKorisnikaGrupu
            // 
            this.btnDodajKorisnikaGrupu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodajKorisnikaGrupu.Location = new System.Drawing.Point(114, 147);
            this.btnDodajKorisnikaGrupu.Name = "btnDodajKorisnikaGrupu";
            this.btnDodajKorisnikaGrupu.Size = new System.Drawing.Size(227, 55);
            this.btnDodajKorisnikaGrupu.TabIndex = 4;
            this.btnDodajKorisnikaGrupu.Text = "Dodaj korisnika u grupu";
            this.btnDodajKorisnikaGrupu.UseVisualStyleBackColor = true;
            this.btnDodajKorisnikaGrupu.Click += new System.EventHandler(this.btnDodajKorisnikaGrupu_Click);
            // 
            // FrmGrupaKorisnikManuelno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 227);
            this.Controls.Add(this.btnDodajKorisnikaGrupu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbGrupa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbKorisnik);
            this.Name = "FrmGrupaKorisnikManuelno";
            this.Text = "FrmGrupaKorisnikManuelno";
            this.Load += new System.EventHandler(this.FrmGrupaKorisnikManuelno_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbKorisnik;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbGrupa;
        private System.Windows.Forms.Button btnDodajKorisnikaGrupu;
    }
}