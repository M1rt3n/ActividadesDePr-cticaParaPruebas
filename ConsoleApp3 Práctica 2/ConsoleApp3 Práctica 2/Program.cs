using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp3_Práctica_2;

class Program
{
    static void Main(string[] args)
    {
        List<ItemMercado> equipo = new List<ItemMercado>();
        equipo.Add(new Poción("Poción de Invisibilidad", 30, 300, "Te vuelve invisible"));
        equipo.Add(new Poción("Poción Multijugos", 25, 50, "Toma la apariencia de la persona escogida"));
        equipo.Add(new MineralRaro("Oricalco", 50, 400, 5));
        equipo.Add(new MineralRaro("Mithril", 400, 5, 10));

        Console.WriteLine("\n--- Resumen del turno: ---");
        foreach (ItemMercado v in equipo)
        {
            Console.WriteLine(v.CotizarVenta(10));
        }
    }
}