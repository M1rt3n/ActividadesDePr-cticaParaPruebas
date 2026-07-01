using System;
using System.Collections.Generic;

namespace ConsoleApp10_Práctica2
{
    public class Mensaje
    {
        private string _textooriginal;
        public string TextoOriginal
        {
            get { return _textooriginal; }
            set
            {
                foreach (char c in value)
                {
                    if (!char.IsLetter(c) && c != ' ')
                    {
                        throw new ArgumentException("No se admiten números ni caracteres especiales.");
                    }
                }
                _textooriginal = value;
            }
        }
        public Mensaje(string textooriginal)
        {
            TextoOriginal = textooriginal;
        }
        public virtual string Cifrar()
        {
            return TextoOriginal;
        }
    }
    public class CifradoInvertido : Mensaje
    {
        public CifradoInvertido(string textooriginal) : base(textooriginal) { }

        public override string Cifrar()
        {
            char[] Letras = TextoOriginal.ToCharArray();
            Array.Reverse(Letras);
            return new string(Letras);
        }
    }
    public class CifradoDesplazamiento : Mensaje
    {
        public int ClaveNumérica { get; set; }
        public CifradoDesplazamiento(string textooriginal, int clavenumérica) : base(textooriginal)
        {
            ClaveNumérica = clavenumérica;
        }
        public override string Cifrar()
        {
            string Resultado = "";
            foreach (char c in TextoOriginal)
            {
                if (c == ' ')
                {
                    Resultado += " ";
                }
                else
                {
                    char LetraCifrada = (char)(c + ClaveNumérica);
                    Resultado += LetraCifrada;
                }
            }
            return Resultado;
        }
    }
}
