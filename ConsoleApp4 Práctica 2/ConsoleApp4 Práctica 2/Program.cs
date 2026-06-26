using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp4_Práctica_2;

class Program
{
    static void Main(string[] args)
    {
        List<Batería> equipo = new List<Batería>();
        equipo.Add(new BateríaLitio(100));
        equipo.Add(new BateríaSolar(75, 100));
        equipo.Add(new BateríaLitio(80));

        Console.WriteLine("\n--- Resumen del turno: ---");
        foreach (Batería v in equipo)
        {
            Console.WriteLine(v.ConsumirEnergía(50));
        }
    }
}