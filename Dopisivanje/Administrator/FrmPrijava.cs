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
    public partial class FrmPrijava : Form
    {
        Service1Client servis;
        public FrmPrijava()
        {
            InitializeComponent();
            servis = new Service1Client();
            txtUsername.Text = "admin";
            txtPassword.Text = "admin";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Korisnik k = servis.UlogujKorisnika(txtUsername.Text, txtPassword.Text);
            if (k==null)
            {
                MessageBox.Show("Nema korisnika sa tim podacima!");
            }
            else if(!k.Tip)
            {
                MessageBox.Show("Morate se ulogovati sa administratorskim nalogom!");
            }
            else
            {
                this.Hide();
                new FrmAdminPanel(k, this).Show();
            }
        }
    }
}
