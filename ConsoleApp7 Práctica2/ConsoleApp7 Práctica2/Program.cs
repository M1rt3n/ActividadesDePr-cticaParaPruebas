using System;
using ConsoleApp7_Práctica2;

class Program
{
    static void Main(string[] args)
    {
        List<Subasta> equipo = new List<Subasta>();
        equipo.Add(new SubastaRelámpago(31125, 16));
        equipo.Add(new SubastaPremium(42500, 2250));
        equipo.Add(new SubastaRelámpago(35750, 9));
        equipo.Add(new SubastaPremium(50000, 2500));

        Console.WriteLine("\n--- Resumen del turno: ---");
        foreach (Subasta v in equipo)
        {
            Console.WriteLine(v.RegistrarOferta(45000));
        }
    }
}