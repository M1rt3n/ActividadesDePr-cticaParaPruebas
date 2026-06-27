using ConsoleApp3;
using System.Diagnostics.Metrics;
internal class Program
{
    static void Main(string[] args)
    {
        List<Dispositivo> equipo = new List<Dispositivo>();
        equipo.Add(new LamparaInteligente("Suite 3", "Turquesa"));
        equipo.Add(new AspiradoraRobot("204", 250));
        equipo.Add(new AspiradoraRobot("Suite 1", 300));
        Console.WriteLine("\n--- Ensayo: ---");
        foreach (Dispositivo v in equipo)
        {
            Console.WriteLine(v.EjecutarFunción());
        }
    }
}