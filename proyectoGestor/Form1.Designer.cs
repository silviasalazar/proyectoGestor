﻿
namespace proyectoGestor
{
    partial class Form1
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
            this.btnCrear = new System.Windows.Forms.Button();
            this.btnUsar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.cbDB = new System.Windows.Forms.ComboBox();
            this.btnDejar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCrear
            // 
            this.btnCrear.Location = new System.Drawing.Point(24, 29);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(191, 55);
            this.btnCrear.TabIndex = 0;
            this.btnCrear.Text = "Crear base de datos";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // btnUsar
            // 
            this.btnUsar.Location = new System.Drawing.Point(24, 111);
            this.btnUsar.Name = "btnUsar";
            this.btnUsar.Size = new System.Drawing.Size(191, 55);
            this.btnUsar.TabIndex = 1;
            this.btnUsar.Text = "Usar base de datos";
            this.btnUsar.UseVisualStyleBackColor = true;
            this.btnUsar.Click += new System.EventHandler(this.btnUsar_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(24, 268);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(191, 55);
            this.btnBorrar.TabIndex = 2;
            this.btnBorrar.Text = "Borrar base de datos";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // cbDB
            // 
            this.cbDB.FormattingEnabled = true;
            this.cbDB.Location = new System.Drawing.Point(364, 60);
            this.cbDB.Name = "cbDB";
            this.cbDB.Size = new System.Drawing.Size(240, 24);
            this.cbDB.TabIndex = 4;
            this.cbDB.SelectedIndexChanged += new System.EventHandler(this.cbDB_SelectedIndexChanged);
            // 
            // btnDejar
            // 
            this.btnDejar.Location = new System.Drawing.Point(24, 193);
            this.btnDejar.Name = "btnDejar";
            this.btnDejar.Size = new System.Drawing.Size(191, 55);
            this.btnDejar.TabIndex = 5;
            this.btnDejar.Text = "Dejar de usar base de datos";
            this.btnDejar.UseVisualStyleBackColor = true;
            this.btnDejar.Click += new System.EventHandler(this.btnDejar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(24, 347);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(191, 55);
            this.btnModificar.TabIndex = 6;
            this.btnModificar.Text = "Modificar base de datos";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(361, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Seleccione una base de datos:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnDejar);
            this.Controls.Add(this.cbDB);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnUsar);
            this.Controls.Add(this.btnCrear);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.Button btnUsar;
        private System.Windows.Forms.Button btnBorrar;
        public System.Windows.Forms.ComboBox cbDB;
        private System.Windows.Forms.Button btnDejar;
        public System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Label label1;
    }
}

