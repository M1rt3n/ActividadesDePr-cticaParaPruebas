using ConsoleApp6;
using System.Diagnostics.Metrics;
internal class Program
{
    static void Main(string[] args)
    {
        List<Alerta> equipo = new List<Alerta>();
        equipo.Add(new MalwareDetectado(6, "C:\\Windows\\VirusSetter\\setup.exe"));
        equipo.Add(new IntrusionRed(18, "194:54:1:2"));
        equipo.Add(new IntrusionRed(12, "128:0:0:1"));
        equipo.Add(new MalwareDetectado(1, "C:\\Windows\\System32\\MalwareExample.exe"));
        Console.WriteLine("\n--- Ensayo: ---");
        foreach (Alerta v in equipo)
        {
            Console.WriteLine(v.DispararProtocolo());
        }
    }
}