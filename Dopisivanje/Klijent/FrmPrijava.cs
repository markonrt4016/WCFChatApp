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
    public partial class FrmPrijava : Form
    {
        Service1Client servis;
        public FrmPrijava()
        {
            InitializeComponent();
            servis = new Service1Client();
            txtPassword.Text = "korisnik1";
            txtUsername.Text = "korisnik1";
        }

        private void btnPrijava_Click(object sender, EventArgs e)
        {
            Korisnik k = servis.UlogujKorisnika(txtUsername.Text, txtPassword.Text);
            if (k == null)
            {
                MessageBox.Show("Nema korisnika sa tim podacima!");
            }
            else if (k.Tip)
            {
                MessageBox.Show("Morate se ulogovati sa korisničkim nalogom!");
            }
            else
            {
                this.Hide();
                new FrmKlijent(k, this).Show();
            }
        }
    }
}
