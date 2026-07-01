using ConsoleApp9_Práctica2;
using System;

class Program
{
    static void Main(string[] args)
    {
        List<Planta> equipo = new List<Planta>();
        equipo.Add(new Cactus(319, 100));
        equipo.Add(new Helecho(95, 75, true));
        equipo.Add(new Cactus(40, 50));
        equipo.Add(new Helecho(242, 64, false));

        foreach (Planta v in equipo)
        {
            Console.WriteLine("\n--- Resumen del turno: ---");
            Console.WriteLine(v.GetType().Name);
            Console.Write("\n--- 1er Turno: ---");
            Console.WriteLine(v.AplicarClima("Lluvioso"));
            Console.Write("\n--- 2do Turno: ---");
            Console.WriteLine(v.AplicarClima("Seco"));
            Console.Write("\n--- 3er Turno: ---");
            Console.WriteLine(v.AplicarClima("Desértico"));
        }
    }
}