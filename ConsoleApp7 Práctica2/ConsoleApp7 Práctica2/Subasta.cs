using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7_Práctica2
{
    public class Subasta
    {
        private decimal _precioactual;
        public decimal PrecioActual
        {
            get { return _precioactual; }
            set { _precioactual = value; }
        }

        public Subasta(decimal precioactual)
        {
            PrecioActual = precioactual;
        }

        public virtual string RegistrarOferta(decimal Oferta)
        {
            if (Oferta > PrecioActual)
            {
                PrecioActual = Oferta;
                return $"El precio actual está en {PrecioActual}";
            }
            else
            {
                return $"La oferta no puede ser aceptada: debe ser mayor a {PrecioActual}";
            }
        }
    }

    public class SubastaRelámpago : Subasta
    {
        private int _tiemporestantesegundos;
        public int TiempoRestanteSegundos
        {
            get { return _tiemporestantesegundos; }
            set { _tiemporestantesegundos = value; }
        }
        public SubastaRelámpago(int precioactual, int tiemporestantesegundos) : base(precioactual)
        {
            TiempoRestanteSegundos = tiemporestantesegundos;
        }
        public override string RegistrarOferta(decimal Oferta)
        {
            if (Oferta > PrecioActual)
            {
                PrecioActual = Oferta;
                if (TiempoRestanteSegundos < 10)
                {
                    TiempoRestanteSegundos += 30;
                    return $"¡Oferta de último segundo! Tiempo extendido a {TiempoRestanteSegundos} segundos. El precio actual está en {PrecioActual}";
                }
                else
                {
                    if (TiempoRestanteSegundos < 0)
                    {
                        return $"La subasta ya ha concluido, no se pueden ingresar más ofertas";
                    }
                    else
                    {
                        TiempoRestanteSegundos += 5;
                        return $"Tiempo extendido a {TiempoRestanteSegundos} segundos. El precio actual está en {PrecioActual}";
                    }
                }
            }
            else
            {
                return $"La oferta no puede ser aceptada: debe ser mayor a {PrecioActual}";
            }
        }
    }
    public class SubastaPremium : Subasta
    {
        private decimal _montomínimoincremento;
        public decimal MontoMínimoIncremento
        {
            get { return _montomínimoincremento; }
            set { _montomínimoincremento = value; }
        }
        public SubastaPremium(int precioactual, int montomínimoincremento) : base(precioactual)
        {
            MontoMínimoIncremento = montomínimoincremento;
        }
        public override string RegistrarOferta(decimal Oferta)
        {
            if (Oferta > (PrecioActual + MontoMínimoIncremento))
            {
                PrecioActual = Oferta;
                return $"El precio actual está en {PrecioActual}";
            }
            else
            {
                return $"La oferta no puede ser aceptada: debe ser mayor a {PrecioActual + MontoMínimoIncremento}";

            }
        }
    }
}