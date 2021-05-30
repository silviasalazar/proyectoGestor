
namespace proyectoGestor
{
    partial class frmAgregarCampos
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
            this.txtNombreCampo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLongitud = new System.Windows.Forms.TextBox();
            this.btnAceptarCampo = new System.Windows.Forms.Button();
            this.btnAgregarOtro = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre: ";
            // 
            // txtNombreCampo
            // 
            this.txtNombreCampo.Location = new System.Drawing.Point(129, 24);
            this.txtNombreCampo.Name = "txtNombreCampo";
            this.txtNombreCampo.Size = new System.Drawing.Size(178, 22);
            this.txtNombreCampo.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tipo:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(129, 69);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(178, 24);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Longitud:";
            // 
            // txtLongitud
            // 
            this.txtLongitud.Location = new System.Drawing.Point(129, 116);
            this.txtLongitud.Name = "txtLongitud";
            this.txtLongitud.Size = new System.Drawing.Size(178, 22);
            this.txtLongitud.TabIndex = 5;
            // 
            // btnAceptarCampo
            // 
            this.btnAceptarCampo.Location = new System.Drawing.Point(408, 20);
            this.btnAceptarCampo.Name = "btnAceptarCampo";
            this.btnAceptarCampo.Size = new System.Drawing.Size(126, 42);
            this.btnAceptarCampo.TabIndex = 6;
            this.btnAceptarCampo.Text = "Aceptar";
            this.btnAceptarCampo.UseVisualStyleBackColor = true;
            this.btnAceptarCampo.Click += new System.EventHandler(this.btnAceptarCampo_Click);
            // 
            // btnAgregarOtro
            // 
            this.btnAgregarOtro.Location = new System.Drawing.Point(408, 69);
            this.btnAgregarOtro.Name = "btnAgregarOtro";
            this.btnAgregarOtro.Size = new System.Drawing.Size(126, 46);
            this.btnAgregarOtro.TabIndex = 7;
            this.btnAgregarOtro.Text = "Agregar otro campo";
            this.btnAgregarOtro.UseVisualStyleBackColor = true;
            this.btnAgregarOtro.Click += new System.EventHandler(this.btnAgregarOtro_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(408, 122);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(126, 42);
            this.btnSalir.TabIndex = 8;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // frmAgregarCampos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 202);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnAgregarOtro);
            this.Controls.Add(this.btnAceptarCampo);
            this.Controls.Add(this.txtLongitud);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNombreCampo);
            this.Controls.Add(this.label1);
            this.Name = "frmAgregarCampos";
            this.Text = "frmAgregarCampos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Button btnAgregarOtro;
        public System.Windows.Forms.Button btnSalir;
        public System.Windows.Forms.TextBox txtNombreCampo;
        public System.Windows.Forms.ComboBox comboBox1;
        public System.Windows.Forms.Button btnAceptarCampo;
        public System.Windows.Forms.TextBox txtLongitud;
    }
}