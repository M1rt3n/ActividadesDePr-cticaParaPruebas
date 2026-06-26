using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp6_Práctica_2;

class Program
{
    static void Main(string[] args)
    {
        List<Aeronave> equipo = new List<Aeronave>();
        equipo.Add(new Helicóptero(100, 10));
        equipo.Add(new AviónComercial(8900, 100));
        equipo.Add(new Helicóptero(200, 30));
        equipo.Add(new AviónComercial(10001, 120));

        Console.WriteLine("\n--- Resumen del turno: ---");
        foreach (Aeronave v in equipo)
        {
            Console.WriteLine(v.GenerarReporteMantenimiento());
        }
    }
}