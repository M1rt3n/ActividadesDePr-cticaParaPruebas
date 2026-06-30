using ConsoleApp8;
using System.Diagnostics.Metrics;
internal class Program
{
    static void Main(string[] args)
    {
        List<Torreta> equipo = new List<Torreta>();
        equipo.Add(new TorretaLaser("X:24 Y:0 Z:60", 100));
        equipo.Add(new Lanzamisiles("X:18 Y:0 Z:62", 20));
        equipo.Add(new Torreta("X:23 Y:2 Z:64" ));
        equipo.Add(new Lanzamisiles("X:19 Y:0 Z:65", 0));
        equipo.Add(new TorretaLaser("X:22 Y:-1 Z:63", 0));
        Console.WriteLine("\n--- Ensayo: ---");
        foreach (Torreta v in equipo)
        {
            Console.WriteLine(v.Disparar());
        }
    }
}