using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Documentos
{
    public class DatosCartaPorte
    {   
        public string numero { get; set; }
        public string codigo { get; set; }
        public string nomDirRemitente { get; set; }
        public string nomDirDestinatario { get; set; }
        public string nomDirConsignatario { get; set; }
        public string notificar { get; set; }
        public string lugarRecibe { get; set; }
        public string lugarEmbarque { get; set; }
        public string lugarEntrega { get; set; }
        public string Condiciones { get; set; }
        public string CantidadBultos { get; set; }
        public string MarcasBultos { get; set; }
        public string DescripcionMercancia { get; set; }
        public string PesoNeto { get; set; }
        public string PesoBruto { get; set; }
        public string VolumenMetros { get; set; }
        public string OtrasUnidades { get; set; }
        public string PrecioMercancias { get; set; }
        public string GastosValorFlete { get; set; }
        public string GastosMonedaFlete { get; set; }
        public string GastosCargoDestinatarioFlete { get; set; }
        public string GastosMonedaCargoDestinatarioFlete { get; set; }
        public string GastosValorSeguro { get; set; }
        public string GastosMonedaSeguro { get; set; }
        public string GastosCargoDestinatarioSeguro { get; set; }
        public string GastosMonedaCargoDestinatarioSeguro { get; set; }
        public string GastosValorOtros { get; set; }
        public string GastosMonedaOtros { get; set; }
        public string GastosCargoDestinatarioOtros { get; set; }
        public string GastosMonedaCargoDestinatarioOtros { get; set; }
        public string DocumentosRecibidos { get; set; }
        public string LugarEmision { get; set; }
        public string InstruccionesTransportista { get; set; }
        public string ObservacionesTransportista { get; set; }        
        public string SumaRemitente { get; set; }
        public string SumaDestinatario { get; set; }
        public string Dian { get; set; }
    }
}
