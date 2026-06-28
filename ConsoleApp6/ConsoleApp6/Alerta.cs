using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    public class Alerta
    {
        public int Código { get; set; }

        public Alerta(int código)
        {
            Código = código;
        }
        public virtual string DispararProtocolo()
        {
            return $"La alarma {Código} se ha activado";
        }
    }

    public class IntrusionRed : Alerta
    {
        public string IpOrigen { get; set; }
        public IntrusionRed(int código, string iporigen) : base(código)
        {
            IpOrigen = iporigen;
        }
        public override string DispararProtocolo()
        {
            return $"La alarma {Código} se ha activado | Causante de la activacón de la alerta: {IpOrigen}";
        }
    }
    public class MalwareDetectado : Alerta
    {
        public string RutaArchivo { get; set; }
        public MalwareDetectado(int código, string rutaarchivo) : base(código)
        {
            RutaArchivo = rutaarchivo;
        }
        public override string DispararProtocolo()
        {
            return $"La alarma {Código} se ha activado | Ruta del archivo malicioso: {RutaArchivo}";
        }

    }
}
