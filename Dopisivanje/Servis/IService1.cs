using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.ServiceModel.Web;
using System.IO;

namespace Servis
{
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        [WebInvoke(UriTemplate = "nepoznatoPrimanje?idPosiljalac={idPosiljalac}&tekst={tekst}", Method = "GET")]
        void PrimiPoruku(int idPosiljalac, string tekst);

        [OperationContract]
        [WebInvoke(UriTemplate = "WebPrimiPoruku", Method = "POST", RequestFormat = WebMessageFormat.Json)]
        string WebPrimiPoruku(Stream podaci);

        [OperationContract]
        [WebInvoke(UriTemplate = "VratiPoruke?idKorisnika={idKorisnika}", Method = "GET", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        ListaPoruka VratiPoruke(int idKorisnika);

        [OperationContract]
        [WebInvoke(UriTemplate = "WebUlogujKorisnika", Method ="POST",RequestFormat = WebMessageFormat.Json, ResponseFormat =WebMessageFormat.Json)]
        Korisnik WebUlogujKorisnika(Stream podaci);

        [OperationContract]
        [WebInvoke(UriTemplate = "nepoznatoLogovanje?username={username}&password={password}", Method ="GET")]
        Korisnik UlogujKorisnika(string username, string password);

        [OperationContract]
        [WebInvoke(UriTemplate= "temp1?korisnicko_ime={korisnicko_ime}&lozinka={lozinka}&nadimak={nadimak}&tip={tip}", Method = "GET")]
        void DodajKorisnika(string korisnicko_ime, string lozinka, string nadimak, bool tip);

        [OperationContract]
        [WebInvoke(UriTemplate = "temp2?id={id}&korisnicko_ime={korisnicko_ime}&lozinka={lozinka}&nadimak={nadimak}&tip={tip}", Method = "GET")]
        void IzmeniKorisnika(int id, string korisnicko_ime, string lozinka, string nadimak, bool tip);

        [OperationContract]
        [WebInvoke(UriTemplate = "temp3?id={id}", Method = "POST")]
        void ObrisiKorisnika(int id);

        [OperationContract]
        [WebInvoke(UriTemplate = "temp4?naziv={naziv}&maxClanova={maxClanova}", Method = "GET")]
        void DodajGrupu(string naziv, int maxClanova);

        [OperationContract]
        [WebInvoke(UriTemplate = "temp5?id={id}&naziv={naziv}&maxClanova={maxClanova}", Method = "GET")]
        void IzmeniGrupu(int id, string naziv, int maxClanova);

        [OperationContract]
        [WebInvoke(UriTemplate = "temp6?id={id}", Method = "GET")]
        void ObrisiGrupu(int id);

        [OperationContract]
        [WebInvoke(UriTemplate ="VratiGrupe",Method ="GET",RequestFormat =WebMessageFormat.Json, ResponseFormat =WebMessageFormat.Json)]
        ListaGrupa VratiGrupe();

        [OperationContract]
        [WebInvoke(UriTemplate = "temp7?idKorisnika={idKorisnika}&idZeljeneGrupe={idZeljeneGrupe}", Method = "GET")]
        void PrimanjeZahtevaZaGrupu(int idKorisnika, int idZeljeneGrupe);

        [OperationContract]
        [WebInvoke(UriTemplate = "WebPrimanjeZahtevaZaGrupu", Method = "POST")]
        bool WebPrimanjeZahtevaZaGrupu(Stream podaci);

        [OperationContract]
        [WebInvoke(UriTemplate = "temp20", Method = "GET")]
        ListaGrupaKorisnika VratiZahteveZaGrupu();

        [OperationContract]
        [WebInvoke(UriTemplate = "temp8?idKorisnika={idKorisnika}&idZeljeneGrupe={idZeljeneGrupe}", Method = "GET")]
        bool OdobravanjeZahtevaZaGrupu(int idKorisnika, int idZeljeneGrupe);

        [OperationContract]
        [WebInvoke(UriTemplate = "temp9?idKorisnika={idKorisnika}&idGrupe={idGrupe}", Method = "GET")]
        bool RucnoDodavanjeKorisnikaUGrupu(int idKorisnika, int idGrupe);

        [OperationContract]
        [WebInvoke(UriTemplate = "temp10?idKorisnika={idKorisnika}&idGrupe={idGrupe}", Method = "GET")]
        void IzlazakIzGrupe(int idKorisnika, int idGrupe);

        [OperationContract]
        [WebInvoke(UriTemplate = "WebIzlazakIzGrupe", Method ="POST")]
        bool WebIzlazakIzGrupe(Stream podaci);

        [OperationContract]
        [WebInvoke(UriTemplate = "temp11", Method = "GET")]
        ListaKorisnika VratiKorisnike();

        [OperationContract]
        [WebInvoke(UriTemplate = "temp12?idKorisnik={idKorisnik}", Method = "GET")]
        ListaGrupa VratiGrupeUKojimaNije(int idKorisnik);

        [OperationContract]
        [WebInvoke(UriTemplate = "WebVratiGrupeUkojimaNije", Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        ListaGrupa WebVratiGrupeUKojimaNije(Stream podaci);

        [OperationContract]
        [WebInvoke(UriTemplate = "VratiGrupeUkojimaJeste", Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        ListaGrupa VratiGrupeUKojimaJeste(int idKorisnik);

        [OperationContract]
        [WebInvoke(UriTemplate = "WebVratiGrupeUkojimaJeste", Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        ListaGrupa WebVratiGrupeUKojimaJeste(Stream podaci);


    }
}
