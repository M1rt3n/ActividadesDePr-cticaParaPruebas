using ConsoleApp10;
using System.Diagnostics.Metrics;
internal class Program
{
    static void Main(string[] args)
    {
        List<Hechizo> hechizos = new List<Hechizo>();
        hechizos.Add(new Bola_de_fuego("Fireball", 100));
        hechizos.Add(new Bola_de_fuego("Ignitionball", 250));
        hechizos.Add(new EscudoHielo("Coldshield", 10));
        hechizos.Add(new EscudoHielo("Frozenshield", 25));
        Console.WriteLine("\n--- Ensayo: ---");
        foreach (Hechizo v in hechizos)
        {
            Console.WriteLine(v.Lanzar());
        }
    }
}