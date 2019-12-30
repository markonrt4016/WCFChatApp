using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Klijent.ServiceReference1;

namespace Klijent
{
    public partial class FrmKlijent : Form
    {
        Service1Client servis;
        Korisnik k;
        Form roditelj;
        public FrmKlijent()
        {
            InitializeComponent();
            servis = new Service1Client();
            lstPoruke.DisplayMember = "IspisPoruke";
        }

        public FrmKlijent(Korisnik k, Form roditelj) : this()
        {
            this.k = k;
            this.roditelj = roditelj;
            menuStrip1.Items[2].Text = "Ulogovani ste kao: '" + k.KorisnickoIme + "', vaš nadimak: '" + k.Nadimak + "'";
        }

        private void posaljiZahtevZaPrikljucenjeNovojGrupiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmZahtevajPristup(k).ShowDialog();
        }

        private void FrmKlijent_Load(object sender, EventArgs e)
        {

        }

        private void FrmKlijent_FormClosing(object sender, FormClosingEventArgs e)
        {
            roditelj.Close();
        }

        private void btnPosalji_Click(object sender, EventArgs e)
        {
            if (servis.VratiGrupeUKojimaJeste(k.Id).Count != 0)
                servis.PrimiPoruku(k.Id, txtPoruka.Text);
            else
                MessageBox.Show("Ne komunicirate ni sa jednom grupom!");
        }

        public void AzurirajLstPoruke()
        {
            List<Poruka> poruke = servis.VratiPoruke(k.Id);
            if (lstPoruke.Items.Count != poruke.Count)
                lstPoruke.DataSource = poruke;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            AzurirajLstPoruke();
        }

        private void napustiGrupuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmNapustiGrupu(k).ShowDialog();
        }

        private void btnOdjava_Click(object sender, EventArgs e)
        {
            roditelj.Show();
            this.Hide();
        }
    }
}
