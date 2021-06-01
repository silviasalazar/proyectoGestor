
namespace proyectoGestor
{
    partial class frmListarPorcs
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
            this.cbListar = new System.Windows.Forms.ComboBox();
            this.dgvListarPor = new System.Windows.Forms.DataGridView();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cbCondicion = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCondicion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListarPor)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(417, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seleccione la columna por la cual desee su información:";
            // 
            // cbListar
            // 
            this.cbListar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbListar.FormattingEnabled = true;
            this.cbListar.Location = new System.Drawing.Point(428, 31);
            this.cbListar.Name = "cbListar";
            this.cbListar.Size = new System.Drawing.Size(236, 24);
            this.cbListar.TabIndex = 1;
            this.cbListar.SelectedIndexChanged += new System.EventHandler(this.cbListar_SelectedIndexChanged);
            // 
            // dgvListarPor
            // 
            this.dgvListarPor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListarPor.Location = new System.Drawing.Point(14, 180);
            this.dgvListarPor.Name = "dgvListarPor";
            this.dgvListarPor.RowHeadersWidth = 51;
            this.dgvListarPor.RowTemplate.Height = 24;
            this.dgvListarPor.Size = new System.Drawing.Size(647, 314);
            this.dgvListarPor.TabIndex = 2;
            this.dgvListarPor.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListarPor_CellContentClick);
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAceptar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAceptar.Location = new System.Drawing.Point(691, 262);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(166, 52);
            this.btnAceptar.TabIndex = 3;
            this.btnAceptar.Text = "Listar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(691, 335);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(166, 52);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "Salir";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Condición:";
            // 
            // cbCondicion
            // 
            this.cbCondicion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCondicion.FormattingEnabled = true;
            this.cbCondicion.Location = new System.Drawing.Point(107, 92);
            this.cbCondicion.Name = "cbCondicion";
            this.cbCondicion.Size = new System.Drawing.Size(136, 24);
            this.cbCondicion.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(296, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "a:";
            // 
            // txtCondicion
            // 
            this.txtCondicion.Location = new System.Drawing.Point(325, 92);
            this.txtCondicion.Name = "txtCondicion";
            this.txtCondicion.Size = new System.Drawing.Size(426, 22);
            this.txtCondicion.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(322, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(440, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "NOTA: Recuenda que si es un dato de tipo cadena lleva \'  \'";
            // 
            // frmListarPorcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(871, 506);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCondicion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbCondicion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.dgvListarPor);
            this.Controls.Add(this.cbListar);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmListarPorcs";
            this.Text = "Listar por condiciones";
            this.Load += new System.EventHandler(this.frmListarPorcs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListarPor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox cbListar;
        public System.Windows.Forms.DataGridView dgvListarPor;
        public System.Windows.Forms.Button btnAceptar;
        public System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.ComboBox cbCondicion;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txtCondicion;
        private System.Windows.Forms.Label label4;
    }
}