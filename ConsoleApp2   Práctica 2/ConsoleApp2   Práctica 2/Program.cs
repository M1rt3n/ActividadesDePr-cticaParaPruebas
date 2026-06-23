using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp2___Práctica_2;

class Program
{
    static void Main(string[] args)
    {
        List<Sensor> equipo = new List<Sensor>();
        equipo.Add(new SensorTemperatura(1,"Volswagen", 150));
        equipo.Add(new SensorPresión(2,"Ford", new double[] { 5.0, 10.0, 15.0, 20.0 }));
        equipo.Add(new SensorTemperatura(3,"Chevrolet", 50));
        equipo.Add(new SensorPresión(4, "Ok", new double[] { 10.0, 20.0, 30.0, 40.0 }));

        Console.WriteLine("\n--- Resumen del turno: ---");
        foreach (Sensor v in equipo)
        {
            Console.WriteLine(v.EvaluarLectura(100));
        }
        Console.ReadKey();
    }
}