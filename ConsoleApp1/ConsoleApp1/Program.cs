using ConsoleApp1;
using static ConsoleApp1.Guerrero;
using static ConsoleApp1.Mago;

class Program
{
    static void Main(string[] args)
    {
        List<Basic> equipo = new List<Basic>();
            equipo.Add(new Mago("Vladimir", 500));
            equipo.Add(new Guerrero("Barlock", 175));
            equipo.Add(new Guerrero("Seth", 200));
            equipo.Add(new Guerrero("Frey", 150));

        Console.WriteLine("\n--- Resumen del turno: ---");
        foreach (Basic v in equipo)
        {
            Console.WriteLine(v.Arrancar());
        }
    }
}