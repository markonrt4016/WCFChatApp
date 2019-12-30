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
    public partial class FrmZahtevi : Form
    {
        Service1Client servis;
        public FrmZahtevi()
        {
            InitializeComponent();
            servis = new Service1Client();
        }

        private void FrmZahtevi_Load(object sender, EventArgs e)
        {
            AzuriranjeFlowZahteviGrupe();
        }

        public void AzuriranjeFlowZahteviGrupe()
        {
            flowZahteviGrupe.Controls.Clear();
            foreach (GrupaKorisnik gk in servis.VratiZahteveZaGrupu().ToList<GrupaKorisnik>())
            {
                CheckBox ck = new CheckBox();

                ck.Name = gk.IdKorisnika.ToString() + "," + gk.IdGrupe.ToString();
                ck.Text = servis.VratiKorisnike().Where(x => x.Id == gk.IdKorisnika).First().KorisnickoIme + " zahteva pridruzenje grupi " + servis.VratiGrupe().Where(x => x.Id == gk.IdGrupe).First().Naziv;
                ck.Width = flowZahteviGrupe.Width;
                ck.Font = new Font("Microsoft Sans Serif",10,FontStyle.Bold);
                flowZahteviGrupe.Controls.Add(ck);
            }
        }

        private void btnOdobri_Click(object sender, EventArgs e)
        {
            string neuspesniZahtevi = "";
            if(flowZahteviGrupe.Controls.Count == 0)
            {
                MessageBox.Show("Trenutno nema zahteva!");
            }
            else
            {
                bool odabrano = false;
                for (int i = 0; i < flowZahteviGrupe.Controls.Count; i++)
                {
                    if ((flowZahteviGrupe.Controls[i] as CheckBox).Checked)
                    {
                        string[] splitovano = (flowZahteviGrupe.Controls[i] as CheckBox).Name.Split(',');
                        if(servis.OdobravanjeZahtevaZaGrupu(int.Parse(splitovano[0]), int.Parse(splitovano[1])))
                        {
                            flowZahteviGrupe.Controls.RemoveAt(i--);
                            odabrano = true;
                        }
                        else
                        {
                            neuspesniZahtevi += Environment.NewLine + (flowZahteviGrupe.Controls[i] as CheckBox).Text;
                        }
                    }
                }

                if (odabrano && neuspesniZahtevi != "")
                    MessageBox.Show("Odobreni svi zahtevi, osim zahteva: " + neuspesniZahtevi);
                else if(odabrano)
                    MessageBox.Show("Odobreni izabrani zahtevi!");
                else if(neuspesniZahtevi != "")
                    MessageBox.Show("Nisu odobreni zahtevi zbog prekoračenja broja članova:" + neuspesniZahtevi);
                else
                    MessageBox.Show("Odaberite zahtev za odobrenje!");
            }
        }
    }
}
