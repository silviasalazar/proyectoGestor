using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;//Utilizada para crear las carpetas
using MySql.Data.MySqlClient;

namespace proyectoGestor
{
    public partial class Form1 : Form
    {

        public string BDSeleccionada = null;
        public string Usando = null;//Es el nombre de la BD que se encuentra en uso
        string DirectorioPrincipal = Application.StartupPath + @"\BasesDeDatos\";
        MySqlConnection connection = new MySqlConnection("Server=localhost;UserId=root;PWD=Unicornio123;"); // conectar BD

        public Form1()
        {
            InitializeComponent();
            // Desplegar bases de datos existentes
           /* connection.Open();
            MySqlCommand comando = new MySqlCommand("show databases;", connection);
            MySqlDataAdapter adaptador = new MySqlDataAdapter();
            adaptador.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dgDB.DataSource = tabla;
            connection.Close();
            dgDB.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;*/


            // ****************************************************************************
            //MySqlCommand command = new MySqlCommand("SHOW DATABASE ;", connection);
            connection.Open();
            //MySqlCommand comando = new MySqlCommand("show databases;", connection);
            MySqlDataAdapter adaptador = new MySqlDataAdapter("show databases;", connection);
            //adaptador.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            cbDB.DataSource = tabla;
            cbDB.ValueMember = "Database";
            connection.Close();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            frmNueva Nueva = new frmNueva();


            try
            {

                if (Nueva.ShowDialog() == DialogResult.OK)
                {
                    string txtNombreBD = Nueva.txtNombre.Text;

                    connection.Open();
                    MySqlCommand command = new MySqlCommand("CREATE DATABASE " + txtNombreBD + ";", connection);
                    command.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show(this, "Base de datos creada exitosamente");

                    connection.Open();
                    //MySqlCommand comando = new MySqlCommand("show databases;", connection);
                    MySqlDataAdapter adaptador = new MySqlDataAdapter("show databases;", connection);
                    //adaptador.SelectCommand = comando;
                    DataTable tabla = new DataTable();
                    adaptador.Fill(tabla);
                    cbDB.DataSource = tabla;
                    cbDB.ValueMember = "Database";
                    connection.Close();

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo crear la base de datos");
            }
            

        }

        private void dgDB_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            /*try
            {
                if (e.RowIndex >= 0)

                {


                    DataGridViewRow row = dgDB.Rows[e.RowIndex];


                    BDSeleccionada = row.Cells["Database"].Value.ToString();



                }




            }
            catch { }*/
        }

        private void btnUsar_Click(object sender, EventArgs e)
        {
            /*
            //el valor de nomCarpeta se obtiene del evento dgBD_CellContentClick
            if (BDSeleccionada == null)
            {
                MessageBox.Show(this, "Seleccione una base de datos");
            }
            else
            {
                MySqlCommand command = new MySqlCommand("USE DATABASE " + BDSeleccionada + ";", connection);
                connection.Open();
                //command.ExecuteNonQuery();
                //connection.Close();
               

                if (Usando == null)
                {
                    Usando = BDSeleccionada;
                    MessageBox.Show(this, "La base de datos: " + Usando + " se inicio correctamente");
                    connection.Close();
                }
                else
                    MessageBox.Show(this, "La base de datos: " + Usando + " se encuentra en uso", "Alerta", MessageBoxButtons.OK);
            }
            //Si la BD, ya esta en uso, ignorar*/

            //el valor de nomCarpeta se obtiene del evento dgBD_CellContentClick
            if (BDSeleccionada == null)
            {
                MessageBox.Show(this, "Seleccione una base de datos");
            }
            else
            {
                


                if (Usando == null)
                {
                    Usando = BDSeleccionada;
                    connection.Open();
                    MySqlCommand command = new MySqlCommand("use " + BDSeleccionada + ";", connection);
                    command.ExecuteNonQuery();
                    
                    MessageBox.Show(this, "La base de datos: " + Usando + " se inicio correctamente");
                    connection.Close();
                }
                else
                    MessageBox.Show(this, "La base de datos: " + Usando + " se encuentra en uso", "Alerta", MessageBoxButtons.OK);
            }
            //Si la BD, ya esta en uso, ignorar
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {

            if (BDSeleccionada == null)
            {
                MessageBox.Show(this, "Seleccione una base de datos");
            }
            else
            {



                if (Usando == null)
                {
                    Usando = BDSeleccionada;
                    connection.Open();
                    MySqlCommand command = new MySqlCommand("DROP DATABASE " + Usando + ";", connection);
                     
                    command.ExecuteNonQuery();

                  
                    MessageBox.Show(this, "La base de datos: " + Usando + " se elimino correctamente");
                    
                    Usando = null;
                    BDSeleccionada = null;
                    
                    
                }
                MySqlDataAdapter adaptador = new MySqlDataAdapter("show databases;", connection);
                //adaptador.SelectCommand = comando;
                DataTable tabla = new DataTable();
                adaptador.Fill(tabla);
                //cbDB.DataSource = null;
                //cbDB.Items.Clear();
                cbDB.DataSource = tabla;
                cbDB.ValueMember = "Database";
                connection.Close();

            }
        }

        private void cbDB_SelectedIndexChanged(object sender, EventArgs e)
        {
            BDSeleccionada = cbDB.Text;
            /*
                        //MySqlCommand command = new MySqlCommand("SHOW DATABASE ;", connection);
                        connection.Open();
                        //MySqlCommand comando = new MySqlCommand("show databases;", connection);
                        MySqlDataAdapter adaptador = new MySqlDataAdapter("show databases;", connection);
                        //adaptador.SelectCommand = comando;
                        DataTable tabla = new DataTable();
                        adaptador.Fill(tabla);
                        cbDB.DataSource = tabla;
                        cbDB.ValueMember = "Database";

                        //connection.Close();
            */


        }

        private void btnDejar_Click(object sender, EventArgs e)
        {
            if (Usando != null)
            {
                MessageBox.Show(this, "La base de datos: " + Usando + " ya no esta en uso");
                Usando = null;
            }
            else
                MessageBox.Show(this, "Ninguna base de datos se encuentra en uso", "Alerta", MessageBoxButtons.OK);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (Usando != null && BDSeleccionada != null)
            {
                //En esta ruta te encuentras dentro del directorio de la BD que esta en uso
                //string ruta = Application.StartupPath + @"\BasesDeDatos\" + Usando + @"\";
                // this.Visible = false;
                //MySqlConnection connection = new MySqlConnection("Server=localhost;UserId=root;PWD=Unicornio123; database="+ Usando + ";");
                frmModificar modificar = new frmModificar(this,Usando);
                //modificar.Usando = this;
                modificar.Show();

                




                //modificar.Visible = true;
                //modificar.Focus();
            }
            else
                MessageBox.Show(this, "Seleccione una base de datos", "Alerta", MessageBoxButtons.OK);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
