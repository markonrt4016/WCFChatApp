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
    public partial class FrmGrupaKorisnikManuelno : Form
    {
        Service1Client servis;
        public FrmGrupaKorisnikManuelno()
        {
            InitializeComponent();
            servis = new Service1Client();
        }

        private void FrmGrupaKorisnikManuelno_Load(object sender, EventArgs e)
        {
            cmbKorisnik.DataSource = servis.VratiKorisnike().Where(x=>x.Tip==false).ToList<Korisnik>();
            cmbKorisnik.DisplayMember = "korisnickoIme";
            cmbKorisnik.ValueMember = "id";
            cmbKorisnik_SelectedIndexChanged(new object(), new EventArgs());
        }

        private void cmbKorisnik_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbKorisnik.SelectedValue is int)
            {
                cmbGrupa.DataSource = null;
                cmbGrupa.DataSource = servis.VratiGrupeUKojimaNije((int)cmbKorisnik.SelectedValue);
                cmbGrupa.DisplayMember = "naziv";
                cmbGrupa.ValueMember = "id";
            }
        }

        private void btnDodajKorisnikaGrupu_Click(object sender, EventArgs e)
        {
            if(cmbGrupa.SelectedValue is int)
            {
                int idKor = (int)cmbKorisnik.SelectedValue;
                servis.RucnoDodavanjeKorisnikaUGrupu(idKor, (int)cmbGrupa.SelectedValue);
                MessageBox.Show("Dodat korisnik u grupu!");
                cmbKorisnik.SelectedValue = -1;
                cmbKorisnik.SelectedValue = idKor;
            }
        }
    }
}
