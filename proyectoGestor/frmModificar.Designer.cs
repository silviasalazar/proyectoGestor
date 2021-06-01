
namespace proyectoGestor
{
    partial class frmModificar
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
            this.btnCrearTabla = new System.Windows.Forms.Button();
            this.btnBorrarTabla = new System.Windows.Forms.Button();
            this.btnModificarTabla = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCrearTabla
            // 
            this.btnCrearTabla.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCrearTabla.Location = new System.Drawing.Point(42, 78);
            this.btnCrearTabla.Name = "btnCrearTabla";
            this.btnCrearTabla.Size = new System.Drawing.Size(199, 51);
            this.btnCrearTabla.TabIndex = 0;
            this.btnCrearTabla.Text = "Crear tabla";
            this.btnCrearTabla.UseVisualStyleBackColor = false;
            this.btnCrearTabla.Click += new System.EventHandler(this.btnCrearTabla_Click);
            // 
            // btnBorrarTabla
            // 
            this.btnBorrarTabla.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnBorrarTabla.Location = new System.Drawing.Point(42, 145);
            this.btnBorrarTabla.Name = "btnBorrarTabla";
            this.btnBorrarTabla.Size = new System.Drawing.Size(199, 51);
            this.btnBorrarTabla.TabIndex = 1;
            this.btnBorrarTabla.Text = "Borrar tabla";
            this.btnBorrarTabla.UseVisualStyleBackColor = false;
            this.btnBorrarTabla.Click += new System.EventHandler(this.btnBorrarTabla_Click);
            // 
            // btnModificarTabla
            // 
            this.btnModificarTabla.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnModificarTabla.Location = new System.Drawing.Point(315, 78);
            this.btnModificarTabla.Name = "btnModificarTabla";
            this.btnModificarTabla.Size = new System.Drawing.Size(199, 51);
            this.btnModificarTabla.TabIndex = 2;
            this.btnModificarTabla.Text = "Modificar tabla";
            this.btnModificarTabla.UseVisualStyleBackColor = false;
            this.btnModificarTabla.Click += new System.EventHandler(this.btnModificarTabla_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSalir.Location = new System.Drawing.Point(315, 145);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(199, 51);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Selecciona una opción:";
            // 
            // frmModificar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(584, 243);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnModificarTabla);
            this.Controls.Add(this.btnBorrarTabla);
            this.Controls.Add(this.btnCrearTabla);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmModificar";
            this.Text = "frmModificar";
            this.Load += new System.EventHandler(this.frmModificar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Button btnCrearTabla;
        public System.Windows.Forms.Button btnBorrarTabla;
        public System.Windows.Forms.Button btnModificarTabla;
        public System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label label1;
    }
}