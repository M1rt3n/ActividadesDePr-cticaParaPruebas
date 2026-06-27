using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class Dispositivo
    {
        public string HabitaciónValidada { get; set; }
        public string NotaActual { get; set; }

        public Dispositivo(string habitaciónmodelada)
        {
            HabitaciónValidada = habitaciónmodelada;
        }
        public virtual string EjecutarFunción()
        {
            return $"Dispositivo activado";
        }
    }

    public class AspiradoraRobot : Dispositivo
    {
        public int CapacidadTanque { get; set; }
        public AspiradoraRobot(string habitaciónvalidada, int capacidadtanque) : base(habitaciónvalidada)
        {
            CapacidadTanque = capacidadtanque;
        }
        public override string EjecutarFunción()
        {
                return $"Limpiando habitación {HabitaciónValidada}... Tanque al 100%: {CapacidadTanque} gramos de polvo recolectados, por favor vaciar antes de volver a activar";
        }
    }
    public class LamparaInteligente : Dispositivo
    {
        public string ColorLed { get; set; }
        public LamparaInteligente(string habitaciónvalidada, string colorled) : base(habitaciónvalidada)
        {
            ColorLed = colorled;
        }
        public override string EjecutarFunción()
        {
            return $"Lampara encendida en la habitación {HabitaciónValidada}, color asignado: {ColorLed}";
        }
    }
}
