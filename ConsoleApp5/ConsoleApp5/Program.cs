using ConsoleApp5;
using System.Diagnostics.Metrics;
internal class Program
{
    static void Main(string[] args)
    {
        List<Empleado> equipo = new List<Empleado>();
        equipo.Add(new Diseñador(427, "Photoshop"));
        equipo.Add(new Diseñador(298, "Access"));
        equipo.Add(new Programador(1463, "Javascript"));
        equipo.Add(new Programador(715, "C#"));
        Console.WriteLine("\n--- Ensayo: ---");
        foreach (Empleado v in equipo)
        {
            Console.WriteLine(v.Trabajar());
        }
    }
}