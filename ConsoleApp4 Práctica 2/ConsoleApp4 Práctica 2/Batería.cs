using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4_Práctica_2
{
    public class Batería
    {
        public int PorcentajeCarga { get; set; }
        public bool AhorroActivo { get; set; }
        public Batería(int porcentajecarga)
        {
            PorcentajeCarga = porcentajecarga;
        }

        public virtual string ConsumirEnergía(int puntos)
        {
            PorcentajeCarga -= puntos;
            return $"Batería actual: {PorcentajeCarga}";
        }
    }

    public class BateríaLitio : Batería
    {
        public BateríaLitio(int porcentajecarga) : base(porcentajecarga)
        {
        }
        public override string ConsumirEnergía(int puntos)
        {
            if (PorcentajeCarga <= 0) 
            {
                AhorroActivo = true;
            }
            if (AhorroActivo == true)
            {
                PorcentajeCarga -= puntos/2;
            }
            else
            {
                PorcentajeCarga -= puntos;
            }
            if (PorcentajeCarga > 100)
            {
                PorcentajeCarga = 100;
            }
            if (PorcentajeCarga < 0)
            {
                PorcentajeCarga = 0;
            }
            return $"Batería actual: {PorcentajeCarga}";
        }
    }

    public class BateríaSolar : Batería
    {
        public int EficienciaPanel { get; set; }
        public BateríaSolar(int porcentajecarga, int eficienciapanel) : base(porcentajecarga)
        {
            EficienciaPanel = eficienciapanel;
        }

        public override string ConsumirEnergía(int puntos)
        {
            if (AhorroActivo == true)
            {
                PorcentajeCarga -= puntos / 2;
            }
            else
            {
                PorcentajeCarga -= puntos;
            }
            PorcentajeCarga += EficienciaPanel;
            if (PorcentajeCarga > 100)
            {
                PorcentajeCarga = 100;
            }
            if (PorcentajeCarga < 0)
            {
                PorcentajeCarga = 0;
            }
            return $"Batería actual: {PorcentajeCarga}";
        }
    }
}
