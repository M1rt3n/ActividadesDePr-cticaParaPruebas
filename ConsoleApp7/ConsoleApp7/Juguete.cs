using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    public class Juguete
    {
        public int NúmeroSerie { get; set; }

        public Juguete(int númeroserie)
        {
            NúmeroSerie = númeroserie;
        }
        public virtual string ProbarJuguete()
        {
            return $"El juguete está siendo probado... Prueba completada";
        }
    }

    public class Muñeca : Juguete
    {
        public string MaterialCabello { get; set; }
        public Muñeca(int númeroserie, string materialcabello) : base(númeroserie)
        {
            MaterialCabello = materialcabello;
        }
        public override string ProbarJuguete()
        {
            return $"La muñeca está siendo probada | Tipo de cabello de la muñeca: {MaterialCabello}... Prueba completada";
        }
    }
    public class AutoControl : Juguete
    {
        public int Frecuencia { get; set; }
        public AutoControl(int númeroserie, int frecuencia) : base(númeroserie)
        {
            Frecuencia = frecuencia;
        }
        public override string ProbarJuguete()
        {
            return $"El autocontrol está siendo probado | Frecuencia del autocontrol: {Frecuencia}hz... Prueba completada";
        }
    }
}
