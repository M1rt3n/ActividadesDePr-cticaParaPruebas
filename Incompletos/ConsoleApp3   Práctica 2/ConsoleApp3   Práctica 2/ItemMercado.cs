using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3___Práctica_2
{
    public class ItemMercado
    {
        public string Nombre { get; set; }
        public int PrecioBase { get; set; }
        public int Stock { get; set; }
        public ItemMercado(string nombre, int preciobase, int stock)
        {
            Nombre = nombre;
            PrecioBase = preciobase;
            Stock = stock;
        }

        public virtual string CotizarVenta(int cantidad)
        {
            return $"Turno de {Nombre}.";
        }
    }

    public class Particular : ItemMercado
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
                Stock -= cantidad;
                return $"[No había suficientes pociones, se han mandado {cantidad} pociones]";
            }
            else
            {
                Stock -= cantidad ;
                return $"[POciones enviadas]";
            }
        }
    }

    public class Camión : ItemMercado
    {
        public int Ejes { get; set; }
        public Camión(string nombre, decimal saldo, int ejes) : base(nombre, saldo)
        {
            Ejes = ejes;
        }

        public override string PagarPeaje(decimal tarifa)
        {
            decimal tarifaTotal = tarifa * Ejes;
            if (Ejes >= 4)
            {
                tarifaTotal *= 0.9m;
            }
            if (Saldo >= tarifaTotal)
            {
                return $"[El camión {Nombre} de {Ejes} ejes ha pagado la tarifa de {tarifaTotal:C}]";
            }
            else
            {
                return $"[El camión {Nombre} no ha podido pagar la tarifa de {tarifaTotal:C}]";
            }
        }
    }
}