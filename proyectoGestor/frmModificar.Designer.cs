
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
            this.btnInsertarRegistros = new System.Windows.Forms.Button();
            this.btnBorrarRegistros = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCrearTabla
            // 
            this.btnCrearTabla.Location = new System.Drawing.Point(37, 30);
            this.btnCrearTabla.Name = "btnCrearTabla";
            this.btnCrearTabla.Size = new System.Drawing.Size(177, 51);
            this.btnCrearTabla.TabIndex = 0;
            this.btnCrearTabla.Text = "Crear tabla";
            this.btnCrearTabla.UseVisualStyleBackColor = true;
            this.btnCrearTabla.Click += new System.EventHandler(this.btnCrearTabla_Click);
            // 
            // btnBorrarTabla
            // 
            this.btnBorrarTabla.Location = new System.Drawing.Point(37, 101);
            this.btnBorrarTabla.Name = "btnBorrarTabla";
            this.btnBorrarTabla.Size = new System.Drawing.Size(177, 51);
            this.btnBorrarTabla.TabIndex = 1;
            this.btnBorrarTabla.Text = "Borrar tabla";
            this.btnBorrarTabla.UseVisualStyleBackColor = true;
            this.btnBorrarTabla.Click += new System.EventHandler(this.btnBorrarTabla_Click);
            // 
            // btnModificarTabla
            // 
            this.btnModificarTabla.Location = new System.Drawing.Point(37, 171);
            this.btnModificarTabla.Name = "btnModificarTabla";
            this.btnModificarTabla.Size = new System.Drawing.Size(177, 51);
            this.btnModificarTabla.TabIndex = 2;
            this.btnModificarTabla.Text = "Modificar tabla";
            this.btnModificarTabla.UseVisualStyleBackColor = true;
            // 
            // btnInsertarRegistros
            // 
            this.btnInsertarRegistros.Location = new System.Drawing.Point(37, 243);
            this.btnInsertarRegistros.Name = "btnInsertarRegistros";
            this.btnInsertarRegistros.Size = new System.Drawing.Size(177, 51);
            this.btnInsertarRegistros.TabIndex = 3;
            this.btnInsertarRegistros.Text = "Insertar registros";
            this.btnInsertarRegistros.UseVisualStyleBackColor = true;
            this.btnInsertarRegistros.Click += new System.EventHandler(this.btnInsertarRegistros_Click);
            // 
            // btnBorrarRegistros
            // 
            this.btnBorrarRegistros.Location = new System.Drawing.Point(37, 313);
            this.btnBorrarRegistros.Name = "btnBorrarRegistros";
            this.btnBorrarRegistros.Size = new System.Drawing.Size(177, 51);
            this.btnBorrarRegistros.TabIndex = 4;
            this.btnBorrarRegistros.Text = "Borrar registros";
            this.btnBorrarRegistros.UseVisualStyleBackColor = true;
            // 
            // frmModificar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBorrarRegistros);
            this.Controls.Add(this.btnInsertarRegistros);
            this.Controls.Add(this.btnModificarTabla);
            this.Controls.Add(this.btnBorrarTabla);
            this.Controls.Add(this.btnCrearTabla);
            this.Name = "frmModificar";
            this.Text = "frmModificar";
            this.Load += new System.EventHandler(this.frmModificar_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCrearTabla;
        private System.Windows.Forms.Button btnBorrarTabla;
        private System.Windows.Forms.Button btnModificarTabla;
        private System.Windows.Forms.Button btnInsertarRegistros;
        private System.Windows.Forms.Button btnBorrarRegistros;
    }
}