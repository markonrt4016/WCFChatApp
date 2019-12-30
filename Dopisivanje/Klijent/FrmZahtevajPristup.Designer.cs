namespace Klijent
{
    partial class FrmZahtevajPristup
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
            this.btnPosaljiZahtev = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.flowZahtevaneGrupe = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.lstZahtevi = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnPosaljiZahtev
            // 
            this.btnPosaljiZahtev.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPosaljiZahtev.Location = new System.Drawing.Point(73, 401);
            this.btnPosaljiZahtev.Name = "btnPosaljiZahtev";
            this.btnPosaljiZahtev.Size = new System.Drawing.Size(248, 37);
            this.btnPosaljiZahtev.TabIndex = 5;
            this.btnPosaljiZahtev.Text = "Pošalji zahtev za priključenje";
            this.btnPosaljiZahtev.UseVisualStyleBackColor = true;
            this.btnPosaljiZahtev.Click += new System.EventHandler(this.btnPosaljiZahtev_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(103, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Grupe za dopisivanje:";
            // 
            // flowZahtevaneGrupe
            // 
            this.flowZahtevaneGrupe.Location = new System.Drawing.Point(15, 56);
            this.flowZahtevaneGrupe.Name = "flowZahtevaneGrupe";
            this.flowZahtevaneGrupe.Size = new System.Drawing.Size(371, 147);
            this.flowZahtevaneGrupe.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(129, 215);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Vaši zahtevi:";
            // 
            // lstZahtevi
            // 
            this.lstZahtevi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstZahtevi.FormattingEnabled = true;
            this.lstZahtevi.ItemHeight = 16;
            this.lstZahtevi.Location = new System.Drawing.Point(15, 248);
            this.lstZahtevi.Name = "lstZahtevi";
            this.lstZahtevi.Size = new System.Drawing.Size(371, 132);
            this.lstZahtevi.TabIndex = 7;
            // 
            // FrmZahtevajPristup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 450);
            this.Controls.Add(this.lstZahtevi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnPosaljiZahtev);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flowZahtevaneGrupe);
            this.Name = "FrmZahtevajPristup";
            this.Text = "FrmZahtevajPristup2";
            this.Load += new System.EventHandler(this.FrmZahtevajPristup_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPosaljiZahtev;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowZahtevaneGrupe;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lstZahtevi;
    }
}