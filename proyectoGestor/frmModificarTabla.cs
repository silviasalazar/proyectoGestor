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
    public partial class frmModificarTabla : Form
    {
        string seleccionada = null;
        string bd;
        MySqlConnection connection;
        public frmModificarTabla(string bd)
        {
            InitializeComponent();
            this.bd = bd;
            connection = new MySqlConnection("Server=localhost;Database=" + bd + ";UserId=root;PWD=Unicornio123;");
            connection.Open();
            MySqlDataAdapter adaptador = new MySqlDataAdapter("show tables from " + bd + ";", connection);
            //adaptador.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            comboBox1.DataSource = tabla;
            comboBox1.ValueMember = "Tables_in_" + bd;
            connection.Close();
        }

        private void frmModificarTabla_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            seleccionada = comboBox1.Text;
        }

        private void btnRenombrar_Click(object sender, EventArgs e)
        {
            frmRenombrar renombrar = new frmRenombrar();


            try
            {

                if (renombrar.ShowDialog() == DialogResult.OK)
                {
                    string nombreNuevo = renombrar.txtNuevoNombre.Text;

                    connection.Open();
                    MySqlCommand command = new MySqlCommand("ALTER TABLE " + seleccionada +" RENAME " + nombreNuevo +";", connection);
                    command.ExecuteNonQuery();
                    MySqlDataAdapter adaptador = new MySqlDataAdapter("show tables from " + bd + ";", connection);
                    //adaptador.SelectCommand = comando;
                    DataTable tabla = new DataTable();
                    adaptador.Fill(tabla);
                    comboBox1.DataSource = tabla;
                    comboBox1.ValueMember = "Tables_in_" + bd;
                    connection.Close();
                    MessageBox.Show(this, "Nombre de tabla cambiado exitosamente");

                }
                else if (renombrar.ShowDialog() == DialogResult.Cancel)
                {
                    renombrar.Close();

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error!!!");
            }


        }

        private void btnInsertarColumna_Click(object sender, EventArgs e)
        {
            frmInsertarColumna insertarColumna = new frmInsertarColumna();


            try
            {

                if (insertarColumna.ShowDialog() == DialogResult.OK)
                {
                    
                    string nombreColumna = insertarColumna.txtNombreColumna.Text;
                    string tipoDato = insertarColumna.cbTipoDato.Text;
                    string longitud = insertarColumna.cbLongitud.Text;

                    if (tipoDato == "VARCHAR" | tipoDato == "CHAR")
                    {

                        connection.Open();
                        MySqlCommand command = new MySqlCommand("alter table " + seleccionada + " add " + nombreColumna + " " + tipoDato + " (" + longitud + ");", connection);
                        command.ExecuteNonQuery();
                        connection.Close();
                        MessageBox.Show(this, "Columna agregada exitosamente");

                    }
                    else if (tipoDato == "INT" | tipoDato == "TINYINT" | tipoDato == "SMALLINT" | tipoDato == "DATE")
                    {

                        connection.Open();
                        MySqlCommand command = new MySqlCommand("alter table " + seleccionada + " add " + nombreColumna + " " + tipoDato + ";", connection);
                        command.ExecuteNonQuery();
                        connection.Close();
                        MessageBox.Show(this, "columna agregada exitosamente");

                    }


                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo agregar la nueva columna");
            }


        }

        private void btnEliminarColumna_Click(object sender, EventArgs e)
        {
            frmEliminarColumna eliminarColumna = new frmEliminarColumna(bd, seleccionada);

            try
            {

                if (eliminarColumna.ShowDialog() == DialogResult.OK)
                {
                    string columna = eliminarColumna.cbColumna.Text;

                    connection.Open();
                    MySqlCommand command = new MySqlCommand("ALTER TABLE " + seleccionada + " DROP COLUMN " + columna+ "; ", connection);
                    command.ExecuteNonQuery();
                    
                    connection.Close();
                    MessageBox.Show(this, "Columna eliminada");

                }
                else if (eliminarColumna.ShowDialog() == DialogResult.Cancel)
                {
                    eliminarColumna.Close();

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error!!!");
            }
        }
    }
    
}

