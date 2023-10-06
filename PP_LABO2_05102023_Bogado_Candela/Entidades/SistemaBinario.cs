using System;
using System.Text.RegularExpressions;

namespace Entidades
{
    internal class SistemaBinario : Numeracion
    {
        /// <summary>
        /// Retorna el valor de la instancia en sistema decimal.
        /// </summary>
        internal override double ValorNumerico
        {
            get
            {
                double.TryParse(base.valor, out double valorRetorno);
                return valorRetorno;
            }
        }
        /// <summary>
        /// El método CambiarSistemaDeNumeracion devolverá una Numeración en el sistema recibido.
        /// </summary>
        /// <param name="sistema"></param>
        /// <returns></returns>
        public override Numeracion CambiarSistemaDeNumeracion(ESistema sistema)
        {
            return this.BinarioADecimal();
        }
        /// <summary>
        /// Verifica que la cadena recibida no sea nula o con espacios vacíos y adicionalmente sea un sistema binario válido.
        /// </summary>
        /// <param name="valor"></param>
        /// <returns>Bool</returns>
        protected bool EsNumeracionValida(string valor)
        {
            if (base.EsNumeracionValida(valor) && EsSistemaBinarioValido(valor))
            {
                return true;
            }
            return false;
        }
        /// <summary>
        /// Valida que una cadena de caracteres esté compuesta SOLAMENTE por caracteres '0' o '1'.
        /// </summary>
        /// <param name="valor"></param>
        /// <returns>True si la cadena está compuesta sólo por '0' o '1'. False si la cadena tiene otros caracteres.</returns>
        private static bool EsSistemaBinarioValido(string valor)
        {
            return Regex.IsMatch(valor, "^[01]+$");
        }
        /// <summary>
        /// El método BinarioADecimal verificará que el valor de la instancia no posea un msgError.
        /// De no tenerlo, convertirá este a SistemaDecimal.
        /// Caso contrario devolverá el mínimo de un double.
        /// </summary>
        /// <returns>SistemaDecimal</returns>
        private SistemaDecimal BinarioADecimal()
        {
            if (this.ValorNumerico > 0 && EsNumeracionValida(this.valor))
            {
                int digito = 0;
                const int DIVISOR = 10;
                double valorDecimal = 0;

                for (double i = this.ValorNumerico, j = 0; i > 0; i /= DIVISOR, j++)
                {
                    digito = (int)i % DIVISOR;
                    if (digito != 1 && digito != 0)
                    {
                        return -1;
                    }
                    valorDecimal += digito * (int)Math.Pow(2, j);
                }

                return new SistemaDecimal(valorDecimal.ToString());
            }
            else
            {
                return new SistemaDecimal(base.msgError);
            }
        }
        /// <summary>
        /// Realiza una conversión implícita de string a SistemaBinario.
        /// </summary>
        /// <param name="valor"></param>
        /// <returns>SistemaDecimal</returns>
        public static implicit operator SistemaBinario(string valor)
        {
            return new SistemaBinario(valor);
        }
        /// <summary>
        /// Constructor de clase.
        /// </summary>
        /// <param name="valor"></param>
        public SistemaBinario(string valor)
            : base(valor)
        {

        }
    }
}
