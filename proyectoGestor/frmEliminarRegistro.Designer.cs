
namespace proyectoGestor
{
    partial class frmEliminarRegistro
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
            this.dgvRegistros = new System.Windows.Forms.DataGridView();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombreColumna = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIdentificador = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistros)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvRegistros
            // 
            this.dgvRegistros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRegistros.Location = new System.Drawing.Point(37, 34);
            this.dgvRegistros.Name = "dgvRegistros";
            this.dgvRegistros.RowHeadersWidth = 51;
            this.dgvRegistros.RowTemplate.Height = 24;
            this.dgvRegistros.Size = new System.Drawing.Size(510, 377);
            this.dgvRegistros.TabIndex = 0;
            this.dgvRegistros.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRegistros_CellContentClick);
            // 
            // btnEliminar
            // 
            this.btnEliminar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnEliminar.Location = new System.Drawing.Point(613, 278);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(168, 54);
            this.btnEliminar.TabIndex = 1;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(613, 338);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(168, 54);
            this.btnCancelar.TabIndex = 2;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(576, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nombre columna:";
            // 
            // txtNombreColumna
            // 
            this.txtNombreColumna.Location = new System.Drawing.Point(701, 29);
            this.txtNombreColumna.Name = "txtNombreColumna";
            this.txtNombreColumna.Size = new System.Drawing.Size(145, 22);
            this.txtNombreColumna.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(606, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Identificador:";
            // 
            // txtIdentificador
            // 
            this.txtIdentificador.Location = new System.Drawing.Point(702, 64);
            this.txtIdentificador.Name = "txtIdentificador";
            this.txtIdentificador.Size = new System.Drawing.Size(144, 22);
            this.txtIdentificador.TabIndex = 6;
            // 
            // frmEliminarRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 450);
            this.Controls.Add(this.txtIdentificador);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNombreColumna);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.dgvRegistros);
            this.Name = "frmEliminarRegistro";
            this.Text = "frmEliminarRegistro";
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView dgvRegistros;
        public System.Windows.Forms.Button btnEliminar;
        public System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtNombreColumna;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtIdentificador;
    }
}