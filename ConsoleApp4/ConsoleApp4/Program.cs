using ConsoleApp4;
using System.Diagnostics.Metrics;
internal class Program
{
    static void Main(string[] args)
    {
        List<Plato> equipo = new List<Plato>();
        equipo.Add(new Pizza("Hawaiana", "Batida"));
        equipo.Add(new Ensalada("Marinera", "Aceite de oliva"));
        equipo.Add(new Pizza("Capresse", "Fermentada"));
        equipo.Add(new Ensalada("César", "Mayonesa"));
        Console.WriteLine("\n--- Ensayo: ---");
        foreach (Plato v in equipo)
        {
            Console.WriteLine(v.Preparar());
        }
    }
}