using Entidades;
using System.Text.RegularExpressions;

namespace MiCalculadora
{
    public partial class FrmCalculadora : Form
    {
        private Calculadora calculadora;

        public FrmCalculadora()
        {
            this.calculadora = new Calculadora("Candela Bogado");
            InitializeComponent();
        }

        private void FrmCalculadora_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult confirmacionCerrar = MessageBox.Show("¿Desea cerrar la calculadora?", "Cierre", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmacionCerrar == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void FrmCalculadora_Load(object sender, EventArgs e)
        {
            //this.sistema = Numeracion.ESistema.Decimal;
            this.cmbOperacion.DataSource = new char[] { '+', '-', '*', '/' };
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.calculadora.EliminarHistorialDeOperaciones();
            this.txtPrimerOperando.Text = string.Empty;
            this.txtSegundoOperando.Text = string.Empty;
            this.lblResultado.Text = $"Resultado:";
            this.MostrarHistorial();
        }
        private void btnOperar_Click(object sender, EventArgs e)
        {
            char operador;
            calculadora.PrimerOperando =
            this.GetOperador(this.txtPrimerOperando.Text);
            calculadora.SegundoOperando =
            this.GetOperador(this.txtSegundoOperando.Text);
            operador = (char)this.cmbOperacion.SelectedItem;
            this.calculadora.Calcular(operador);
            this.calculadora.ActualizaHistorialDeOperaciones(operador)
            ;
            this.lblResultado.Text = $"Resultado: { calculadora.Resultado.Valor}";
            this.MostrarHistorial();
        }

        private void MostrarHistorial()
        {
            this.lstHistorial.DataSource = null;
            this.lstHistorial.DataSource =
            this.calculadora.Operaciones;
        }

        private void TxtPrimerOperador_TextChanged(object sender, EventArgs e)
        {
            //this.primerOperando = new Numeracion(this.txtPrimerOperador.Text, Numeracion.ESistema.Decimal);
        }
        private void TxtSegundoOperador_TextChanged(object sender, EventArgs e)
        {
            //this.segundoOperando = new Numeracion(this.txtSegundoOperador.Text, Numeracion.ESistema.Decimal);
        }
        private void RdbDecimal_CheckedChanged(object sender, EventArgs e)
        {
            Calculadora.Sistema = ESistema.Decimal;
        }
        private void RdbBinario_CheckedChanged(object sender, EventArgs e)
        {
            Calculadora.Sistema = ESistema.Binario;
        }
        
        private Numeracion GetOperando()
        {
            if (Calculadora.Sistema == ESistema.Binario)
            {
                return new SistemaBinario(value);
            }
            return new SistemaDecimal(value);
        }
    }
}