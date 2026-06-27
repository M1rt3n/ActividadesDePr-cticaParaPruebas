using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public class Plato
    {
        public string NombrePlato { get; set; }

        public Plato(string nombreplato)
        {
            NombrePlato = nombreplato;
        }
        public virtual string Preparar()
        {
            return $"El plato {NombrePlato} se ha preparado exitosamente";
        }
    }

    public class Pizza : Plato
    {
        public string TipoMasa { get; set; }
        public Pizza(string nombreplato, string tipomasa) : base(nombreplato)
        {
            TipoMasa = tipomasa;
        }
        public override string Preparar()
        {
            return $"Tipo de masa para la pizza: {TipoMasa}, la pizza {NombrePlato} se ha preparado exitosamente";
        }
    }
    public class Ensalada : Plato
    {
        public string TipoAderezo { get; set; }
        public Ensalada(string nombreplato, string tipoaderezo) : base(nombreplato)
        {
            TipoAderezo = tipoaderezo;
        }
        public override string Preparar()
        {
            return $"Tipo de aderezo para la ensalada: {TipoAderezo}, la ensalada {NombrePlato} se ha preparado correctamente";
        }
    }
}
