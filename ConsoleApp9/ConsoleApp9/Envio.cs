using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    public class Envio
    {
        private string _dirección;
        public string Dirección
        {
            get { return _dirección; }
            set { _dirección = value; }
        }

        public Envio(string dirección)
        {
            Dirección = dirección;
        }
        public virtual string ProcesarEntrega()
        {
            return $"El envio con destino a {Dirección} ha sucedido exitosamente";
        }
    }

    public class EnvioExpess : Envio
    {
        private int _tiempolímitehoras;
        public int TiempoLímiteHoras
        {
            get { return _tiempolímitehoras; }
            set { _tiempolímitehoras = value; }
        }
        public EnvioExpess(string dirección, int tiempolímitehoras) : base(dirección)
        {
            TiempoLímiteHoras = tiempolímitehoras;
        }
        public override string ProcesarEntrega()
        {
            return $"El envio con destino a {Dirección} ha sucedido exitosamente dentro del límite de horas acordado: {TiempoLímiteHoras}hs";
        }
    }
    public class EnvioFrágil : Envio
    {
        private string _materialprotección;
        public string MaterialProtección
        {
            get { return _materialprotección; }
            set { _materialprotección = value; }
        }
        public EnvioFrágil(string dirección, string materialprotección) : base(dirección)
        {
            MaterialProtección = materialprotección;
        }
        public override string ProcesarEntrega()
        {
            return $"El envio con destino a {Dirección} ha sucedido exitosamente sin daños por el material protectivo: {MaterialProtección}";
        }

    }
}
