namespace Administrator
{
    partial class FrmAdminPanel
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
            this.tabOpcije = new System.Windows.Forms.TabControl();
            this.tabKorisnici = new System.Windows.Forms.TabPage();
            this.pnlOdabirKorisnika = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.lstKorisnici = new System.Windows.Forms.ListBox();
            this.btnAzuriranje = new System.Windows.Forms.Button();
            this.pnlIzmenaKorisnika = new System.Windows.Forms.Panel();
            this.radioKorisnik = new System.Windows.Forms.RadioButton();
            this.radioAdmin = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNick = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.radioObrisiKorisnika = new System.Windows.Forms.RadioButton();
            this.radioIzmeniKorisnika = new System.Windows.Forms.RadioButton();
            this.radioDodajKorisnika = new System.Windows.Forms.RadioButton();
            this.tabGrupe = new System.Windows.Forms.TabPage();
            this.pnlOdabirGrupe = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.lstGrupa = new System.Windows.Forms.ListBox();
            this.pnlIzmenaGrupe = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMaxClanova = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtNazivGrupe = new System.Windows.Forms.TextBox();
            this.btnAzuriranjeGrupa = new System.Windows.Forms.Button();
            this.radioGrupaObrisi = new System.Windows.Forms.RadioButton();
            this.radioGrupaIzmeni = new System.Windows.Forms.RadioButton();
            this.radioGrupaDodaj = new System.Windows.Forms.RadioButton();
            this.tabDopisivanje = new System.Windows.Forms.TabPage();
            this.lstPoruke = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.flowGrupe = new System.Windows.Forms.FlowLayoutPanel();
            this.btnPosalji = new System.Windows.Forms.Button();
            this.txtPoruka = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.odobravanjeZahtevaKorisnikaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trenutnoSteUlogovaniKaoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ručnoDodavanjeKorisnikaUGrupuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnOdjava = new System.Windows.Forms.Button();
            this.tabOpcije.SuspendLayout();
            this.tabKorisnici.SuspendLayout();
            this.pnlOdabirKorisnika.SuspendLayout();
            this.pnlIzmenaKorisnika.SuspendLayout();
            this.tabGrupe.SuspendLayout();
            this.pnlOdabirGrupe.SuspendLayout();
            this.pnlIzmenaGrupe.SuspendLayout();
            this.tabDopisivanje.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabOpcije
            // 
            this.tabOpcije.Controls.Add(this.tabKorisnici);
            this.tabOpcije.Controls.Add(this.tabGrupe);
            this.tabOpcije.Controls.Add(this.tabDopisivanje);
            this.tabOpcije.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabOpcije.Location = new System.Drawing.Point(12, 43);
            this.tabOpcije.Name = "tabOpcije";
            this.tabOpcije.SelectedIndex = 0;
            this.tabOpcije.Size = new System.Drawing.Size(793, 442);
            this.tabOpcije.TabIndex = 0;
            // 
            // tabKorisnici
            // 
            this.tabKorisnici.Controls.Add(this.pnlOdabirKorisnika);
            this.tabKorisnici.Controls.Add(this.btnAzuriranje);
            this.tabKorisnici.Controls.Add(this.pnlIzmenaKorisnika);
            this.tabKorisnici.Controls.Add(this.radioObrisiKorisnika);
            this.tabKorisnici.Controls.Add(this.radioIzmeniKorisnika);
            this.tabKorisnici.Controls.Add(this.radioDodajKorisnika);
            this.tabKorisnici.Location = new System.Drawing.Point(4, 29);
            this.tabKorisnici.Name = "tabKorisnici";
            this.tabKorisnici.Padding = new System.Windows.Forms.Padding(3);
            this.tabKorisnici.Size = new System.Drawing.Size(785, 409);
            this.tabKorisnici.TabIndex = 0;
            this.tabKorisnici.Text = "Korisnici";
            this.tabKorisnici.UseVisualStyleBackColor = true;
            // 
            // pnlOdabirKorisnika
            // 
            this.pnlOdabirKorisnika.Controls.Add(this.label10);
            this.pnlOdabirKorisnika.Controls.Add(this.lstKorisnici);
            this.pnlOdabirKorisnika.Location = new System.Drawing.Point(433, 69);
            this.pnlOdabirKorisnika.Name = "pnlOdabirKorisnika";
            this.pnlOdabirKorisnika.Size = new System.Drawing.Size(327, 334);
            this.pnlOdabirKorisnika.TabIndex = 14;
            this.pnlOdabirKorisnika.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(74, 15);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(164, 20);
            this.label10.TabIndex = 13;
            this.label10.Text = "Odaberite korisnika";
            // 
            // lstKorisnici
            // 
            this.lstKorisnici.FormattingEnabled = true;
            this.lstKorisnici.ItemHeight = 20;
            this.lstKorisnici.Location = new System.Drawing.Point(3, 47);
            this.lstKorisnici.Name = "lstKorisnici";
            this.lstKorisnici.Size = new System.Drawing.Size(321, 284);
            this.lstKorisnici.TabIndex = 12;
            this.lstKorisnici.SelectedIndexChanged += new System.EventHandler(this.lstKorisnici_SelectedIndexChanged);
            // 
            // btnAzuriranje
            // 
            this.btnAzuriranje.Location = new System.Drawing.Point(139, 331);
            this.btnAzuriranje.Name = "btnAzuriranje";
            this.btnAzuriranje.Size = new System.Drawing.Size(165, 54);
            this.btnAzuriranje.TabIndex = 9;
            this.btnAzuriranje.Text = "Azuriraj podatke";
            this.btnAzuriranje.UseVisualStyleBackColor = true;
            // 
            // pnlIzmenaKorisnika
            // 
            this.pnlIzmenaKorisnika.Controls.Add(this.radioKorisnik);
            this.pnlIzmenaKorisnika.Controls.Add(this.radioAdmin);
            this.pnlIzmenaKorisnika.Controls.Add(this.label6);
            this.pnlIzmenaKorisnika.Controls.Add(this.label7);
            this.pnlIzmenaKorisnika.Controls.Add(this.txtNick);
            this.pnlIzmenaKorisnika.Controls.Add(this.label8);
            this.pnlIzmenaKorisnika.Controls.Add(this.txtPassword);
            this.pnlIzmenaKorisnika.Controls.Add(this.label9);
            this.pnlIzmenaKorisnika.Controls.Add(this.txtUsername);
            this.pnlIzmenaKorisnika.Location = new System.Drawing.Point(6, 104);
            this.pnlIzmenaKorisnika.Name = "pnlIzmenaKorisnika";
            this.pnlIzmenaKorisnika.Size = new System.Drawing.Size(421, 221);
            this.pnlIzmenaKorisnika.TabIndex = 10;
            // 
            // radioKorisnik
            // 
            this.radioKorisnik.AutoSize = true;
            this.radioKorisnik.Checked = true;
            this.radioKorisnik.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioKorisnik.Location = new System.Drawing.Point(277, 175);
            this.radioKorisnik.Name = "radioKorisnik";
            this.radioKorisnik.Size = new System.Drawing.Size(118, 20);
            this.radioKorisnik.TabIndex = 8;
            this.radioKorisnik.TabStop = true;
            this.radioKorisnik.Text = "Obican korisnik";
            this.radioKorisnik.UseVisualStyleBackColor = true;
            // 
            // radioAdmin
            // 
            this.radioAdmin.AutoSize = true;
            this.radioAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioAdmin.Location = new System.Drawing.Point(157, 175);
            this.radioAdmin.Name = "radioAdmin";
            this.radioAdmin.Size = new System.Drawing.Size(104, 20);
            this.radioAdmin.TabIndex = 4;
            this.radioAdmin.Text = "Administrator";
            this.radioAdmin.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(109, 175);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "Tip";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(64, 124);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 20);
            this.label7.TabIndex = 5;
            this.label7.Text = "Nadimak";
            // 
            // txtNick
            // 
            this.txtNick.Location = new System.Drawing.Point(157, 121);
            this.txtNick.Name = "txtNick";
            this.txtNick.Size = new System.Drawing.Size(227, 26);
            this.txtNick.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(71, 76);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 20);
            this.label8.TabIndex = 3;
            this.label8.Text = "Lozinka";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(157, 73);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(227, 26);
            this.txtPassword.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(18, 27);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(124, 20);
            this.label9.TabIndex = 1;
            this.label9.Text = "Korisnicko ime";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(157, 24);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(227, 26);
            this.txtUsername.TabIndex = 0;
            // 
            // radioObrisiKorisnika
            // 
            this.radioObrisiKorisnika.AutoSize = true;
            this.radioObrisiKorisnika.Location = new System.Drawing.Point(533, 27);
            this.radioObrisiKorisnika.Name = "radioObrisiKorisnika";
            this.radioObrisiKorisnika.Size = new System.Drawing.Size(92, 24);
            this.radioObrisiKorisnika.TabIndex = 2;
            this.radioObrisiKorisnika.Text = "Brisanje";
            this.radioObrisiKorisnika.UseVisualStyleBackColor = true;
            // 
            // radioIzmeniKorisnika
            // 
            this.radioIzmeniKorisnika.AutoSize = true;
            this.radioIzmeniKorisnika.Location = new System.Drawing.Point(300, 27);
            this.radioIzmeniKorisnika.Name = "radioIzmeniKorisnika";
            this.radioIzmeniKorisnika.Size = new System.Drawing.Size(166, 24);
            this.radioIzmeniKorisnika.TabIndex = 1;
            this.radioIzmeniKorisnika.Text = "Izmena podataka";
            this.radioIzmeniKorisnika.UseVisualStyleBackColor = true;
            // 
            // radioDodajKorisnika
            // 
            this.radioDodajKorisnika.AutoSize = true;
            this.radioDodajKorisnika.Checked = true;
            this.radioDodajKorisnika.Location = new System.Drawing.Point(118, 27);
            this.radioDodajKorisnika.Name = "radioDodajKorisnika";
            this.radioDodajKorisnika.Size = new System.Drawing.Size(112, 24);
            this.radioDodajKorisnika.TabIndex = 0;
            this.radioDodajKorisnika.TabStop = true;
            this.radioDodajKorisnika.Text = "Dodavanje";
            this.radioDodajKorisnika.UseVisualStyleBackColor = true;
            // 
            // tabGrupe
            // 
            this.tabGrupe.Controls.Add(this.pnlOdabirGrupe);
            this.tabGrupe.Controls.Add(this.pnlIzmenaGrupe);
            this.tabGrupe.Controls.Add(this.btnAzuriranjeGrupa);
            this.tabGrupe.Controls.Add(this.radioGrupaObrisi);
            this.tabGrupe.Controls.Add(this.radioGrupaIzmeni);
            this.tabGrupe.Controls.Add(this.radioGrupaDodaj);
            this.tabGrupe.Location = new System.Drawing.Point(4, 29);
            this.tabGrupe.Name = "tabGrupe";
            this.tabGrupe.Padding = new System.Windows.Forms.Padding(3);
            this.tabGrupe.Size = new System.Drawing.Size(785, 409);
            this.tabGrupe.TabIndex = 1;
            this.tabGrupe.Text = "Grupe";
            this.tabGrupe.UseVisualStyleBackColor = true;
            // 
            // pnlOdabirGrupe
            // 
            this.pnlOdabirGrupe.Controls.Add(this.label4);
            this.pnlOdabirGrupe.Controls.Add(this.lstGrupa);
            this.pnlOdabirGrupe.Location = new System.Drawing.Point(448, 58);
            this.pnlOdabirGrupe.Name = "pnlOdabirGrupe";
            this.pnlOdabirGrupe.Size = new System.Drawing.Size(334, 345);
            this.pnlOdabirGrupe.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(88, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "Odaberite grupu";
            // 
            // lstGrupa
            // 
            this.lstGrupa.FormattingEnabled = true;
            this.lstGrupa.ItemHeight = 20;
            this.lstGrupa.Location = new System.Drawing.Point(3, 38);
            this.lstGrupa.Name = "lstGrupa";
            this.lstGrupa.Size = new System.Drawing.Size(328, 304);
            this.lstGrupa.TabIndex = 10;
            this.lstGrupa.SelectedIndexChanged += new System.EventHandler(this.lstGrupa_SelectedIndexChanged);
            // 
            // pnlIzmenaGrupe
            // 
            this.pnlIzmenaGrupe.Controls.Add(this.label2);
            this.pnlIzmenaGrupe.Controls.Add(this.label5);
            this.pnlIzmenaGrupe.Controls.Add(this.txtMaxClanova);
            this.pnlIzmenaGrupe.Controls.Add(this.label11);
            this.pnlIzmenaGrupe.Controls.Add(this.txtNazivGrupe);
            this.pnlIzmenaGrupe.Location = new System.Drawing.Point(13, 58);
            this.pnlIzmenaGrupe.Name = "pnlIzmenaGrupe";
            this.pnlIzmenaGrupe.Size = new System.Drawing.Size(429, 143);
            this.pnlIzmenaGrupe.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(491, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Odaberite grupu";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(204, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Maksimalan broj članova";
            // 
            // txtMaxClanova
            // 
            this.txtMaxClanova.Location = new System.Drawing.Point(232, 91);
            this.txtMaxClanova.Name = "txtMaxClanova";
            this.txtMaxClanova.Size = new System.Drawing.Size(174, 26);
            this.txtMaxClanova.TabIndex = 2;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(121, 45);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(103, 20);
            this.label11.TabIndex = 1;
            this.label11.Text = "Naziv grupe";
            // 
            // txtNazivGrupe
            // 
            this.txtNazivGrupe.Location = new System.Drawing.Point(232, 42);
            this.txtNazivGrupe.Name = "txtNazivGrupe";
            this.txtNazivGrupe.Size = new System.Drawing.Size(174, 26);
            this.txtNazivGrupe.TabIndex = 0;
            // 
            // btnAzuriranjeGrupa
            // 
            this.btnAzuriranjeGrupa.Location = new System.Drawing.Point(254, 242);
            this.btnAzuriranjeGrupa.Name = "btnAzuriranjeGrupa";
            this.btnAzuriranjeGrupa.Size = new System.Drawing.Size(165, 54);
            this.btnAzuriranjeGrupa.TabIndex = 9;
            this.btnAzuriranjeGrupa.Text = "Azuriraj Grupe";
            this.btnAzuriranjeGrupa.UseVisualStyleBackColor = true;
            // 
            // radioGrupaObrisi
            // 
            this.radioGrupaObrisi.AutoSize = true;
            this.radioGrupaObrisi.Location = new System.Drawing.Point(540, 16);
            this.radioGrupaObrisi.Name = "radioGrupaObrisi";
            this.radioGrupaObrisi.Size = new System.Drawing.Size(92, 24);
            this.radioGrupaObrisi.TabIndex = 13;
            this.radioGrupaObrisi.Text = "Brisanje";
            this.radioGrupaObrisi.UseVisualStyleBackColor = true;
            // 
            // radioGrupaIzmeni
            // 
            this.radioGrupaIzmeni.AutoSize = true;
            this.radioGrupaIzmeni.Location = new System.Drawing.Point(307, 16);
            this.radioGrupaIzmeni.Name = "radioGrupaIzmeni";
            this.radioGrupaIzmeni.Size = new System.Drawing.Size(166, 24);
            this.radioGrupaIzmeni.TabIndex = 12;
            this.radioGrupaIzmeni.Text = "Izmena podataka";
            this.radioGrupaIzmeni.UseVisualStyleBackColor = true;
            // 
            // radioGrupaDodaj
            // 
            this.radioGrupaDodaj.AutoSize = true;
            this.radioGrupaDodaj.Checked = true;
            this.radioGrupaDodaj.Location = new System.Drawing.Point(125, 16);
            this.radioGrupaDodaj.Name = "radioGrupaDodaj";
            this.radioGrupaDodaj.Size = new System.Drawing.Size(112, 24);
            this.radioGrupaDodaj.TabIndex = 11;
            this.radioGrupaDodaj.TabStop = true;
            this.radioGrupaDodaj.Text = "Dodavanje";
            this.radioGrupaDodaj.UseVisualStyleBackColor = true;
            // 
            // tabDopisivanje
            // 
            this.tabDopisivanje.Controls.Add(this.lstPoruke);
            this.tabDopisivanje.Controls.Add(this.label3);
            this.tabDopisivanje.Controls.Add(this.label1);
            this.tabDopisivanje.Controls.Add(this.flowGrupe);
            this.tabDopisivanje.Controls.Add(this.btnPosalji);
            this.tabDopisivanje.Controls.Add(this.txtPoruka);
            this.tabDopisivanje.Location = new System.Drawing.Point(4, 29);
            this.tabDopisivanje.Name = "tabDopisivanje";
            this.tabDopisivanje.Size = new System.Drawing.Size(785, 409);
            this.tabDopisivanje.TabIndex = 2;
            this.tabDopisivanje.Text = "Dopisivanje";
            this.tabDopisivanje.UseVisualStyleBackColor = true;
            // 
            // lstPoruke
            // 
            this.lstPoruke.FormattingEnabled = true;
            this.lstPoruke.HorizontalScrollbar = true;
            this.lstPoruke.ItemHeight = 20;
            this.lstPoruke.Location = new System.Drawing.Point(16, 62);
            this.lstPoruke.Name = "lstPoruke";
            this.lstPoruke.Size = new System.Drawing.Size(462, 284);
            this.lstPoruke.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(173, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Poruke korisnika:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(500, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Grupe sa kojima se komunicira:";
            // 
            // flowGrupe
            // 
            this.flowGrupe.Location = new System.Drawing.Point(495, 62);
            this.flowGrupe.Name = "flowGrupe";
            this.flowGrupe.Size = new System.Drawing.Size(273, 331);
            this.flowGrupe.TabIndex = 3;
            // 
            // btnPosalji
            // 
            this.btnPosalji.Location = new System.Drawing.Point(346, 363);
            this.btnPosalji.Name = "btnPosalji";
            this.btnPosalji.Size = new System.Drawing.Size(132, 35);
            this.btnPosalji.TabIndex = 2;
            this.btnPosalji.Text = "Posalji";
            this.btnPosalji.UseVisualStyleBackColor = true;
            this.btnPosalji.Click += new System.EventHandler(this.btnPosalji_Click);
            // 
            // txtPoruka
            // 
            this.txtPoruka.Location = new System.Drawing.Point(16, 367);
            this.txtPoruka.Name = "txtPoruka";
            this.txtPoruka.Size = new System.Drawing.Size(315, 26);
            this.txtPoruka.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.odobravanjeZahtevaKorisnikaToolStripMenuItem,
            this.trenutnoSteUlogovaniKaoToolStripMenuItem,
            this.ručnoDodavanjeKorisnikaUGrupuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(817, 29);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // odobravanjeZahtevaKorisnikaToolStripMenuItem
            // 
            this.odobravanjeZahtevaKorisnikaToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.odobravanjeZahtevaKorisnikaToolStripMenuItem.Name = "odobravanjeZahtevaKorisnikaToolStripMenuItem";
            this.odobravanjeZahtevaKorisnikaToolStripMenuItem.Size = new System.Drawing.Size(236, 25);
            this.odobravanjeZahtevaKorisnikaToolStripMenuItem.Text = "Odobravanje zahteva korisnika";
            this.odobravanjeZahtevaKorisnikaToolStripMenuItem.Click += new System.EventHandler(this.odobravanjeZahtevaKorisnikaToolStripMenuItem_Click);
            // 
            // trenutnoSteUlogovaniKaoToolStripMenuItem
            // 
            this.trenutnoSteUlogovaniKaoToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.trenutnoSteUlogovaniKaoToolStripMenuItem.Name = "trenutnoSteUlogovaniKaoToolStripMenuItem";
            this.trenutnoSteUlogovaniKaoToolStripMenuItem.Size = new System.Drawing.Size(173, 25);
            this.trenutnoSteUlogovaniKaoToolStripMenuItem.Text = "Trenutno ste ulogovani kao...";
            // 
            // ručnoDodavanjeKorisnikaUGrupuToolStripMenuItem
            // 
            this.ručnoDodavanjeKorisnikaUGrupuToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ručnoDodavanjeKorisnikaUGrupuToolStripMenuItem.Name = "ručnoDodavanjeKorisnikaUGrupuToolStripMenuItem";
            this.ručnoDodavanjeKorisnikaUGrupuToolStripMenuItem.Size = new System.Drawing.Size(268, 25);
            this.ručnoDodavanjeKorisnikaUGrupuToolStripMenuItem.Text = "Ručno dodavanje korisnika u grupu";
            this.ručnoDodavanjeKorisnikaUGrupuToolStripMenuItem.Click += new System.EventHandler(this.ručnoDodavanjeKorisnikaUGrupuToolStripMenuItem_Click);
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
            this.btnOdjava.Location = new System.Drawing.Point(667, 32);
            this.btnOdjava.Name = "btnOdjava";
            this.btnOdjava.Size = new System.Drawing.Size(138, 33);
            this.btnOdjava.TabIndex = 2;
            this.btnOdjava.Text = "Odjavi se";
            this.btnOdjava.UseVisualStyleBackColor = true;
            this.btnOdjava.Click += new System.EventHandler(this.btnOdjava_Click);
            // 
            // FrmAdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 497);
            this.Controls.Add(this.btnOdjava);
            this.Controls.Add(this.tabOpcije);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmAdminPanel";
            this.Text = "FrmAdminPanel";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmAdminPanel_FormClosing);
            this.Load += new System.EventHandler(this.FrmAdminPanel_Load);
            this.tabOpcije.ResumeLayout(false);
            this.tabKorisnici.ResumeLayout(false);
            this.tabKorisnici.PerformLayout();
            this.pnlOdabirKorisnika.ResumeLayout(false);
            this.pnlOdabirKorisnika.PerformLayout();
            this.pnlIzmenaKorisnika.ResumeLayout(false);
            this.pnlIzmenaKorisnika.PerformLayout();
            this.tabGrupe.ResumeLayout(false);
            this.tabGrupe.PerformLayout();
            this.pnlOdabirGrupe.ResumeLayout(false);
            this.pnlOdabirGrupe.PerformLayout();
            this.pnlIzmenaGrupe.ResumeLayout(false);
            this.pnlIzmenaGrupe.PerformLayout();
            this.tabDopisivanje.ResumeLayout(false);
            this.tabDopisivanje.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabOpcije;
        private System.Windows.Forms.TabPage tabKorisnici;
        private System.Windows.Forms.TabPage tabGrupe;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.TabPage tabDopisivanje;
        private System.Windows.Forms.Button btnPosalji;
        private System.Windows.Forms.TextBox txtPoruka;
        private System.Windows.Forms.ToolStripMenuItem odobravanjeZahtevaKorisnikaToolStripMenuItem;
        private System.Windows.Forms.Panel pnlIzmenaKorisnika;
        private System.Windows.Forms.Button btnAzuriranje;
        private System.Windows.Forms.RadioButton radioKorisnik;
        private System.Windows.Forms.RadioButton radioAdmin;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNick;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.RadioButton radioObrisiKorisnika;
        private System.Windows.Forms.RadioButton radioIzmeniKorisnika;
        private System.Windows.Forms.RadioButton radioDodajKorisnika;
        private System.Windows.Forms.Panel pnlIzmenaGrupe;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lstGrupa;
        private System.Windows.Forms.Button btnAzuriranjeGrupa;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMaxClanova;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtNazivGrupe;
        private System.Windows.Forms.RadioButton radioGrupaObrisi;
        private System.Windows.Forms.RadioButton radioGrupaIzmeni;
        private System.Windows.Forms.RadioButton radioGrupaDodaj;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowGrupe;
        private System.Windows.Forms.ToolStripMenuItem trenutnoSteUlogovaniKaoToolStripMenuItem;
        private System.Windows.Forms.Panel pnlOdabirKorisnika;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ListBox lstKorisnici;
        private System.Windows.Forms.ListBox lstPoruke;
        private System.Windows.Forms.Panel pnlOdabirGrupe;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStripMenuItem ručnoDodavanjeKorisnikaUGrupuToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnOdjava;
    }
}