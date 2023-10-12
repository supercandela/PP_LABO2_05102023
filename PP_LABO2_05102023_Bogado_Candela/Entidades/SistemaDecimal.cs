using Microsoft.VisualBasic;
using System.Runtime.ConstrainedExecution;
using System.Text.RegularExpressions;

namespace Entidades
{
    public class SistemaDecimal : Numeracion
    {
        /// <summary>
        /// Constructor de clase.
        /// </summary>
        /// <param name="valor"></param>
        public SistemaDecimal(string valor)
            : base(valor)
        {

        }
        /// <summary>
        /// Retorna el valor de la instancia en sistema decimal.
        /// </summary>
        internal override double ValorNumerico
        {
            get
            {
                return (double)this;
            }
        }
        /// <summary>
        /// El método CambiarSistemaDeNumeracion devolverá una Numeración en el sistema recibido.
        /// </summary>
        /// <param name="sistema"></param>
        /// <returns></returns>
        public override Numeracion CambiarSistemaDeNumeracion(ESistema sistema)
        {
            //return this.DecimalABinario();
            switch (sistema)
            {
                case ESistema.Binario:
                    return this.DecimalABinario();
            }
            return this;
        }
        /// <summary>
        /// Verifica que el valor a convertir sea mayor que 0 (cero).
        /// De ser posible, realiza la conversión de la parte entera de una Numeracion de tipo SistemaDecimal a SistemaBinario.
        /// Caso contrario devolverá un msgError.
        /// </summary>
        /// <returns></returns>
        private SistemaBinario DecimalABinario()
        {
            //Se queda con la parte entera del número y lo guarda en valor
            int valor = Convert.ToInt32(this.ValorNumerico);
            if (valor > 0 && EsNumeracionValida(this.valor))
            {
                double binario = 0;

                const int DIVISOR = 2;
                double digito = 0;

                for (int i = valor % DIVISOR, j = 0; valor > 0; valor /= DIVISOR, i = valor % DIVISOR, j++)
                {
                    digito = i % DIVISOR;
                    binario += digito * (double)Math.Pow(10, j);
                }

                return new SistemaBinario(binario.ToString());
            }
            else
            {
                return new SistemaBinario(Numeracion.msgError);
            }
        }
        /// <summary>
        /// Verifica que la cadena recibida no sea nula o con espacios vacíos y adicionalmente sea un sistema decimal válido.
        /// </summary>
        /// <param name="valor"></param>
        /// <returns>Bool</returns>
        protected override bool EsNumeracionValida(string valor)
        {
            //if (base.EsNumeracionValida(valor) && EsSistemaDecimalValido(valor))
            //{
            //    return true;
            //}
            //return false;

            return base.EsNumeracionValida(valor) && EsSistemaDecimalValido(valor);
        }
        /// <summary>
        /// Verifica que la cadena recibida pueda convertirse a tipo double.
        /// </summary>
        /// <param name="valor"></param>
        /// <returns></returns>
        private bool EsSistemaDecimalValido(string valor)
        {
            //if (double.TryParse(valor, out double nuevoValor))
            //{
            //    return true;
            //}
            //return false;

            return double.TryParse(valor, out double nuevoValor);
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
    }
}
