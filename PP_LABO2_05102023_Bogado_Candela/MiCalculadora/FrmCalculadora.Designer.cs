namespace MiCalculadora
{
    partial class FrmCalculadora
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ComboBox cmbOperacion;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCalculadora));
            grpSistema = new GroupBox();
            rdbBinario = new RadioButton();
            rdbDecimal = new RadioButton();
            lblResultado = new Label();
            lblPrimerOperando = new Label();
            lblOperacion = new Label();
            lblSegundoOperando = new Label();
            txtPrimerOperando = new TextBox();
            txtSegundoOperando = new TextBox();
            btnOperar = new Button();
            btnLimpiar = new Button();
            btnCerrar = new Button();
            lblHistorial = new Label();
            lstHistorial = new ListBox();
            cmbOperacion = new ComboBox();
            grpSistema.SuspendLayout();
            SuspendLayout();
            // 
            // cmbOperacion
            // 
            cmbOperacion.Cursor = Cursors.Hand;
            cmbOperacion.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbOperacion.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            cmbOperacion.FormattingEnabled = true;
            cmbOperacion.Items.AddRange(new object[] { "    +", "    -", "    *", "    /" });
            cmbOperacion.Location = new Point(575, 549);
            cmbOperacion.Name = "cmbOperacion";
            cmbOperacion.Size = new Size(138, 62);
            cmbOperacion.TabIndex = 4;
            // 
            // grpSistema
            // 
            grpSistema.Controls.Add(rdbBinario);
            grpSistema.Controls.Add(rdbDecimal);
            grpSistema.Cursor = Cursors.Hand;
            grpSistema.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            grpSistema.ForeColor = SystemColors.WindowText;
            grpSistema.Location = new Point(399, 251);
            grpSistema.Name = "grpSistema";
            grpSistema.Size = new Size(500, 150);
            grpSistema.TabIndex = 2;
            grpSistema.TabStop = false;
            grpSistema.Text = "Representar resultado en:";
            // 
            // rdbBinario
            // 
            rdbBinario.AutoSize = true;
            rdbBinario.Location = new Point(292, 75);
            rdbBinario.Name = "rdbBinario";
            rdbBinario.Size = new Size(113, 36);
            rdbBinario.TabIndex = 1;
            rdbBinario.Text = "Binario";
            rdbBinario.UseVisualStyleBackColor = true;
            rdbBinario.CheckedChanged += RdbBinario_CheckedChanged;
            // 
            // rdbDecimal
            // 
            rdbDecimal.AutoSize = true;
            rdbDecimal.Checked = true;
            rdbDecimal.Location = new Point(67, 75);
            rdbDecimal.Name = "rdbDecimal";
            rdbDecimal.Size = new Size(125, 36);
            rdbDecimal.TabIndex = 0;
            rdbDecimal.TabStop = true;
            rdbDecimal.Text = "Decimal";
            rdbDecimal.UseVisualStyleBackColor = true;
            rdbDecimal.CheckedChanged += RdbDecimal_CheckedChanged;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Font = new Font("Segoe UI Semibold", 36F, FontStyle.Bold, GraphicsUnit.Point);
            lblResultado.Location = new Point(32, 25);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(380, 96);
            lblResultado.TabIndex = 1;
            lblResultado.Text = "Resultado:";
            // 
            // lblPrimerOperando
            // 
            lblPrimerOperando.AutoSize = true;
            lblPrimerOperando.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold, GraphicsUnit.Point);
            lblPrimerOperando.Location = new Point(63, 475);
            lblPrimerOperando.Name = "lblPrimerOperando";
            lblPrimerOperando.Size = new Size(339, 54);
            lblPrimerOperando.TabIndex = 7;
            lblPrimerOperando.Text = "Primer Operador:";
            // 
            // lblOperacion
            // 
            lblOperacion.AutoSize = true;
            lblOperacion.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold, GraphicsUnit.Point);
            lblOperacion.Location = new Point(535, 475);
            lblOperacion.Name = "lblOperacion";
            lblOperacion.Size = new Size(220, 54);
            lblOperacion.TabIndex = 8;
            lblOperacion.Text = "Operación:";
            // 
            // lblSegundoOperando
            // 
            lblSegundoOperando.AutoSize = true;
            lblSegundoOperando.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold, GraphicsUnit.Point);
            lblSegundoOperando.Location = new Point(869, 475);
            lblSegundoOperando.Name = "lblSegundoOperando";
            lblSegundoOperando.Size = new Size(381, 54);
            lblSegundoOperando.TabIndex = 9;
            lblSegundoOperando.Text = "Segundo Operador:";
            // 
            // txtPrimerOperando
            // 
            txtPrimerOperando.BackColor = SystemColors.ButtonFace;
            txtPrimerOperando.BorderStyle = BorderStyle.FixedSingle;
            txtPrimerOperando.Cursor = Cursors.Hand;
            txtPrimerOperando.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold, GraphicsUnit.Point);
            txtPrimerOperando.ForeColor = SystemColors.WindowText;
            txtPrimerOperando.Location = new Point(58, 549);
            txtPrimerOperando.Name = "txtPrimerOperando";
            txtPrimerOperando.PlaceholderText = "0";
            txtPrimerOperando.Size = new Size(344, 61);
            txtPrimerOperando.TabIndex = 3;
            txtPrimerOperando.TextAlign = HorizontalAlignment.Center;
            txtPrimerOperando.TextChanged += TxtPrimerOperador_TextChanged;
            // 
            // txtSegundoOperando
            // 
            txtSegundoOperando.BackColor = SystemColors.ButtonFace;
            txtSegundoOperando.BorderStyle = BorderStyle.FixedSingle;
            txtSegundoOperando.Cursor = Cursors.Hand;
            txtSegundoOperando.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold, GraphicsUnit.Point);
            txtSegundoOperando.ForeColor = SystemColors.WindowText;
            txtSegundoOperando.Location = new Point(882, 548);
            txtSegundoOperando.Name = "txtSegundoOperando";
            txtSegundoOperando.PlaceholderText = "0";
            txtSegundoOperando.Size = new Size(344, 61);
            txtSegundoOperando.TabIndex = 5;
            txtSegundoOperando.TextAlign = HorizontalAlignment.Center;
            txtSegundoOperando.TextChanged += TxtSegundoOperador_TextChanged;
            // 
            // btnOperar
            // 
            btnOperar.Cursor = Cursors.Hand;
            btnOperar.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            btnOperar.Location = new Point(45, 725);
            btnOperar.Name = "btnOperar";
            btnOperar.Size = new Size(367, 76);
            btnOperar.TabIndex = 6;
            btnOperar.Text = "Operar";
            btnOperar.UseVisualStyleBackColor = true;
            btnOperar.Click += BtnOperar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Cursor = Cursors.Hand;
            btnLimpiar.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            btnLimpiar.Location = new Point(457, 725);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(367, 76);
            btnLimpiar.TabIndex = 7;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += BtnLimpiar_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.Cursor = Cursors.Hand;
            btnCerrar.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            btnCerrar.Location = new Point(869, 725);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(367, 76);
            btnCerrar.TabIndex = 8;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += BtnCerrar_Click;
            // 
            // lblHistorial
            // 
            lblHistorial.AutoSize = true;
            lblHistorial.Font = new Font("Segoe UI Semibold", 36F, FontStyle.Bold, GraphicsUnit.Point);
            lblHistorial.Location = new Point(1287, 25);
            lblHistorial.Name = "lblHistorial";
            lblHistorial.Size = new Size(332, 96);
            lblHistorial.TabIndex = 10;
            lblHistorial.Text = "Historial:";
            // 
            // lstHistorial
            // 
            lstHistorial.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lstHistorial.FormattingEnabled = true;
            lstHistorial.ItemHeight = 38;
            lstHistorial.Location = new Point(1287, 141);
            lstHistorial.Name = "lstHistorial";
            lstHistorial.Size = new Size(629, 650);
            lstHistorial.TabIndex = 11;
            // 
            // FrmCalculadora
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(1952, 832);
            Controls.Add(lstHistorial);
            Controls.Add(lblHistorial);
            Controls.Add(btnCerrar);
            Controls.Add(btnLimpiar);
            Controls.Add(btnOperar);
            Controls.Add(cmbOperacion);
            Controls.Add(txtSegundoOperando);
            Controls.Add(lblSegundoOperando);
            Controls.Add(lblOperacion);
            Controls.Add(lblPrimerOperando);
            Controls.Add(lblResultado);
            Controls.Add(txtPrimerOperando);
            Controls.Add(grpSistema);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmCalculadora";
            Padding = new Padding(5);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculadora de Candela Bogado";
            FormClosing += FrmCalculadora_FormClosing;
            grpSistema.ResumeLayout(false);
            grpSistema.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnCerrar;
        private Button btnLimpiar;
        private Button btnOperar;
        private ComboBox cmbOperacion;
        private GroupBox grpSistema;
        private Label lblOperacion;
        private Label lblPrimerOperando;
        private Label lblResultado;
        private Label lblSegundoOperando;
        private RadioButton rdbBinario;
        private RadioButton rdbDecimal;
        private TextBox txtPrimerOperando;
        private TextBox txtSegundoOperando;
        private Label lblHistorial;
        private ListBox lstHistorial;
    }
}