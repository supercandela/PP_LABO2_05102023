using System;
using System.Text.RegularExpressions;

namespace Entidades
{
    public class SistemaBinario : Numeracion
    {

        /// <summary>
        /// Constructor de clase.
        /// </summary>
        /// <param name="valor"></param>
        public SistemaBinario(string valor)
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
                return (double)this.CambiarSistemaDeNumeracion(ESistema.Decimal);
            }
        }
        /// <summary>
        /// El método CambiarSistemaDeNumeracion devolverá una Numeración en el sistema recibido.
        /// </summary>
        /// <param name="sistema"></param>
        /// <returns></returns>
        public override Numeracion CambiarSistemaDeNumeracion(ESistema sistema)
        {
            switch (sistema)
            {
                case ESistema.Decimal:
                    return this.BinarioADecimal();
            }
            return this;
        }
        /// <summary>
        /// Verifica que la cadena recibida no sea nula o con espacios vacíos y adicionalmente sea un sistema binario válido.
        /// </summary>
        /// <param name="valor"></param>
        /// <returns>Bool</returns>
        protected override bool EsNumeracionValida(string valor)
        {
            if (base.EsNumeracionValida(valor) && this.EsSistemaBinarioValido(valor))
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
        private bool EsSistemaBinarioValido(string valor)
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
            if(base.valor != Numeracion.msgError)
            {
                int potencia = base.valor.Length - 1;
                int resultado = 0;

                foreach (char item in base.valor) 
                {
                    if (item == '1')
                    {
                        resultado = resultado + (int)Math.Pow(2, potencia);
                    }
                    potencia--;
                }
                return resultado;
            }
            return double.MinValue;

            //if (this.ValorNumerico > 0 && this.EsNumeracionValida(this.valor))
            //{
            //    int digito = 0;
            //    const int DIVISOR = 10;
            //    double valorDecimal = 0;

            //    for (double i = this.ValorNumerico, j = 0; i > 0; i /= DIVISOR, j++)
            //    {
            //        digito = (int)i % DIVISOR;
            //        if (digito != 1 && digito != 0)
            //        {
            //            return -1;
            //        }
            //        valorDecimal += digito * (int)Math.Pow(2, j);
            //    }

            //    return new SistemaDecimal(valorDecimal.ToString());
            //}
            //else
            //{
            //    return new SistemaDecimal(Numeracion.msgError);
            //}
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
    }
}
