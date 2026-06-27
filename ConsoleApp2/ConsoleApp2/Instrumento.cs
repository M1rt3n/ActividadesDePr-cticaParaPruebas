using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ConsoleApp2
{
    public class Instrumento
    {
        public string Modelo { get; set; }
        public string NotaActual { get; set; }

        public Instrumento(string modelo) 
        {
            Modelo = modelo;
        }

        public virtual string TocarNota()
        {
            return $"{Modelo}: Do";
        }
    }

    public class Guitarra : Instrumento
    {
        public int NúmeroCuerdas { get; set; }
        public Guitarra(string modelo, int númerocuerdas) : base(modelo)
        {
            NúmeroCuerdas = númerocuerdas;
        }
        public override string TocarNota()
        {
            if (NúmeroCuerdas == 1)
            {
                return $"{Modelo}: Do";
            }
            else
            {
                if (NúmeroCuerdas == 2)
                {
                    return $"{Modelo}: Re";
                }
                else
                {
                    if (NúmeroCuerdas == 3)
                    {
                        return $"{Modelo}: Mi";
                    }
                    else
                    {
                        if (NúmeroCuerdas == 4)
                        {
                            return $"{Modelo}: Fa";
                        }
                        else
                        {
                            if (NúmeroCuerdas == 5)
                            {
                                return $"{Modelo}: Sol";
                            }
                            else
                            {
                                if (NúmeroCuerdas == 6)
                                {
                                    return $"{Modelo}: La";
                                }
                                else
                                {
                                    if (NúmeroCuerdas == 7)
                                    {
                                        return $"{Modelo}: Si";
                                    }
                                    else
                                    {
                                        return $"{Modelo}: Clave de sol";
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
    public class Piano : Instrumento
    {
        public int NúmeroTeclas { get; set; }
        public Piano(string modelo, int númeroteclas) : base(modelo)
        {
            NúmeroTeclas = númeroteclas;
        }
        public override string TocarNota()
        {
            if (NúmeroTeclas == 1)
            {
                return $"{Modelo}: Do";
            }
            else
            {
                if (NúmeroTeclas == 2)
                {
                    return $"{Modelo}: Re";
                }
                else
                {
                    if (NúmeroTeclas == 3)
                    {
                        return $"{Modelo}: Mi";
                    }
                    else
                    {
                        if (NúmeroTeclas == 4)
                        {
                            return $"{Modelo}: Fa";
                        }
                        else
                        {
                            if (NúmeroTeclas == 5)
                            {
                                return $"{Modelo}: Sol";
                            }
                            else
                            {
                                if (NúmeroTeclas == 6)
                                {
                                    return $"{Modelo}: La";
                                }
                                else
                                {
                                    if (NúmeroTeclas == 7)
                                    {
                                        return $"{Modelo}: Si";
                                    }
                                    else
                                    {
                                        return $"{Modelo}: Clave de sol";
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}