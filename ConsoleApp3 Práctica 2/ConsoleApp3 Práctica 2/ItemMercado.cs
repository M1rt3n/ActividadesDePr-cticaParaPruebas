using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3_Práctica_2
{
    public class ItemMercado
    {
        public string Nombre { get; set; }
        public int PrecioBase { get; set; }
        public int Stock { get; set; }

        public int PrecioTotal;
        public ItemMercado(string nombre, int preciobase, int stock)
        {
            Nombre = nombre;
            PrecioBase = preciobase;
            Stock = stock;
        }

        public virtual string CotizarVenta(int cantidad)
        {
            return $"Comprando {Nombre}.";
        }
    }

    public class Poción : ItemMercado
    {
        public Poción(string nombre, int preciobase, int stock, string efecto) : base(nombre, preciobase, stock)
        {
        }
        public override string CotizarVenta(int cantidad)
        {
            if (cantidad > Stock)
            {
                for (int i = 0; i > Stock; i++)
                {
                    cantidad = i;
                }
                PrecioTotal += cantidad * PrecioBase;
                Stock -= cantidad;
                return $"[No había suficientes pociones, se han mandado {cantidad} pociones, precio actual {PrecioTotal}]";
            }
            else
            {
                PrecioTotal += cantidad * PrecioBase;
                Stock -= cantidad;
                return $"[Pociones enviadas, precio actual {PrecioTotal}]";
            }
        }
    }

    public class MineralRaro : ItemMercado
    {
        public int FactorEscasez { get; set; }
        public MineralRaro(string nombre, int preciobase, int stock,int factorescasez) : base(nombre, preciobase, stock)
        {
            FactorEscasez = factorescasez;
        }

        public override string CotizarVenta(int cantidad)
        {
            if (Stock <= 5)
            {
                PrecioTotal += PrecioBase * cantidad * FactorEscasez;
                Stock -= cantidad;
                return $"[¡Precio inflado por alta demanda!, precio actual {PrecioTotal}]";
            }
            else
            {
                PrecioTotal += PrecioBase * cantidad;
                Stock -= cantidad;
                return $"[Minerales raros enviados, precio actual {PrecioTotal}]";
            }
        }
    }
}
