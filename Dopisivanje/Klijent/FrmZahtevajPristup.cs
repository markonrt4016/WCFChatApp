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
    public partial class FrmZahtevajPristup : Form
    {
        Service1Client servis;
        Korisnik k;
        public FrmZahtevajPristup()
        {
            InitializeComponent();
            servis = new Service1Client();
        }

        public FrmZahtevajPristup(Korisnik k) : this()
        {
            this.k = k;
        }

        private void FrmZahtevajPristup_Load(object sender, EventArgs e)
        {
            AzuriranjeFlowGrupe();
            lstZahtevi.DisplayMember = "Naziv";
        }

        public void AzuriranjeFlowGrupe()
        {
            flowZahtevaneGrupe.Controls.Clear();
            List<Grupa> grupeUkojimaNije = servis.VratiGrupeUKojimaNije(k.Id);
            foreach (Grupa g in servis.VratiGrupe())
            {
                CheckBox ck = new CheckBox();
                ck.Name = g.Id.ToString();
                ck.Text = g.Naziv;
                ck.Width = flowZahtevaneGrupe.Width;
                ck.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Bold);
                flowZahtevaneGrupe.Controls.Add(ck);
                if (grupeUkojimaNije.Where(x=>x.Id == g.Id).Count()==0)
                {
                    ck.Enabled = false;
                    ck.Checked = true;
                }
            }
        }

        private void btnPosaljiZahtev_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < flowZahtevaneGrupe.Controls.Count; i++)
            {
                if(flowZahtevaneGrupe.Controls[i].Enabled && (flowZahtevaneGrupe.Controls[i] as CheckBox).Checked)
                {
                    servis.PrimanjeZahtevaZaGrupu(k.Id, int.Parse(flowZahtevaneGrupe.Controls[i].Name));
                    flowZahtevaneGrupe.Controls.RemoveAt(i--);
                }
            }

            lstZahtevi.DataSource = servis.VratiGrupe().Where(x => servis.VratiZahteveZaGrupu().Where(n => n.IdKorisnika == k.Id).Select(y => y.IdGrupe).Contains(x.Id)).ToList<Grupa>(); ;

        }
    }
}
