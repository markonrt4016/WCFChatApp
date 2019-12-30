namespace Klijent
{
    partial class FrmKlijent
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
            this.components = new System.ComponentModel.Container();
            this.label3 = new System.Windows.Forms.Label();
            this.btnPosalji = new System.Windows.Forms.Button();
            this.txtPoruka = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.posaljiZahtevZaPrikljucenjeNovojGrupiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.napustiGrupuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ulogovaniSteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lstPoruke = new System.Windows.Forms.ListBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnOdjava = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(289, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Poruke korisnika:";
            // 
            // btnPosalji
            // 
            this.btnPosalji.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPosalji.Location = new System.Drawing.Point(570, 415);
            this.btnPosalji.Name = "btnPosalji";
            this.btnPosalji.Size = new System.Drawing.Size(132, 35);
            this.btnPosalji.TabIndex = 8;
            this.btnPosalji.Text = "Pošalji";
            this.btnPosalji.UseVisualStyleBackColor = true;
            this.btnPosalji.Click += new System.EventHandler(this.btnPosalji_Click);
            // 
            // txtPoruka
            // 
            this.txtPoruka.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPoruka.Location = new System.Drawing.Point(12, 419);
            this.txtPoruka.Name = "txtPoruka";
            this.txtPoruka.Size = new System.Drawing.Size(533, 26);
            this.txtPoruka.TabIndex = 7;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.posaljiZahtevZaPrikljucenjeNovojGrupiToolStripMenuItem,
            this.napustiGrupuToolStripMenuItem,
            this.ulogovaniSteToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(724, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // posaljiZahtevZaPrikljucenjeNovojGrupiToolStripMenuItem
            // 
            this.posaljiZahtevZaPrikljucenjeNovojGrupiToolStripMenuItem.Name = "posaljiZahtevZaPrikljucenjeNovojGrupiToolStripMenuItem";
            this.posaljiZahtevZaPrikljucenjeNovojGrupiToolStripMenuItem.Size = new System.Drawing.Size(140, 20);
            this.posaljiZahtevZaPrikljucenjeNovojGrupiToolStripMenuItem.Text = "Zahtev za pristup grupi";
            this.posaljiZahtevZaPrikljucenjeNovojGrupiToolStripMenuItem.Click += new System.EventHandler(this.posaljiZahtevZaPrikljucenjeNovojGrupiToolStripMenuItem_Click);
            // 
            // napustiGrupuToolStripMenuItem
            // 
            this.napustiGrupuToolStripMenuItem.Name = "napustiGrupuToolStripMenuItem";
            this.napustiGrupuToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.napustiGrupuToolStripMenuItem.Text = "Napusti grupu";
            this.napustiGrupuToolStripMenuItem.Click += new System.EventHandler(this.napustiGrupuToolStripMenuItem_Click);
            // 
            // ulogovaniSteToolStripMenuItem
            // 
            this.ulogovaniSteToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.ulogovaniSteToolStripMenuItem.Name = "ulogovaniSteToolStripMenuItem";
            this.ulogovaniSteToolStripMenuItem.Size = new System.Drawing.Size(96, 20);
            this.ulogovaniSteToolStripMenuItem.Text = "ulogovani ste..";
            // 
            // lstPoruke
            // 
            this.lstPoruke.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstPoruke.FormattingEnabled = true;
            this.lstPoruke.ItemHeight = 20;
            this.lstPoruke.Location = new System.Drawing.Point(12, 96);
            this.lstPoruke.Name = "lstPoruke";
            this.lstPoruke.Size = new System.Drawing.Size(690, 304);
            this.lstPoruke.TabIndex = 11;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 300;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnOdjava
            // 
            this.btnOdjava.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOdjava.Location = new System.Drawing.Point(574, 27);
            this.btnOdjava.Name = "btnOdjava";
            this.btnOdjava.Size = new System.Drawing.Size(138, 33);
            this.btnOdjava.TabIndex = 12;
            this.btnOdjava.Text = "Odjavi se";
            this.btnOdjava.UseVisualStyleBackColor = true;
            this.btnOdjava.Click += new System.EventHandler(this.btnOdjava_Click);
            // 
            // FrmKlijent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 483);
            this.Controls.Add(this.btnOdjava);
            this.Controls.Add(this.lstPoruke);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnPosalji);
            this.Controls.Add(this.txtPoruka);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmKlijent";
            this.Text = "FrmKlijent";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmKlijent_FormClosing);
            this.Load += new System.EventHandler(this.FrmKlijent_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnPosalji;
        private System.Windows.Forms.TextBox txtPoruka;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem posaljiZahtevZaPrikljucenjeNovojGrupiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem napustiGrupuToolStripMenuItem;
        private System.Windows.Forms.ListBox lstPoruke;
        private System.Windows.Forms.ToolStripMenuItem ulogovaniSteToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnOdjava;
    }
}