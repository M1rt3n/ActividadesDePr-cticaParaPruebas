using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2___Práctica_2
{
    public class Sensor
    {
        public int Id { get; set; }
        public string Estado { get; set; }
        public Sensor(int id, string estado)
        {
            Id = id;
            Estado = estado;
        }

        public virtual string EvaluarLectura(double valor)
        {
            return $"Escaneando.";
        }
    }

    public class SensorTemperatura : Sensor
    {
        public double LímiteCrítico { get; set; }
        public SensorTemperatura(int Id, string Estado, double límitecrítico) : base(Id, Estado)
        {
            LímiteCrítico = límitecrítico;
        }
        public override string EvaluarLectura(double valor)
        {
            if (valor > LímiteCrítico)
            {
                Estado = "PELIGRO";
                return $"[Sensor {Id}, {Estado}]";
            }
            else {
                if (valor > (LímiteCrítico * 0.75) && valor < LímiteCrítico)
                {
                    Estado = "Alerta";
                    return $"[Sensor {Id}, {Estado}]";
                }
                else
                {
                    Estado = "Ok";
                    return $"[Sensor {Id}, {Estado}]";
                } 
            }
        }
    }

    public class SensorPresión : Sensor
    {
        public double[] Lista { get; set; }
        public SensorPresión(int Id, string Estado, double[] lista) : base(Id, Estado)
        {
            Lista = lista;
        }
        public override string EvaluarLectura(double valor)
        {
            if (Lista[1] < Lista[2] && Lista[2] < Lista[3])
            {
                return $"[La tendencia es inestable]";
            }
            else
            {
                return $"[La tendencia es estable]";
            }
        }
    }
}
