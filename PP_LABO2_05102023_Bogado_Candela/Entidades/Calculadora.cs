using System.Runtime.Intrinsics.Arm;
using System.Text;

namespace Entidades
{
    public class Calculadora
    {
        private string nombreAlumno;
        private List<string> operaciones;
        private Numeracion primerOperando;
        private Numeracion resultado;
        private Numeracion segundoOperando;
        private ESistema sistema;

        public string NombreAlumno
        {
            get
            {
                return this.nombreAlumno;
            }
            set
            {
                this.nombreAlumno = value;
            }
        }
        public List<string> Operaciones
        {
            get
            {
                return this.operaciones;
            }
        }
        public Numeracion PrimerOperando
        {
            get
            {
                return this.primerOperando;
            }
            set 
            { 
                this.primerOperando = value;
            }
        }
        public Numeracion Resultado
        {
            get
            {
                return this.resultado;
            }
        }
        public Numeracion SegundoOperando
        {
            get
            {
                return this.segundoOperando;
            }
            set
            {
                this.segundoOperando = value;
            }
        }
        public ESistema Sistema
        {
            get
            {
                return sistema;
            }
            set
            {
                this.sistema = value;
            }
        }
        public Calculadora()
        {
            this.operaciones = new List<string>();
        }
        public Calculadora(string nombreAlumno)
            :this()
        {
            this.nombreAlumno = nombreAlumno;
        }
        /// <summary>
        /// El método Calcular será el encargado de realizar las operaciones matemáticas entre 2 numeraciones. Aspectos a tener en cuenta: 
        /// i.Si no se recibe un operador, por defecto se realizará una suma.
        /// ii.Las operaciones se realizarán entre los valores numéricos de cada Numeración.
        /// iii.Estas solo se podrán llevar a cabo si ambas son del mismo tipo, de lo contrario su resultado será el mínimo de un double.
        /// iv.Le dará un valor al atributo resultado.Este siempre será un resultado mapeado, para ello deberá llamar al método correspondiente.
        /// </summary>
        public void Calcular()
        {

        }
        /// <summary>
        /// El método MapeaResultado devolverá una Numeracion en SistemaDecimal o SistemaBinario, dependiendo del sistema de la Calculadora.
        /// </summary>
        /// <param name="valor"></param>
        /// <returns></returns>
        private Numeracion MapearResultado(double valor)
        {
            return new Numeracion(Calculadora.Sistema);
        }
        /// <summary>
        /// El método ActualizaHistorialDeOperaciones generara un string concatenado con:
        /// i.El sistema de la calculadora.
        /// ii.Los valores de primerOperando y segundoOperando.
        /// iii.El operador.
        /// iv.Utilizar StringBuilder para lograr esto.
        /// </summary>
        public void ActualizarHistorialDeOperaciones()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Sistema: {this.Sistema.ToString()}");
            sb.AppendLine($"{this.primerOperando.ValorNumerico} + {this.segundoOperando.ValorNumerico} = {this.Resultado}");
            this.operaciones.Add(sb.ToString());
        }
        /// <summary>
        /// El método EliminarHistorialDeOperaciones limpiara la lista de operaciones.
        /// </summary>
        public void EliminarHistorialDeOperaciones()
        {
            this.operaciones.Clear();
        }
    }
}
