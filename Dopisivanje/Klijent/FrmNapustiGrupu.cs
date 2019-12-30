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
    public partial class FrmNapustiGrupu : Form
    {
        Service1Client servis;
        Korisnik k;
        public FrmNapustiGrupu()
        {
            InitializeComponent();
            servis = new Service1Client();
            lstGrupe.DisplayMember = "Naziv";
            lstGrupe.ValueMember = "Id";
        }

        public FrmNapustiGrupu(Korisnik k) : this()
        {
            this.k = k;
        }

        private void FrmNapustiGrupu_Load(object sender, EventArgs e)
        {
            AzurirajLstGrupe();
        }

        public void AzurirajLstGrupe()
        {
            lstGrupe.DataSource = servis.VratiGrupeUKojimaJeste(k.Id);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(lstGrupe.SelectedValue is int)
            {
                servis.IzlazakIzGrupe(k.Id, (int)lstGrupe.SelectedValue);
                AzurirajLstGrupe();
                MessageBox.Show("Grupa napustena!");
            }
        }
    }
}
