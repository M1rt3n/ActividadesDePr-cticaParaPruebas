using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6_Práctica_2
{
    public class Aeronave
    {
        public int HorasVuelo { get; set; }
        public int LímiteReporte { get; set; }
        public int SituaciónReporte { get; set; }
        public Aeronave(int horasvuelo)
        {
            HorasVuelo = horasvuelo;
        }

        public virtual string GenerarReporteMantenimiento()
        {
            return $"Total de horas voladas: {HorasVuelo}";
        }
    }

    public class AviónComercial : Aeronave
    {
        public int PasajerosMáximos { get; set; }
        public AviónComercial(int horasvuelo, int pasajerosmáximos) : base(horasvuelo)
        {
            PasajerosMáximos=pasajerosmáximos;
        }
        public override string GenerarReporteMantenimiento()
        {
            if (HorasVuelo >= 10000)
            {
                return $"Total de horas voladas: {HorasVuelo} | Cantidad de pasajeros máximos: {PasajerosMáximos} | Observaciones: Requiere una revisión de Turbinas Tipo A).";
            }
            return $"Total de horas voladas: {HorasVuelo} | Cantidad de pasajeros máximos: {PasajerosMáximos} | Observaciones: El avión se encuentra en condiciones";
        }
    }

    public class Helicóptero : Aeronave
    {
        public int CiclosRotor { get; set; }
        public Helicóptero(int horasvuelo, int ciclosrotor) : base(horasvuelo)
        {
            CiclosRotor = ciclosrotor;
        }

        public override string GenerarReporteMantenimiento()
        {
            LímiteReporte = 1000;
            SituaciónReporte = CiclosRotor * HorasVuelo;
            if (SituaciónReporte > LímiteReporte)
            {
                return $"Total de horas voladas: {HorasVuelo} | Ciclos de rotor: {CiclosRotor} | Observaciones: Alerta: Reemplazo de palas requerido";
            }
            return $"Total de horas voladas: {HorasVuelo} | Ciclos de rotor: {CiclosRotor} | Observaciones: El helicóptero se encuentra en condiciones";
        }
    }
}
