using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    public class Empleado
    {
        public int IdEmpleado { get; set; }

        public Empleado(int idempleado)
        {
            IdEmpleado = idempleado;
        }
        public virtual string Trabajar()
        {
            return $"El empleado {IdEmpleado} se ha puesto a trabajar";
        }
    }

    public class Programador : Empleado
    {
        public string LenguajePrincipal { get; set; }
        public Programador(int idempleado, string lenguajeprincipal) : base(idempleado)
        {
           LenguajePrincipal = lenguajeprincipal;
        }
        public override string Trabajar()
        {
            return $"El empleado {IdEmpleado} se ha puesto a programar | Lenguaje en el que está trabajando: {LenguajePrincipal}";
        }
    }
    public class Diseñador : Empleado
    {
        public string HerramientaFavorita { get; set; }
        public Diseñador(int idempleado, string herramientafavorita) : base(idempleado)
        {
            HerramientaFavorita = herramientafavorita;
        }
        public override string Trabajar()
        {
            return $"El empleado {IdEmpleado} se ha puesto a siseñar | Herramienta que está usando: {HerramientaFavorita}";
        }
    }
}
