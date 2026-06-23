using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1___Práctica_2
{
    public class Vehículo
    {
        public string Nombre { get; set; }
        public decimal Saldo { get; set; }
        public Vehículo(string nombre, decimal saldo)
        {
            Nombre = nombre;
            Saldo = saldo;
        }

        public virtual string PagarPeaje(decimal tarifa)
        {
            return $"Turno de {Nombre}.";
        }
    }

    public class Particular : Vehículo
    {
        public Particular(string nombre, decimal saldo) : base(nombre, saldo)
        {
        }
        public override string PagarPeaje(decimal tarifa)
        {
            if (Saldo >= tarifa)
            {
                Saldo -= tarifa;
                return $"[El auto {Nombre} ha pagado la tarifa de {tarifa:C}]";
            }
            else
            {
                return $"[Acceso denegado a {Nombre}: Saldo insuficiente]";
            }
        }
    }

    public class Camión : Vehículo
    {
        public int Ejes { get; set; }
        public Camión(string nombre, decimal saldo, int ejes) : base(nombre, saldo)
        {
            Ejes = ejes;
        }

        public override string PagarPeaje(decimal tarifa)
        {
            decimal tarifaTotal = tarifa * Ejes;
            if (Ejes >= 4)
            {
                tarifaTotal *= 0.9m;
            }
            if (Saldo >= tarifaTotal)
            {
                return $"[El camión {Nombre} de {Ejes} ejes ha pagado la tarifa de {tarifaTotal:C}]";
            }
            else
            {
                return $"[El camión {Nombre} no ha podido pagar la tarifa de {tarifaTotal:C}]";
            }
        }
    }
}