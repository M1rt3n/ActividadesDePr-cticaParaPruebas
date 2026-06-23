using ConsoleApp1___Práctica_2;

class Program
{
    static void Main(string[] args)
    {
        List<Vehículo> equipo = new List<Vehículo>();
        equipo.Add(new Particular("Volswagen", 500));
        equipo.Add(new Camión("Ford", 200, 1));
        equipo.Add(new Camión("Ferrari", 400, 4));
        equipo.Add(new Particular("Chevrolet", 50));

        Console.WriteLine("\n--- Resumen del turno: ---");
        foreach (Vehículo v in equipo)
        {
            Console.WriteLine(v.PagarPeaje(100));
        }
    }
}