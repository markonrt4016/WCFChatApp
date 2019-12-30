using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Administrator.ServiceReference1;


namespace Administrator
{
    public partial class FrmAdminPanel : Form
    {
        Form roditelj;
        Korisnik admin;
        Service1Client servis;

        public FrmAdminPanel()
        {
            InitializeComponent();
            lstPoruke.DisplayMember = "ispisPoruke";
        }

        public FrmAdminPanel(Korisnik k, Form roditelj) : this()
        {
            this.roditelj = roditelj;
            admin = k;
            servis = new Service1Client();
        }

        private void FrmAdminPanel_FormClosing(object sender, FormClosingEventArgs e)
        {
            roditelj.Close();
        }

        private void FrmAdminPanel_Load(object sender, EventArgs e)
        {
            menuStrip1.Items[1].Text = "Ulogovani ste kao: '" + admin.KorisnickoIme + "', vaš nadimak: '" + admin.Nadimak + "'";
            AzurirajLstKorisnike();
            AzurirajLstGrupe();
            AzuriranjeFlowGrupe();

            radioDodajKorisnika.CheckedChanged += PromenaOpcijeKorisnik;
            radioIzmeniKorisnika.CheckedChanged += PromenaOpcijeKorisnik;
            radioObrisiKorisnika.CheckedChanged += PromenaOpcijeKorisnik;
            btnAzuriranje.Click += BtnAzuriranje_Click;

            radioGrupaDodaj.CheckedChanged += PromenaOpcijeGrupa;
            radioGrupaIzmeni.CheckedChanged += PromenaOpcijeGrupa;
            radioGrupaObrisi.CheckedChanged += PromenaOpcijeGrupa;
            btnAzuriranjeGrupa.Click += BtnAzuriranjeGrupa_Click;
            PromenaOpcijeGrupa(new object(), new EventArgs());
        }

        private void BtnAzuriranjeGrupa_Click(object sender, EventArgs e)
        {
            Grupa test = servis.VratiGrupe().Where(x => x.Naziv == txtNazivGrupe.Text).FirstOrDefault();
            if (radioGrupaDodaj.Checked)
            {
                //dodavanje
                if(test == null)
                {
                    if(!string.IsNullOrEmpty(txtNazivGrupe.Text) && !string.IsNullOrEmpty(txtMaxClanova.Text))
                    {
                        servis.DodajGrupu(txtNazivGrupe.Text, int.Parse(txtMaxClanova.Text));
                        MessageBox.Show("Grupa dodata!");
                        AzurirajLstGrupe();
                        AzuriranjeFlowGrupe();
                    }
                    else
                    {
                        MessageBox.Show("Morate popuniti polja!");
                    }
                    
                }
                else
                {
                    MessageBox.Show("Vec ima grupa sa ovim imenom!");
                }
            }
            else if (radioGrupaIzmeni.Checked && lstGrupa.SelectedItem != null)
            {
                if (!pnlIzmenaGrupe.Enabled || string.IsNullOrEmpty(txtNazivGrupe.Text) || string.IsNullOrEmpty(txtMaxClanova.Text))
                    MessageBox.Show("Kliknite na grupu koju želite da izmenite!");
                else
                {
                    servis.IzmeniGrupu((int)lstGrupa.SelectedValue,txtNazivGrupe.Text, int.Parse(txtMaxClanova.Text));
                    MessageBox.Show("Grupa izmenjena!");
                    AzurirajLstGrupe();
                }
            }
            else if(radioGrupaObrisi.Checked && lstGrupa.SelectedItem != null)
            {
                servis.ObrisiGrupu((int)lstGrupa.SelectedValue);
                MessageBox.Show("Grupa obrisana!");
                AzurirajLstGrupe();
                AzuriranjeFlowGrupe();
            }
        }

        private void PromenaOpcijeGrupa(object sender, EventArgs e)
        {
            lstGrupa.SelectedItem = null;
            if (radioGrupaDodaj.Checked)
            {
                pnlOdabirGrupe.Hide();
                pnlIzmenaGrupe.Enabled = true;
                btnAzuriranjeGrupa.Text = "Dodaj grupu";
            }
            else if (radioGrupaIzmeni.Checked)
            {
                pnlOdabirGrupe.Show();
                pnlIzmenaGrupe.Enabled = false;
                btnAzuriranjeGrupa.Text = "Izmeni grupu";
            }
            else if (radioGrupaObrisi.Checked)
            {
                pnlOdabirGrupe.Show();
                pnlIzmenaGrupe.Enabled = false;
                btnAzuriranjeGrupa.Text = "Obriši grupu";
            }
        }

        public void AzurirajLstGrupe()
        {
            lstGrupa.DataSource = null;
            lstGrupa.DataSource = servis.VratiGrupe();
            lstGrupa.ValueMember = "id";
            lstGrupa.DisplayMember = "naziv";
            txtNazivGrupe.Clear();
            txtMaxClanova.Clear();
        }

        public void AzurirajLstKorisnike()
        {
            lstKorisnici.DataSource = null;
            lstKorisnici.DataSource = servis.VratiKorisnike().Where(x=>x.Id != admin.Id).ToList<Korisnik>();
            lstKorisnici.ValueMember = "id";
            lstKorisnici.DisplayMember = "korisnickoIme";
            txtNick.Clear();
            txtUsername.Clear();
            txtPassword.Clear();
        }

        private void BtnAzuriranje_Click(object sender, EventArgs e)
        {
            bool daLiJeAdmin = radioAdmin.Checked ? true : false;
            if (radioDodajKorisnika.Checked)
            {
                //dodavanje
                Korisnik test = servis.VratiKorisnike().Where(x => x.KorisnickoIme == txtUsername.Text || x.Nadimak == txtNick.Text).FirstOrDefault();
                if (test == null)
                {
                    if (!string.IsNullOrEmpty(txtUsername.Text) && !string.IsNullOrEmpty(txtPassword.Text) && !string.IsNullOrEmpty(txtNick.Text))
                    {
                        servis.DodajKorisnika(txtUsername.Text, txtPassword.Text, txtNick.Text, daLiJeAdmin);
                        AzurirajLstKorisnike();
                        MessageBox.Show("Korisnik dodat!");
                    }
                    else
                        MessageBox.Show("Morate popuniti polja!");
              
                }
                else if (test.KorisnickoIme == txtUsername.Text)
                    MessageBox.Show("Korisnik sa datim korisnickim imenom već postoji!");
                else if (test.Nadimak == txtNick.Text)
                    MessageBox.Show("Korisnik sa datim nadimkom već postoji!");

            }
            else if (radioIzmeniKorisnika.Checked && lstKorisnici.SelectedItem != null)
            {
                if (!pnlIzmenaKorisnika.Enabled || string.IsNullOrEmpty(txtPassword.Text) || string.IsNullOrEmpty(txtNick.Text) || string.IsNullOrEmpty(txtUsername.Text))
                    MessageBox.Show("Kliknite na korisnika kog želite da izmenite!");
                else
                {
                    Korisnik test = servis.VratiKorisnike().Where(x => x.KorisnickoIme == txtUsername.Text || x.Nadimak == txtNick.Text).FirstOrDefault();
                    if (test == null)
                    {
                        servis.IzmeniKorisnika((int)lstKorisnici.SelectedValue, txtUsername.Text, txtPassword.Text, txtNick.Text, daLiJeAdmin);
                        AzurirajLstKorisnike();
                        MessageBox.Show("Korisnik izmenjen!");
                    }
                    else if (test.KorisnickoIme == txtUsername.Text)
                        MessageBox.Show("Korisnik sa datim korisnickim imenom već postoji!");
                    else if (test.Nadimak == txtNick.Text)
                        MessageBox.Show("Korisnik sa datim nadimkom već postoji!");
                }
            }
            else if (radioObrisiKorisnika.Checked && lstKorisnici.SelectedItem != null)
            {
                servis.ObrisiKorisnika((int)lstKorisnici.SelectedValue);
                AzurirajLstKorisnike();
                MessageBox.Show("Korisnik obrisan!");
            }
            else
            {
                MessageBox.Show("Morate odabrati korisnika!");
            }
            lstKorisnici.SelectedItem = null;
        }

        private void PromenaOpcijeKorisnik(object sender, EventArgs e)
        {
            lstKorisnici.SelectedItem = null;
            if (radioDodajKorisnika.Checked)
            {
                pnlOdabirKorisnika.Hide();
                pnlIzmenaKorisnika.Enabled = true;
                btnAzuriranje.Text = "Dodaj korisnika";
            }
            else if (radioIzmeniKorisnika.Checked)
            {
                pnlOdabirKorisnika.Show();
                pnlIzmenaKorisnika.Enabled = false;
                btnAzuriranje.Text = "Izmeni korisnika";
            }
            else if (radioObrisiKorisnika.Checked)
            {
                pnlOdabirKorisnika.Show();
                pnlIzmenaKorisnika.Enabled = false;
                btnAzuriranje.Text = "Obriši korisnika";
            }
        }

        private void lstKorisnici_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(!radioObrisiKorisnika.Checked)
                pnlIzmenaKorisnika.Enabled = true;
            if (lstKorisnici.SelectedValue is int)
            {
                Korisnik k = servis.VratiKorisnike().Where(x => x.Id == (int)lstKorisnici.SelectedValue).First();

                txtUsername.Text = k.KorisnickoIme;
                txtPassword.Text = k.Lozinka;
                txtNick.Text = k.Nadimak;
                if (k.Tip)
                    radioAdmin.Checked = true;
                else
                    radioKorisnik.Checked = true;
            }
        }

        public void AzurirajPoruke()
        {
            List<Poruka> poruke = servis.VratiPoruke(admin.Id).ToList<Poruka>();
            if (lstPoruke.Items.Count != poruke.Count)
            {
                lstPoruke.DataSource = null;
                lstPoruke.DisplayMember = "ispisPoruke";
                lstPoruke.DataSource = poruke;
            }    
        }

        private void btnPosalji_Click(object sender, EventArgs e)
        {
            servis.PrimiPoruku(admin.Id, txtPoruka.Text);
            if (servis.VratiPoruke(admin.Id).Count > 0)
            {
                AzurirajPoruke();
            }
            else
                MessageBox.Show("Ne komunicirate ni sa jednom grupom!");
        }

        private void lstGrupa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!radioGrupaObrisi.Checked)
                pnlIzmenaGrupe.Enabled = true;
            if (lstGrupa.SelectedValue is int)
            {
                Grupa g = servis.VratiGrupe().Where(x=>x.Id == (int)lstGrupa.SelectedValue).First();

                txtNazivGrupe.Text = g.Naziv;
                txtMaxClanova.Text = g.MaxClanova.ToString();
            }
        }

        private void ručnoDodavanjeKorisnikaUGrupuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmGrupaKorisnikManuelno().ShowDialog();
        }

        public void AzuriranjeFlowGrupe()
        {
            flowGrupe.Controls.Clear();
            foreach (Grupa g in servis.VratiGrupe())
            {
                CheckBox ck = new CheckBox();
                ck.Name = g.Id.ToString();
                ck.Text = g.Naziv;
                flowGrupe.Controls.Add(ck);
                ck.CheckedChanged += Ck_CheckedChanged;
                if (servis.VratiGrupeUKojimaNije(admin.Id).Where(x => x.Id == g.Id).Count() == 0)
                    ck.Checked = true;
            }
        }

        private void Ck_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox ck = (sender as CheckBox);
            if (ck.Checked)
                servis.RucnoDodavanjeKorisnikaUGrupu(admin.Id, int.Parse(ck.Name));
            else
            {
                servis.IzlazakIzGrupe(admin.Id, int.Parse(ck.Name));
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            AzurirajPoruke();
        }

        private void odobravanjeZahtevaKorisnikaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmZahtevi().ShowDialog();
        }

        private void btnOdjava_Click(object sender, EventArgs e)
        {
            roditelj.Show();
            this.Hide();
        }
    }
}
