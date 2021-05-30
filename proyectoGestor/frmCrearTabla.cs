using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyectoGestor
{

    public partial class frmCrearTabla : Form
    {
        string bd = null;
        MySqlConnection connection;
        public frmCrearTabla(string bd)
        {
            InitializeComponent();
            string tipoDato = comboBox1.Text;
            comboBox1.Items.Add("INT");
            comboBox1.Items.Add("TINYINT");
            comboBox1.Items.Add("SMALLINT");
            comboBox1.Items.Add("VARCHAR");
            comboBox1.Items.Add("CHAR");
            comboBox1.Items.Add("DATE");
            this.bd = bd;
            connection = new MySqlConnection("Server=localhost;Database=" + bd + ";UserId=root;PWD=Unicornio123;");

            if (tipoDato == "INT" | tipoDato == "TINYINT" | tipoDato == "SMALLINT")
            {
                txtLongitud.ReadOnly = true;
            }
            //connection.Open();


        }
        public void verificarTipo()
        {

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAgregarCampos_Click(object sender, EventArgs e)
        {
            
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                string nombreTabla = txtNombreTabla.Text;
                string nombreCampo = txtNombreCampo.Text;
                string tipoDato = comboBox1.Text;
                string longitud = txtLongitud.Text;
                //string longitud = cbLongitud.Text;


                if (tipoDato == "VARCHAR" | tipoDato == "CHAR")
                {

                    connection.Open();
                    MySqlCommand command = new MySqlCommand("create table " + nombreTabla + "( " + nombreCampo + " " + tipoDato + " (" + longitud + "));", connection);
                    command.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show(this, "Tabla creada exitosamente");

                }
                else if (tipoDato == "INT" | tipoDato == "TINYINT" | tipoDato == "SMALLINT")
                {
                    txtLongitud.ReadOnly = true; 
                    connection.Open();
                    MySqlCommand command = new MySqlCommand("create table " + nombreTabla + "( " + nombreCampo + " " + tipoDato + ");", connection);
                    command.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show(this, "Tabla creada exitosamente");

                }
                




            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo crear la tabla");
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            string tipoDato = comboBox1.Text;

           
        }

        private void cbLongitud_SelectedIndexChanged(object sender, EventArgs e)
        {
            string longitud = cbLongitud.Text;
        }
    }
}
