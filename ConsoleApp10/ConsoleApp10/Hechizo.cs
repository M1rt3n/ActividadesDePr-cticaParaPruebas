using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    public class Hechizo
    {
        private string _encantamiento;
        public string Encantamiento
        { get { return _encantamiento; }
          set { _encantamiento = value; } 
        } 

        public Hechizo(string encantamiento)
        {
            Encantamiento = encantamiento;
        }
        public virtual string Lanzar()
        {
            return $"Has lanzado {Encantamiento} exitosamente";
        }
    }

    public class Bola_de_fuego : Hechizo
    {
        private int _temperaturac;
        public int TemperaturaC
        {
            get { return _temperaturac; }
            set { _temperaturac = value; }
        }
        public Bola_de_fuego(string encantamiento, int temperaturac) : base(encantamiento)
        {
            TemperaturaC = temperaturac;
        }
        public override string Lanzar()
        {
            return $"Has lanzado {Encantamiento} exitosamente, su temperatura fue de {TemperaturaC}";
        }
    }
    public class EscudoHielo : Hechizo
    {
        private int _grosorcapas;
        public int GrosorCapas
        {
            get { return _grosorcapas; }
            set { _grosorcapas = value; }
        }
        public EscudoHielo(string encantamiento, int grosorcapas) : base(encantamiento)
        {
            GrosorCapas = grosorcapas;
        }
        public override string Lanzar()
        {
            return $"Has lanzado {Encantamiento} exitosamente, su grosor es de {GrosorCapas}cm";
        }

    }

}