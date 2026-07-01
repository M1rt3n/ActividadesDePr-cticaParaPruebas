using ConsoleApp8_Práctica2;
using System;

class Program
{
    static void Main(string[] args)
    {
        List<Descarga> equipo = new List<Descarga>();
        equipo.Add(new ArchivoComprimido(4110, 16, true));
        equipo.Add(new ArchivoComprimido(318608, 100, false));
        equipo.Add(new StreamingVideo(6460, 51, 25));
        equipo.Add(new StreamingVideo(9915, 4, 40));

        Console.WriteLine("\n--- Resumen del turno: ---");
        foreach (Descarga v in equipo)
        {
            Console.WriteLine(v.ActualizarProgreso(3000));
        }
    }
}