
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
            this.SuspendLayout();
            // 
            // btnRenombrar
            // 
            this.btnRenombrar.Location = new System.Drawing.Point(33, 35);
            this.btnRenombrar.Name = "btnRenombrar";
            this.btnRenombrar.Size = new System.Drawing.Size(167, 38);
            this.btnRenombrar.TabIndex = 0;
            this.btnRenombrar.Text = "Renombrar";
            this.btnRenombrar.UseVisualStyleBackColor = true;
            this.btnRenombrar.Click += new System.EventHandler(this.btnRenombrar_Click);
            // 
            // btnEliminarColumna
            // 
            this.btnEliminarColumna.Location = new System.Drawing.Point(33, 79);
            this.btnEliminarColumna.Name = "btnEliminarColumna";
            this.btnEliminarColumna.Size = new System.Drawing.Size(167, 40);
            this.btnEliminarColumna.TabIndex = 1;
            this.btnEliminarColumna.Text = "Eliminar columna";
            this.btnEliminarColumna.UseVisualStyleBackColor = true;
            this.btnEliminarColumna.Click += new System.EventHandler(this.btnEliminarColumna_Click);
            // 
            // btnInsertarColumna
            // 
            this.btnInsertarColumna.Location = new System.Drawing.Point(33, 125);
            this.btnInsertarColumna.Name = "btnInsertarColumna";
            this.btnInsertarColumna.Size = new System.Drawing.Size(167, 40);
            this.btnInsertarColumna.TabIndex = 2;
            this.btnInsertarColumna.Text = "Insertar columna";
            this.btnInsertarColumna.UseVisualStyleBackColor = true;
            this.btnInsertarColumna.Click += new System.EventHandler(this.btnInsertarColumna_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(333, 55);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(247, 24);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btnInsertarRegistro
            // 
            this.btnInsertarRegistro.Location = new System.Drawing.Point(33, 171);
            this.btnInsertarRegistro.Name = "btnInsertarRegistro";
            this.btnInsertarRegistro.Size = new System.Drawing.Size(167, 40);
            this.btnInsertarRegistro.TabIndex = 4;
            this.btnInsertarRegistro.Text = "Insertar registro";
            this.btnInsertarRegistro.UseVisualStyleBackColor = true;
            this.btnInsertarRegistro.Click += new System.EventHandler(this.btnInsertarRegistro_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(330, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Selecciona una tabla:";
            // 
            // btnEliminarRegistro
            // 
            this.btnEliminarRegistro.Location = new System.Drawing.Point(33, 217);
            this.btnEliminarRegistro.Name = "btnEliminarRegistro";
            this.btnEliminarRegistro.Size = new System.Drawing.Size(167, 40);
            this.btnEliminarRegistro.TabIndex = 6;
            this.btnEliminarRegistro.Text = "Eliminar registro";
            this.btnEliminarRegistro.UseVisualStyleBackColor = true;
            this.btnEliminarRegistro.Click += new System.EventHandler(this.btnEliminarRegistro_Click);
            // 
            // frmModificarTabla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 301);
            this.Controls.Add(this.btnEliminarRegistro);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnInsertarRegistro);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnInsertarColumna);
            this.Controls.Add(this.btnEliminarColumna);
            this.Controls.Add(this.btnRenombrar);
            this.Name = "frmModificarTabla";
            this.Text = "frmModificarTabla";
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
    }
}