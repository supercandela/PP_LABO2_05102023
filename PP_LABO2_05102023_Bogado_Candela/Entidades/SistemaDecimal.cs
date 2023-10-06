using Microsoft.VisualBasic;
using System.Runtime.ConstrainedExecution;
using System.Text.RegularExpressions;

namespace Entidades
{
    internal class SistemaDecimal : Numeracion
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
        public Numeracion CambiarSistemaDeNumeracion(ESistema sistema)
        {

        }
        /// <summary>
        /// Verifica que el valor a convertir sea mayor que 0 (cero).
        /// De ser posible, realiza la conversión de la parte entera de una Numeracion de tipo SistemaDecimal a SistemaBinario.
        /// Caso contrario devolverá un msgError.
        /// </summary>
        /// <returns></returns>
        private SistemaBinario DecimalABinario()
        {

        }
        /// <summary>
        /// Verifica que la cadena recibida no sea nula o con espacios vacíos y adicionalmente sea un sistema decimal válido.
        /// </summary>
        /// <param name="valor"></param>
        /// <returns>Bool</returns>
        protected bool EsNumeracionValida(string valor)
        {
            if (base.EsNumeracionValida(valor) && EsSistemaDecimalValido(valor))
            {
                return true;
            }
            return false;
        }
        /// <summary>
        /// Verifica que la cadena recibida pueda convertirse a tipo double.
        /// </summary>
        /// <param name="valor"></param>
        /// <returns></returns>
        private bool EsSistemaDecimalValido(string valor)
        {
            if (double.TryParse(valor, out double nuevoValor))
            {
                return true;
            }
            return false;
        }
        /// <summary>
        /// Realiza una conversión implícita de double a SistemaDecimal.
        /// </summary>
        /// <param name="valor"></param>
        /// <returns>SistemaDecimal</returns>
        public static implicit operator SistemaDecimal(double valor)
        {
            return new SistemaDecimal(valor.ToString());
        }
        /// <summary>
        /// Realiza una conversión implícita de string a SistemaDecimal.
        /// </summary>
        /// <param name="valor"></param>
        /// <returns>SistemaDecimal</returns>
        public static implicit operator SistemaDecimal(string valor)
        {
            return new SistemaDecimal(valor);
        }
        /// <summary>
        /// Constructor de clase.
        /// </summary>
        /// <param name="valor"></param>
        public SistemaDecimal(string valor)
            :base(valor)
        {

        }
    }
}
