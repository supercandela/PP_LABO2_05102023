using System;
using System.Drawing;
using System.Runtime.Intrinsics.X86;

namespace Entidades
{
    abstract class Numeracion
    {
        protected string msgError;
        protected string valor;
        /// <summary>
        /// Propiedad Valor. Sólo lectura. Retorna el atributo valor.
        /// </summary>
        public string Valor
        {
            get
            {
                return valor;
            }
        }
        /// <summary>
        /// La propiedad ValorNumerico será internal y deberá de ser implementada de forma obligatoria en sus clases derivadas.
        /// </summary>
        internal virtual double ValorNumerico
        {
            get
            {
                
            }
        }
        /// <summary>
        /// Inicializa el atributo de clase msgError con el valor por defecto.
        /// </summary>
        private Numeracion()
        {
            msgError = "Numero Invalido";
        }
        /// <summary>
        /// El constructor de Numeración, que recibe un valor, será protegido, este llamará al método inicializaValor, quien será el encargo de darle un estado inicial a dicho atributo.
        /// </summary>
        protected Numeracion(string valor)
            :this()
        {
            this.InicializaValor(valor);
        }
        /// <summary>
        /// Inicializa el atributo valor de la instancia. 
        /// Valida que el valor recibido sea una numeración válida, de lo contrario el atributo almacenará un mensaje de error.
        /// </summary>
        /// <param name="valor"></param>
        private void InicializaValor(string valor)
        {
            if (EsNumeracionValida(valor))
            {
                this.valor = valor;
            }
            else
            {
                this.valor = msgError;
            }
        }
        /// <summary>
        /// El método CambiarSistemaDeNumeracion será público y deberá de ser implementado de forma obligatoria en sus clases derivadas.
        /// </summary>
        /// <param name="sistema"></param>
        /// <returns></returns>
        public abstract Numeracion CambiarSistemaDeNumeracion(ESistema sistema);

        /// <summary>
        /// El método EsNumeracionValida, será protegido. En la clase base solo verificara que la cadena recibida no sea nula o con espacios en blanco.
        /// </summary>
        /// <param name="valor"></param>
        /// <returns></returns>
        protected virtual bool EsNumeracionValida(string valor)
        {
            valor = valor.Trim();
            if (valor != null)
            {
                return true;
            }
            return false;
        }
        /// <summary>
        /// Realiza una conversión explicita de Numeración a double, devolviendo el atributo valor de la Numeración convertido.
        /// </summary>
        /// <param name="numeracion"></param>
        /// <returns>Atributo valor convertido a Double</returns>
        public static explicit operator double(Numeracion numeracion)
        {
            double valorDeRetorno;
            if(!double.TryParse(numeracion.valor, out valorDeRetorno))
            {
                valorDeRetorno = double.MinValue;
            }
            return valorDeRetorno;
        }
        /// <summary>
        /// Sobrecarga de operador ==.
        /// Dos numeraciones serán iguales si no son nulas y son del mismo tipo.
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        /// <returns>Bool</returns>
        public static bool operator ==(Numeracion n1, Numeracion n2)
        {
            if (n1 is not null && n2 is not null && n1.GetType() == n2.GetType())
            {
                return true;
            }
            return false;
        }
        /// <summary>
        /// Sobrecarga de operador !=.
        /// Dos numeraciones serán diferentes si son nulas o no son del mismo tipo.
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        /// <returns>Bool</returns>
        public static bool operator !=(Numeracion n1, Numeracion n2)
        {
            return !(n1 == n2);
        }
    }
}