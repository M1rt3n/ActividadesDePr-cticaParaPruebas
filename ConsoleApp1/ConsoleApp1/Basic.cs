using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Basic
    {
        private string _name
        {
            get { return _name; }
            set
            {
                _name = value;
            }
        }
        public string Nombre
        {
            get { return _name; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("El nombre no puede estar vacío o ser nulo.");
                }
                _name = value;
            }
        }
        public virtual string Arrancar()
        {
            return $"Turno de {Nombre}.";
        }
    }

    public class Mago : Basic
    {
        public int Magia { get; set; }
        public Mago(string Nombre, int magia)
        {
            Magia = magia;
        }
        public override string Arrancar()
        {
            return $"[Turno de {Nombre}]. Hizo {Magia} puntos de daño mágico";
        }
    }
    public class Guerrero : Basic
    {
        public int Fuerza { get; set; }
        public Guerrero(string Nombre, int fuerza)
        {
            Fuerza = fuerza;
        }
        public override string Arrancar()
        {
            return $"[Turno de {Nombre}]. Hizo {Fuerza} puntos de daño físico";
        }
    }
}