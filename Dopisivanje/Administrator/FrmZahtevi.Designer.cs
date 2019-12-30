namespace Administrator
{
    partial class FrmZahtevi
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
            this.flowZahteviGrupe = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOdobri = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // flowZahteviGrupe
            // 
            this.flowZahteviGrupe.Location = new System.Drawing.Point(12, 46);
            this.flowZahteviGrupe.Name = "flowZahteviGrupe";
            this.flowZahteviGrupe.Size = new System.Drawing.Size(594, 324);
            this.flowZahteviGrupe.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(207, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Zahtevi za pristupanje grupi:";
            // 
            // btnOdobri
            // 
            this.btnOdobri.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOdobri.Location = new System.Drawing.Point(195, 376);
            this.btnOdobri.Name = "btnOdobri";
            this.btnOdobri.Size = new System.Drawing.Size(248, 37);
            this.btnOdobri.TabIndex = 2;
            this.btnOdobri.Text = "Odobri odabrane zahteve";
            this.btnOdobri.UseVisualStyleBackColor = true;
            this.btnOdobri.Click += new System.EventHandler(this.btnOdobri_Click);
            // 
            // FrmZahtevi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 425);
            this.Controls.Add(this.btnOdobri);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flowZahteviGrupe);
            this.Name = "FrmZahtevi";
            this.Text = "FrmZahtevi";
            this.Load += new System.EventHandler(this.FrmZahtevi_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowZahteviGrupe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOdobri;
    }
}