
namespace proyectoGestor
{
    partial class frmModificarTabla
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
            this.btnRenombrar = new System.Windows.Forms.Button();
            this.btnEliminarColumna = new System.Windows.Forms.Button();
            this.btnInsertarColumna = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnInsertarRegistro = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEliminarRegistro = new System.Windows.Forms.Button();
            this.btnActulizarRegistro = new System.Windows.Forms.Button();
            this.btnMostrarPor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRenombrar
            // 
            this.btnRenombrar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnRenombrar.Location = new System.Drawing.Point(484, 53);
            this.btnRenombrar.Name = "btnRenombrar";
            this.btnRenombrar.Size = new System.Drawing.Size(188, 38);
            this.btnRenombrar.TabIndex = 0;
            this.btnRenombrar.Text = "Renombrar";
            this.btnRenombrar.UseVisualStyleBackColor = false;
            this.btnRenombrar.Click += new System.EventHandler(this.btnRenombrar_Click);
            // 
            // btnEliminarColumna
            // 
            this.btnEliminarColumna.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnEliminarColumna.Location = new System.Drawing.Point(484, 97);
            this.btnEliminarColumna.Name = "btnEliminarColumna";
            this.btnEliminarColumna.Size = new System.Drawing.Size(188, 40);
            this.btnEliminarColumna.TabIndex = 1;
            this.btnEliminarColumna.Text = "Eliminar columna";
            this.btnEliminarColumna.UseVisualStyleBackColor = false;
            this.btnEliminarColumna.Click += new System.EventHandler(this.btnEliminarColumna_Click);
            // 
            // btnInsertarColumna
            // 
            this.btnInsertarColumna.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnInsertarColumna.Location = new System.Drawing.Point(484, 143);
            this.btnInsertarColumna.Name = "btnInsertarColumna";
            this.btnInsertarColumna.Size = new System.Drawing.Size(188, 40);
            this.btnInsertarColumna.TabIndex = 2;
            this.btnInsertarColumna.Text = "Insertar columna";
            this.btnInsertarColumna.UseVisualStyleBackColor = false;
            this.btnInsertarColumna.Click += new System.EventHandler(this.btnInsertarColumna_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(37, 53);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(277, 24);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btnInsertarRegistro
            // 
            this.btnInsertarRegistro.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnInsertarRegistro.Location = new System.Drawing.Point(484, 189);
            this.btnInsertarRegistro.Name = "btnInsertarRegistro";
            this.btnInsertarRegistro.Size = new System.Drawing.Size(188, 40);
            this.btnInsertarRegistro.TabIndex = 4;
            this.btnInsertarRegistro.Text = "Insertar registro";
            this.btnInsertarRegistro.UseVisualStyleBackColor = false;
            this.btnInsertarRegistro.Click += new System.EventHandler(this.btnInsertarRegistro_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Selecciona una tabla:";
            // 
            // btnEliminarRegistro
            // 
            this.btnEliminarRegistro.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnEliminarRegistro.Location = new System.Drawing.Point(484, 235);
            this.btnEliminarRegistro.Name = "btnEliminarRegistro";
            this.btnEliminarRegistro.Size = new System.Drawing.Size(188, 40);
            this.btnEliminarRegistro.TabIndex = 6;
            this.btnEliminarRegistro.Text = "Eliminar registro";
            this.btnEliminarRegistro.UseVisualStyleBackColor = false;
            this.btnEliminarRegistro.Click += new System.EventHandler(this.btnEliminarRegistro_Click);
            // 
            // btnActulizarRegistro
            // 
            this.btnActulizarRegistro.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnActulizarRegistro.Location = new System.Drawing.Point(484, 281);
            this.btnActulizarRegistro.Name = "btnActulizarRegistro";
            this.btnActulizarRegistro.Size = new System.Drawing.Size(188, 40);
            this.btnActulizarRegistro.TabIndex = 7;
            this.btnActulizarRegistro.Text = "Actualizar registro";
            this.btnActulizarRegistro.UseVisualStyleBackColor = false;
            this.btnActulizarRegistro.Click += new System.EventHandler(this.btnActulizarRegistro_Click);
            // 
            // btnMostrarPor
            // 
            this.btnMostrarPor.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnMostrarPor.Location = new System.Drawing.Point(484, 327);
            this.btnMostrarPor.Name = "btnMostrarPor";
            this.btnMostrarPor.Size = new System.Drawing.Size(188, 40);
            this.btnMostrarPor.TabIndex = 8;
            this.btnMostrarPor.Text = "Listar por ...";
            this.btnMostrarPor.UseVisualStyleBackColor = false;
            this.btnMostrarPor.Click += new System.EventHandler(this.btnMostrarPor_Click);
            // 
            // frmModificarTabla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(718, 405);
            this.Controls.Add(this.btnMostrarPor);
            this.Controls.Add(this.btnActulizarRegistro);
            this.Controls.Add(this.btnEliminarRegistro);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnInsertarRegistro);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnInsertarColumna);
            this.Controls.Add(this.btnEliminarColumna);
            this.Controls.Add(this.btnRenombrar);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmModificarTabla";
            this.Text = "Modificar tabla";
            this.Load += new System.EventHandler(this.frmModificarTabla_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnInsertarColumna;
        public System.Windows.Forms.Button btnRenombrar;
        public System.Windows.Forms.Button btnEliminarColumna;
        private System.Windows.Forms.ComboBox comboBox1;
        public System.Windows.Forms.Button btnInsertarRegistro;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button btnEliminarRegistro;
        public System.Windows.Forms.Button btnActulizarRegistro;
        public System.Windows.Forms.Button btnMostrarPor;
    }
}