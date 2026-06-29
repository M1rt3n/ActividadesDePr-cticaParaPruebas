using ConsoleApp7;
using System.Diagnostics.Metrics;
internal class Program
{
    static void Main(string[] args)
    {
        List<Juguete> almacen = new List<Juguete>();
        almacen.Add(new AutoControl(63, 16));
        almacen.Add(new AutoControl(28, 32));
        almacen.Add(new Muñeca(4, "Algodón"));
        almacen.Add(new Muñeca(11, "Lana"));
        Console.WriteLine("\n--- Ensayo: ---");
        foreach (Juguete v in almacen)
        {
            Console.WriteLine(v.ProbarJuguete());
        }
    }
}