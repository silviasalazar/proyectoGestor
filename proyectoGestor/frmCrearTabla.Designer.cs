
namespace proyectoGestor
{
    partial class frmCrearTabla
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombreTabla = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAgregarCampos = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNombreCampo = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.cbLongitud = new System.Windows.Forms.ComboBox();
            this.btnGuardarNuevoCampo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre de tabla: ";
            // 
            // txtNombreTabla
            // 
            this.txtNombreTabla.Location = new System.Drawing.Point(171, 20);
            this.txtNombreTabla.Name = "txtNombreTabla";
            this.txtNombreTabla.Size = new System.Drawing.Size(311, 22);
            this.txtNombreTabla.TabIndex = 1;
            this.txtNombreTabla.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAceptar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAceptar.Location = new System.Drawing.Point(501, 20);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(183, 49);
            this.btnAceptar.TabIndex = 2;
            this.btnAceptar.Text = "Crear";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(504, 190);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(183, 45);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Salir";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAgregarCampos
            // 
            this.btnAgregarCampos.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAgregarCampos.Location = new System.Drawing.Point(503, 75);
            this.btnAgregarCampos.Name = "btnAgregarCampos";
            this.btnAgregarCampos.Size = new System.Drawing.Size(182, 52);
            this.btnAgregarCampos.TabIndex = 5;
            this.btnAgregarCampos.Text = "Agregar otro campo";
            this.btnAgregarCampos.UseVisualStyleBackColor = false;
            this.btnAgregarCampos.Click += new System.EventHandler(this.btnAgregarCampos_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nombre campo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(107, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Tipo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(76, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Longitud:";
            // 
            // txtNombreCampo
            // 
            this.txtNombreCampo.Location = new System.Drawing.Point(171, 75);
            this.txtNombreCampo.Name = "txtNombreCampo";
            this.txtNombreCampo.Size = new System.Drawing.Size(311, 22);
            this.txtNombreCampo.TabIndex = 9;
            this.txtNombreCampo.TextChanged += new System.EventHandler(this.txtNombreCampo_TextChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(171, 113);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(311, 24);
            this.comboBox1.TabIndex = 10;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.comboBox1.Click += new System.EventHandler(this.comboBox1_Click);
            // 
            // cbLongitud
            // 
            this.cbLongitud.FormattingEnabled = true;
            this.cbLongitud.Location = new System.Drawing.Point(171, 160);
            this.cbLongitud.Name = "cbLongitud";
            this.cbLongitud.Size = new System.Drawing.Size(136, 24);
            this.cbLongitud.TabIndex = 12;
            this.cbLongitud.SelectedIndexChanged += new System.EventHandler(this.cbLongitud_SelectedIndexChanged);
            // 
            // btnGuardarNuevoCampo
            // 
            this.btnGuardarNuevoCampo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnGuardarNuevoCampo.Location = new System.Drawing.Point(504, 133);
            this.btnGuardarNuevoCampo.Name = "btnGuardarNuevoCampo";
            this.btnGuardarNuevoCampo.Size = new System.Drawing.Size(182, 51);
            this.btnGuardarNuevoCampo.TabIndex = 13;
            this.btnGuardarNuevoCampo.Text = "Guardar nuevo campo";
            this.btnGuardarNuevoCampo.UseVisualStyleBackColor = false;
            this.btnGuardarNuevoCampo.Click += new System.EventHandler(this.btnGuardarNuevoCampo_Click);
            // 
            // frmCrearTabla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(696, 292);
            this.Controls.Add(this.btnGuardarNuevoCampo);
            this.Controls.Add(this.cbLongitud);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.txtNombreCampo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAgregarCampos);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txtNombreTabla);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmCrearTabla";
            this.Text = "frmCrearTabla";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtNombreTabla;
        public System.Windows.Forms.Button btnAceptar;
        public System.Windows.Forms.Button btnCancelar;
        public System.Windows.Forms.Button btnAgregarCampos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txtNombreCampo;
        private System.Windows.Forms.ComboBox comboBox1;
        public System.Windows.Forms.ComboBox cbLongitud;
        public System.Windows.Forms.Button btnGuardarNuevoCampo;
    }
}