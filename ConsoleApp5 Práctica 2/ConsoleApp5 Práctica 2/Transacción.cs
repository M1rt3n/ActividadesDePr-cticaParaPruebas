using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5_Práctica_2
{
    public class Transacción
    {
        private string _tokenSeguridad;

        public string TokenSeguridad
        {
            get => _tokenSeguridad;
            set
            {
                if (value != null && value.Length == 8)
                    _tokenSeguridad = value;
                else
                    _tokenSeguridad = null;
            }
        }

        public double PagoTotal { get; set; }
        public Transacción(string tokenSeguridad)
        {
            TokenSeguridad = tokenSeguridad;
        }

        public virtual string Procesar(string tokenIngresado, double total)
        {
            if (string.IsNullOrEmpty(TokenSeguridad))
            {
                return "El token original debe tener exactamente 8 caracteres.";
            }

            if (tokenIngresado == TokenSeguridad)
            {
                PagoTotal = total;
                return "Token aceptado";
            }
            else
            {
                return "Token denegado";
            }
        }
    }

    public class Transferencia : Transacción
    {
        public double Monto { get; set; }
        public string CuentaDestino { get; set; }

        public Transferencia(string tokenSeguridad, double monto, string cuentaDestino)
            : base(tokenSeguridad)
        {
            Monto = monto;
            CuentaDestino = cuentaDestino;
        }

        public override string Procesar(string tokenIngresado, double total)
        {
            string resultadoBase = base.Procesar(tokenIngresado, total);
            if (resultadoBase != "Token aceptado") return resultadoBase;
            if (Monto > 500000)
            {
                return "Requiere autorización presencial";
            }

            return $"Token aceptado, transferencia exitosa a {CuentaDestino} por ${Monto}.";
        }
    }

    public class PagoServicio : Transacción
    {
        public int DiasVencido { get; set; }

        public PagoServicio(string tokenSeguridad, int diasVencido)
            : base(tokenSeguridad)
        {
            DiasVencido = diasVencido;
        }

        public override string Procesar(string tokenIngresado, double total)
        {
            string resultadoBase = base.Procesar(tokenIngresado, total);
            if (resultadoBase != "Token aceptado") return resultadoBase;

            if (DiasVencido > 0)
            {
                PagoTotal = total * 1.01*DiasVencido;

                return $"Token aceptado, pago procesado con intereses. Total: ${PagoTotal:N2}";
            }
            else
            {
                return $"Token aceptado, pago procesado al día sin recargos. Total: ${PagoTotal:N2}";
            }
        }
    }
}