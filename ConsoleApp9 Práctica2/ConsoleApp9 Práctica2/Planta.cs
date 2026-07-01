using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9_Práctica2
{
    public class Planta
    {
        private int _edaddias;
        public int EdadDias
        {
            get { return _edaddias; }
            set { _edaddias = value; }
        }
        private int _salud;
        public int Salud
        {
            get { return _salud; }
            set { _salud = value; }
        }

        public Planta(int edaddias, int salud)
        {
            EdadDias = edaddias;
            Salud = salud;
        }

        public virtual string AplicarClima(string Clima)
        {
            return $"Hoy es un dia {Clima}, el cactus está en su habitat óptimo | Salud: {Salud}%";
        }
    }

    public class Cactus : Planta
    {
        public Cactus(int edaddias, int salud) : base(edaddias, salud)
        {
        }
        public override string AplicarClima(string Clima)
        {
            {
                if (Salud > 100)
                {
                    Salud = 100;
                }
                else
                {
                    if (Salud < 0)
                    {
                        Salud = 0;
                    }
                }
                if (Clima == "Lluvioso")
                {
                    Salud -= 10;
                    return $"Hoy es un dia {Clima}, el cactus está ahogandose | Salud: {Salud}%";
                }
                else
                {
                    if (Clima == "Desértico")
                    {
                        Salud += 10;
                        return $"Hoy es un dia {Clima}, el cactus está en su habitat óptimo | Salud: {Salud}%";
                    }
                    else
                    {
                        return $"Hoy es un dia {Clima}, el cactus está bien | Salud: {Salud}%";
                    }
                }
            }
        }
    }
    public class Helecho : Planta
    {
        private bool _humedadrequerida;
        public bool HumedadRequerida
        {
            get { return _humedadrequerida; }
            set { _humedadrequerida = value; }
        }
        public Helecho(int edaddias, int salud, bool humedadrequerida) : base(edaddias, salud)
        {
            HumedadRequerida = humedadrequerida;
        }
        public override string AplicarClima(string Clima)
        {
            if (Salud > 100)
            {
                Salud = 100;
            }
            else
            {
                if (Salud < 0)
                {
                    Salud = 0;
                }
            }
            if (Clima == "Seco" && HumedadRequerida == true)
            {
                Salud -= 20;
                return $"Hoy es un dia {Clima}, el helecho se está secando | Salud: {Salud}% | Riesgo: Necesita regarse urgentemente";
            }
            else
            {
                if (Clima == "Seco" && !HumedadRequerida)
                {
                    Salud += 5;
                    return $"Hoy es un dia {Clima}, el helecho increiblemente está bien | Salud: {Salud}% | Riesgo: Ninguno";
                }
                else
                {
                    return $"Hoy es un dia {Clima}, el helecho está bien | Salud: {Salud}% | Riesgo: Ninguno";

                }
            }
        }
    }

}
