using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    public class Torreta
    {
        public string Ubicación { get; set; }

        public Torreta(string ubicación)
        {
            Ubicación = ubicación;
        }
        public virtual string Disparar()
        {
            return $"Torreta en {Ubicación} activada. Modo defensa establecido";
        }
    }

    public class TorretaLaser : Torreta
    {
        public int CargaBatería { get; set; }
        public TorretaLaser(string ubicación, int cargabatería) : base(ubicación)
        {
            CargaBatería = cargabatería;
        }
        public override string Disparar()
        {
            if (CargaBatería > 0)
            {
                return $"Torreta descargada. Recargando";
            }
            else
            {
                return $"Torreta laser en {Ubicación} activada | Carga de la batería: {CargaBatería}%. Modo defensa establecido";
            }
        }
    }
    public class Lanzamisiles : Torreta
    {
        public int MuniciónRestante { get; set; }
        public Lanzamisiles(string ubicación, int municiónrestante) : base(ubicación)
        {
            MuniciónRestante = municiónrestante;
        }
        public override string Disparar()
        {
            if (MuniciónRestante > 0)
            {
                return $"Lanzamisiles sin munición. Requiere mantenimiento inmediato";
            }
            else
            {
                return $"Lanzamisiles en {Ubicación} activada | Munición restante: {MuniciónRestante} unidades. Modo defensa establecido";
            }
        }
    }
}
