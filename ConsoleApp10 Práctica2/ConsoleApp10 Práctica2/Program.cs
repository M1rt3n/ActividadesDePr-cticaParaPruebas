using System;
using ConsoleApp10_Práctica2;
class Program
{
    static void Main(string[] args)
    {
        string texto = "Ejemplo";
        List<Mensaje> equipo = new List<Mensaje>();

        equipo.Add(new CifradoInvertido(texto));
        equipo.Add(new CifradoDesplazamiento(texto, 1));
        equipo.Add(new CifradoInvertido(texto));
        equipo.Add(new CifradoDesplazamiento(texto, 3));
        foreach (Mensaje v in equipo)
        {
            Console.WriteLine($"Clase: {v.GetType().Name}");
            Console.WriteLine($"Resultado: {v.Cifrar()}");
            Console.WriteLine("-----------------------------");
        }
    }
}