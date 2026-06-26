using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp5_Práctica_2;

class Program
{
    static void Main(string[] args)
    {
        List<Transacción> equipo = new List<Transacción>();
        equipo.Add(new Transferencia("jh91083r", 100,"Jorge.mercadolibre"));
        equipo.Add(new PagoServicio("nfao1280", 10));
        equipo.Add(new Transferencia("03ysda082",80,"Manolo.paypal"));

        Console.WriteLine("\n--- Resumen del turno: ---");
        foreach (Transacción v in equipo)
        {
            Console.WriteLine(v.Procesar("nfao1280", 500));
            Console.WriteLine(new string('-', 50));
        }
    }
}