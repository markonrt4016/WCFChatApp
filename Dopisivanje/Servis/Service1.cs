using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Web;

namespace Servis
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single, ConcurrencyMode = ConcurrencyMode.Multiple)]
    public class Service1 : IService1
    {
        static ListaKorisnika korisnici = new ListaKorisnika {
            new Korisnik("admin", "admin", "admin123", true),
            new Korisnik("korisnik1", "korisnik1", "kor1", false),
            new Korisnik("korisnik2", "korisnik2", "kor2", false),
            new Korisnik("korisnik3", "korisnik3", "kor3", false),
            new Korisnik("korisnik4BezGrupe", "k4", "k4", false),
            new Korisnik("korisnik5BezGrupe", "k5", "k5", false)
        };

        
        static ListaGrupa grupe = new ListaGrupa {
            new Grupa(2, "glavna"),
            new Grupa(20, "sporedna")
        };

        static ListaGrupaKorisnika grupeKorisnika = new ListaGrupaKorisnika {
            new GrupaKorisnik(grupe[0].Id, korisnici[0].Id),
            new GrupaKorisnik(grupe[0].Id, korisnici[1].Id),
            new GrupaKorisnik(grupe[1].Id, korisnici[2].Id),
            new GrupaKorisnik(grupe[1].Id, korisnici[3].Id)
        };

        static ListaPoruka poruke = new ListaPoruka();

        //static ListaGrupaKorisnika zahtevi = new ListaGrupaKorisnika();

        static ListaGrupaKorisnika zahtevi = new ListaGrupaKorisnika
        {
            new GrupaKorisnik(0, 4),
            new GrupaKorisnik(1,5)
        };


        public Korisnik UlogujKorisnika(string username, string password)
        {
            return korisnici.Where(x => x.KorisnickoIme == username && x.Lozinka == password).FirstOrDefault();
        }

        public void DodajKorisnika(string korisnicko_ime,string lozinka,string nadimak, bool tip)
        {
            korisnici.Add(new Korisnik(korisnicko_ime,lozinka,nadimak,tip));
        }

        public void IzmeniKorisnika(int id, string korisnicko_ime, string lozinka, string nadimak, bool tip)
        {
            for(int i = 0; i < korisnici.Count; i++)
                if(korisnici[i].Id == id)
                {
                    korisnici[i].KorisnickoIme = korisnicko_ime;
                    korisnici[i].Lozinka = lozinka;
                    korisnici[i].Nadimak = nadimak;
                    korisnici[i].Tip = tip;
                    break;
                }
        }

        public void ObrisiKorisnika(int id)
        {
            korisnici.Remove(korisnici.Where(x=>x.Id == id).First());
        }

        public void DodajGrupu(string naziv, int maxClanova)
        {
            grupe.Add(new Grupa(maxClanova, naziv));
        }

        public void IzmeniGrupu(int id, string naziv, int maxClanova)
        {
            for (int i = 0; i < grupe.Count; i++)
                if (grupe[i].Id == id)
                {
                    grupe[i].Naziv = naziv;
                    grupe[i].MaxClanova = maxClanova;
                    break;
                }
        }

        public void ObrisiGrupu(int id)
        {
            grupe.Remove(grupe.Where(x => x.Id == id).First());
            grupeKorisnika.RemoveAll(x=>x.IdGrupe == id);
        }


        public ListaGrupa VratiGrupe()
        {
            return grupe;
        }

        public ListaGrupa VratiGrupeUKojimaNije(int idKorisnik)
        {
            List<int> idGrupaUkojimaJeste = grupeKorisnika.Where(x => x.IdKorisnika == idKorisnik).Select(x => x.IdGrupe).ToList<int>();

            // ne radi iz nekog razloga ListaGrupa rez2 = grupe.Where(g => !idGrupaUkojimaJeste.Contains(g.Id)) as ListaGrupa;

            ListaGrupa rez = new ListaGrupa();
            foreach(Grupa g in grupe)
                if (!idGrupaUkojimaJeste.Contains(g.Id))
                    rez.Add(g);
          
            return rez;
        }

        public ListaGrupa VratiGrupeUKojimaJeste(int idKorisnik)
        {
            List<int> idGrupaUkojimaJeste = grupeKorisnika.Where(x => x.IdKorisnika == idKorisnik).Select(x => x.IdGrupe).ToList<int>();
            ListaGrupa rez = new ListaGrupa();

            foreach (Grupa g in grupe)
                if (idGrupaUkojimaJeste.Contains(g.Id))
                    rez.Add(g);

            return rez;
        }


        public ListaGrupaKorisnika VratiZahteveZaGrupu()
        {
            return zahtevi;
        }

        public void PrimanjeZahtevaZaGrupu(int idKorisnika, int idZeljeneGrupe)
        {
            zahtevi.Add(new GrupaKorisnik(idZeljeneGrupe, idKorisnika));
        }

        public bool OdobravanjeZahtevaZaGrupu(int idKorisnika, int idZeljeneGrupe)
        {
            if (grupe.Where(x => x.Id == idZeljeneGrupe).First().MaxClanova >= grupeKorisnika.Where(x => x.IdGrupe == idZeljeneGrupe).Count())
            {
                grupeKorisnika.Add(zahtevi.Where(x => x.IdGrupe == idZeljeneGrupe && x.IdKorisnika == idKorisnika).First());
                zahtevi.Remove(zahtevi.Where(x => x.IdGrupe == idZeljeneGrupe && x.IdKorisnika == idKorisnika).First());
                return true;
            }
            else
                return false;
        }

        public bool RucnoDodavanjeKorisnikaUGrupu(int idKorisnika, int idGrupe)
        {
            if(grupeKorisnika.Where(x=>x.IdGrupe == idGrupe && x.IdKorisnika == idKorisnika).FirstOrDefault() == null)
            {
                grupeKorisnika.Add(new GrupaKorisnik(idGrupe, idKorisnika));
                for(int i = 0; i < zahtevi.Count; i++)
                {
                    if(zahtevi[i].IdGrupe == idGrupe && zahtevi[i].IdKorisnika == idKorisnika)
                    {
                        zahtevi.RemoveAt(i);
                        break;
                    }
                }
                return true;
            }
            else
                return false;
        }

        public void IzlazakIzGrupe(int idKorisnika, int idGrupe)
        {
            grupeKorisnika.Remove(grupeKorisnika.Where(x => x.IdKorisnika == idKorisnika && x.IdGrupe == idGrupe).First());
        }

        public ListaKorisnika VratiKorisnike()
        {
            return korisnici;
        }

        //servis prima
        public void PrimiPoruku(int idPosiljalac, string tekst)
        {
            List<GrupaKorisnik> grupeUkojimaJePOSILJALAC = grupeKorisnika.Where(x => x.IdKorisnika == idPosiljalac).ToList<GrupaKorisnik>();

            foreach(GrupaKorisnik gk in grupeUkojimaJePOSILJALAC)
            {
                Poruka novaPoruka = new Poruka();
                novaPoruka.IdPosiljalac = idPosiljalac;
                novaPoruka.Tekst = tekst;
                novaPoruka.Vreme = DateTime.Now;
                novaPoruka.IdPrimalac = gk.IdGrupe; //id primaoca je id grupe u kojoj se nalazi

                poruke.Add(novaPoruka);
            }
        }
        //servis vraca kad mu se obrati korisnik
        public ListaPoruka VratiPoruke(int idKorisnika)
        {
            List<GrupaKorisnik> grupeUkojimaJePrimalac = grupeKorisnika.Where(x => x.IdKorisnika == idKorisnika).ToList<GrupaKorisnik>();
            ListaPoruka porukeZaKorisnika = new ListaPoruka();

        
            if (grupeUkojimaJePrimalac.Count > 0)
                porukeZaKorisnika.AddRange(poruke.Where(x => grupeUkojimaJePrimalac.Select(y=>y.IdGrupe).Contains(x.IdPrimalac)).Distinct(new Poruka.UporediPoruke()));

            for (int i = 0; i < porukeZaKorisnika.Count; i++)
                porukeZaKorisnika[i].IspisPoruke = porukeZaKorisnika[i].Vreme.ToShortTimeString() + "-" + korisnici.Where(x => x.Id == porukeZaKorisnika[i].IdPosiljalac).First().Nadimak + ": " + porukeZaKorisnika[i].Tekst;

            return porukeZaKorisnika;
        }




        //WEB METODE:

        public ListaGrupa WebVratiGrupeUKojimaJeste(Stream podaci)
        {
            StreamReader str = new StreamReader(podaci);
            NameValueCollection nvc = HttpUtility.ParseQueryString(str.ReadToEnd());
            int id = int.Parse(nvc["id"]);

            return VratiGrupeUKojimaJeste(id);
        }

        public ListaGrupa WebVratiGrupeUKojimaNije(Stream podaci)
        {
            StreamReader str = new StreamReader(podaci);
            NameValueCollection nvc = HttpUtility.ParseQueryString(str.ReadToEnd());
            int id = int.Parse(nvc["id"]);

            ListaGrupa g = VratiGrupeUKojimaNije(id);
            foreach (GrupaKorisnik gk in zahtevi.Where(x => x.IdKorisnika == id))
                for(int i=0; i< g.Count; i++)
                    if (g[i].Id == gk.IdGrupe)
                        g.RemoveAt(i--);
      
            return g;
        }

        public Korisnik WebUlogujKorisnika(Stream podaci)
        {
            StreamReader str = new StreamReader(podaci);
            NameValueCollection nvc = HttpUtility.ParseQueryString(str.ReadToEnd());
            string username = nvc["username"].ToString();
            string password = nvc["password"].ToString();
            return UlogujKorisnika(username, password);
        }

        public string WebPrimiPoruku(Stream podaci)
        {
            StreamReader str = new StreamReader(podaci);
            NameValueCollection nvc = HttpUtility.ParseQueryString(str.ReadToEnd());
            int IdPosiljalac = int.Parse(nvc["IdPosiljalac"]);
            string Tekst = nvc["Tekst"].ToString();
            PrimiPoruku(IdPosiljalac, Tekst);
            return "ok";
        }

        public bool WebPrimanjeZahtevaZaGrupu(Stream podaci)
        {
            StreamReader str = new StreamReader(podaci);
            NameValueCollection nvc = HttpUtility.ParseQueryString(str.ReadToEnd());
            int idKorisnika = int.Parse(nvc["idKorisnika"]);
            int idGrupe = int.Parse(nvc["idGrupe"]);
            PrimanjeZahtevaZaGrupu(idKorisnika, idGrupe);
            return true;
        }

        public bool WebIzlazakIzGrupe(Stream podaci)
        {
            StreamReader str = new StreamReader(podaci);
            NameValueCollection nvc = HttpUtility.ParseQueryString(str.ReadToEnd());
            int idKorisnika = int.Parse(nvc["idKorisnika"]);
            int idGrupe = int.Parse(nvc["idGrupe"]);
            IzlazakIzGrupe(idKorisnika, idGrupe);
            return true;
        }

    }

    [CollectionDataContract]
    public class ListaPoruka : List<Poruka>{}
    [CollectionDataContract]
    public class ListaGrupa : List<Grupa> { }
    [CollectionDataContract]
    public class ListaGrupaKorisnika : List<GrupaKorisnik> { }
    [CollectionDataContract]
    public class ListaKorisnika : List<Korisnik> { }


    //Korisnik(id_korisnika, korisnicko_ime, lozinka, nadimak, tip)
    //Poruke(id_poruke, id_posiljalac, id_primalac, tekst, vreme)
    //Grupa(id_grupa, naziv, max_broj_clanova)
    //GrupaKorisnici(id_grupa, id_korisnik)
    [DataContract]
    public class Korisnik
    {
        int id;
        string korisnickoIme, lozinka, nadimak;
        bool tip; //false = obican korisnik
        static int brKorisnika = 0;

        public Korisnik(string korisnickoIme, string lozinka, string nadimak, bool tip)
        {
            this.id = brKorisnika++;
            this.korisnickoIme = korisnickoIme;
            this.lozinka = lozinka;
            this.nadimak = nadimak;
            this.tip = tip;
        }

        [DataMember]
        public int Id { get => id; set => id = value; }
        [DataMember]
        public string KorisnickoIme { get => korisnickoIme; set => korisnickoIme = value; }
        [DataMember]
        public string Lozinka { get => lozinka; set => lozinka = value; }
        [DataMember]
        public string Nadimak { get => nadimak; set => nadimak = value; }
        [DataMember]
        public bool Tip { get => tip; set => tip = value; }
    }
    [DataContract]
    public class Poruka
    {
        int idPoruka, idPosiljalac;
        int idPrimalac;
        string tekst;
        DateTime vreme;
        string ispisPoruke;
        static int brPoruka = 0;

        public Poruka() { idPoruka = brPoruka++; }

        [DataMember]
        public int IdPoruka { get => idPoruka; set => idPoruka = value; }
        [DataMember]
        public int IdPosiljalac { get => idPosiljalac; set => idPosiljalac = value; }
        [DataMember]
        public int IdPrimalac { get => idPrimalac; set => idPrimalac = value; }
        [DataMember]
        public string Tekst { get => tekst; set => tekst = value; }
        [DataMember]
        public DateTime Vreme { get => vreme; set => vreme = value; }
        [DataMember]
        public string IspisPoruke { get => ispisPoruke; set => ispisPoruke = value; }


        public class UporediPoruke : IEqualityComparer<Poruka>
        {
            public UporediPoruke()
            {

            }

            public bool Equals(Poruka x, Poruka y)
            {
                if (x.Tekst == y.Tekst && x.Vreme.ToString("F") == y.Vreme.ToString("F") && x.IdPosiljalac == y.IdPosiljalac)
                    return true;
                else
                    return false;
            }

            public int GetHashCode(Poruka obj)
            {
                string test = obj.Vreme.ToString("F");
                int hash = obj.Tekst.GetHashCode();
                return hash;
            }
        }


    }
    [DataContract]
    public class Grupa
    {
        int id, maxClanova;
        string naziv;
        static int brGrupa = 0;

        public Grupa() { id = brGrupa++; }

        public Grupa(int maxClanova, string naziv)
        {
            id = brGrupa++;
            this.maxClanova = maxClanova;
            this.naziv = naziv;
        }

        [DataMember]
        public int Id { get => id; set => id = value; }
        [DataMember]
        public int MaxClanova { get => maxClanova; set => maxClanova = value; }
        [DataMember]
        public string Naziv { get => naziv; set => naziv = value; }
    }
    [DataContract]
    public class GrupaKorisnik
    {
        int idGrupe, idKorisnika;

        public GrupaKorisnik(int idGrupe, int idKorisnika)
        {
            this.idGrupe = idGrupe;
            this.idKorisnika = idKorisnika;
        }

        [DataMember]
        public int IdGrupe { get => idGrupe; set => idGrupe = value; }
        [DataMember]
        public int IdKorisnika { get => idKorisnika; set => idKorisnika = value; }
    }



}
