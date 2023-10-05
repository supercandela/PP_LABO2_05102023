using Entidades;
using System.Text.RegularExpressions;

namespace MiCalculadora
{
    public partial class FrmCalculadora : Form
    {
        public FrmCalculadora()
        {
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
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            //this.txtPrimerOperador.Text = null;
            //this.txtSegundoOperador.Text = null;
            //this.lblResultado.Text = "Resultado: ";
            //this.cbxOperacion.SelectedValue = null;
            //this.rdbDecimal.Checked = true;
            //this.rdbBinario.Checked = false;
            //this.resultado = null;
        }
        private void BtnOperar_Click(object sender, EventArgs e)
        {
            //this.calculadora = new Operacion(this.primerOperando, this.segundoOperando);

            //string value = this.cbxOperacion.Items[this.cbxOperacion.SelectedIndex].ToString();
            //char tipoOperacion;
            //if (value == null)
            //{
            //    tipoOperacion = '+';
            //}
            //else
            //{
            //    tipoOperacion = char.Parse(value.Trim());
            //}

            //this.resultado = calculadora.Operar(tipoOperacion);
            //SetResultado();
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
            //this.sistema = Numeracion.ESistema.Decimal;
            //SetResultado();
        }
        private void RdbBinario_CheckedChanged(object sender, EventArgs e)
        {
            //this.sistema = Numeracion.ESistema.Binario;
            //SetResultado();
        }
        //private void SetResultado()
        //{
        //    //if (string.IsNullOrEmpty(this.txtPrimerOperador.Text) || string.IsNullOrEmpty(this.txtSegundoOperador.Text))
        //    //{
        //    //    return;
        //    //}
        //    ////if (!Regex.IsMatch(this.txtPrimerOperador.Text, @"^-?\d+(\.\d+)?$") || !Regex.IsMatch(this.txtSegundoOperador.Text, @"^-?\d+(\.\d+)?$"))
        //    ////{
        //    ////    return;
        //    ////}

        //    //if (this.sistema == Numeracion.ESistema.Binario)
        //    //{
        //    //    this.lblResultado.Text = $"Resultado : {this.resultado.ConvertirA(Numeracion.ESistema.Binario)}";
        //    //}
        //    //else
        //    //{
        //    //    this.lblResultado.Text = $"Resultado : {this.resultado.Valor}";
        //    //}
        //}
    }
}