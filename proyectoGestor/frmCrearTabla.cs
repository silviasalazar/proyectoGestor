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
            
           
            comboBox1.Items.Add("INT");
            comboBox1.Items.Add("TINYINT");
            comboBox1.Items.Add("SMALLINT");
            comboBox1.Items.Add("VARCHAR");
            comboBox1.Items.Add("CHAR");
            //comboBox1.Items.Add("DATE");
            cbLongitud.Items.Add("10");
            cbLongitud.Items.Add("15");
            cbLongitud.Items.Add("20");
            cbLongitud.Items.Add("25");
            cbLongitud.Items.Add("30");
            cbLongitud.Items.Add("50");
            cbLongitud.Items.Add("100");

            this.bd = bd;
            connection = new MySqlConnection("Server=localhost;Database=" + bd + ";UserId=root;PWD=Unicornio123;");

           





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
            txtNombreCampo.Clear();
            comboBox1.ResetText();
            cbLongitud.ResetText();

        }
       
        private void btnAceptar_Click(object sender, EventArgs e)
        {
         
           
         
            
                try
                {
                string nombreTabla = txtNombreTabla.Text;
                string nombreCampo = txtNombreCampo.Text;
                string tipoDato = comboBox1.Text;
                string longitud = cbLongitud.Text;

                        if (tipoDato == "VARCHAR" | tipoDato == "CHAR")
                        {
                            
                                 connection.Open();
                                MySqlCommand command = new MySqlCommand("create table " + nombreTabla + "( " + nombreCampo + " " + tipoDato + " (" + longitud + "));", connection);
                                command.ExecuteNonQuery();
                                connection.Close();
                                MessageBox.Show(this, "Tabla creada exitosamente");
                                txtNombreCampo.Clear();
                                comboBox1.ResetText();
                                cbLongitud.ResetText();
                                

                        }
                        else if (tipoDato == "INT" | tipoDato == "TINYINT" | tipoDato == "SMALLINT" | tipoDato == "DATE")
                        {

                            connection.Open();
                            MySqlCommand command = new MySqlCommand("create table " + nombreTabla + "( " + nombreCampo + " " + tipoDato + ");", connection);
                            command.ExecuteNonQuery();
                            connection.Close();
                            MessageBox.Show(this, "Tabla creada exitosamente");
                            txtNombreCampo.Clear();
                            comboBox1.ResetText();
                            cbLongitud.ResetText();

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
            /* if(comboBox1.Text=="INT")
             {
                 cbLongitud.Enabled = false;
             }*/

            if (tipoDato == "VARCHAR" | tipoDato == "CHAR")
            {

                cbLongitud.Enabled = true;


            }
            else if (tipoDato == "INT" | tipoDato == "TINYINT" | tipoDato == "SMALLINT")
            {

                cbLongitud.Enabled = false;

            }


        }

        private void cbLongitud_SelectedIndexChanged(object sender, EventArgs e)
        {
            string longitud = cbLongitud.Text;
            //cbLongitud.Enabled = (comboBox1.Text=="INT");
            
        }

        private void comboBox1_Click(object sender, EventArgs e)
        {
            

        }

        private void btnGuardarNuevoCampo_Click(object sender, EventArgs e)
        {
            try
            {
                string nombreTabla = txtNombreTabla.Text;
                string nombreCampo = txtNombreCampo.Text;
                string tipoDato = comboBox1.Text;
                string longitud = cbLongitud.Text;

                if (tipoDato == "VARCHAR" | tipoDato == "CHAR")
                {

                    connection.Open();
                    MySqlCommand command = new MySqlCommand("alter table " + nombreTabla + " add " + nombreCampo + " " + tipoDato + " (" + longitud + ");", connection);
                    command.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show(this, "campo agregado exitosamente");
                    txtNombreCampo.Clear();
                    comboBox1.ResetText();
                    cbLongitud.ResetText();

                }
                else if (tipoDato == "INT" | tipoDato == "TINYINT" | tipoDato == "SMALLINT" | tipoDato == "DATE")
                {

                    connection.Open();
                    MySqlCommand command = new MySqlCommand("alter table " + nombreTabla + " add " + nombreCampo + " " + tipoDato + ";", connection);
                    command.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show(this, "campo agregado exitosamente");
                    txtNombreCampo.Clear();
                    comboBox1.ResetText();
                    cbLongitud.ResetText();

                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo agregar campo");
            }


        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtNombreCampo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
