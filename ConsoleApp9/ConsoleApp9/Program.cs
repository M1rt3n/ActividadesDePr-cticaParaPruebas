using ConsoleApp9;
using System.Diagnostics.Metrics;
internal class Program
{
    static void Main(string[] args)
    {
        List<Envio> equipo = new List<Envio>();
        equipo.Add(new EnvioExpess("Campana 3245", 12));
        equipo.Add(new EnvioFrágil("Saavedra 954", "Telgopor"));
        equipo.Add(new EnvioExpess("Artigas 2036", 8));
        equipo.Add(new EnvioFrágil("Belgrano 730", "Papel burbuja"));
        Console.WriteLine("\n--- Ensayo: ---");
        foreach (Envio v in equipo)
        {
            Console.WriteLine(v.ProcesarEntrega());
        }
    }
}