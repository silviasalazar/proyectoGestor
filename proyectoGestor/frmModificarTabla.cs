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
        string seleccionada = null;//Tabla seleccionada
        string bd; //BD seleccionada
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
                if (seleccionada == null)
                {
                    MessageBox.Show(this, "Seleccione una base de datos");
                }
                else
                {
                    if (renombrar.ShowDialog() == DialogResult.OK)
                    {
                        string nombreNuevo = renombrar.txtNuevoNombre.Text;

                        connection.Open();
                        MySqlCommand command = new MySqlCommand("ALTER TABLE " + seleccionada + " RENAME " + nombreNuevo + ";", connection);
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
                        MySqlCommand command = new MySqlCommand("ALTER TABLE " + seleccionada + " DROP COLUMN " + columna + ";", connection);
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

        private void btnInsertarRegistro_Click(object sender, EventArgs e)
        {
            frmInsertarRegistro insertaRegistro = new frmInsertarRegistro(bd,seleccionada);
            try
            {

                if (insertaRegistro.ShowDialog() == DialogResult.OK)
                {
                    connection.Open();
                    for (int i=0; i<(insertaRegistro.dgvRegistros.Rows.Count)-1;i++)
                    {
                        for (int j = 0; j < (insertaRegistro.dgvRegistros.Columns.Count)-1; j++)
                        {
                            MySqlCommand command = new MySqlCommand("CREATE TRIGGER trigger_name AFTER INSERT ON "+ seleccionada +" FOR EACH ROW BEGIN INSERT INTO VALUES (CURRENT_USER(), NOW());", connection);
                            command.ExecuteNonQuery();

                        }
                           
                    }
                    
                    

                    connection.Close();
                    MessageBox.Show(this, "Registro insertado");


                }
                else if (insertaRegistro.ShowDialog() == DialogResult.Cancel)
                {
                    insertaRegistro.Close();

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error!!!");
            }

        }

        private void btnEliminarRegistro_Click(object sender, EventArgs e)
        {
            frmEliminarRegistro eliminarRegistro = new frmEliminarRegistro(bd,seleccionada);

            try
            {
                

                if (eliminarRegistro.ShowDialog() == DialogResult.OK)
                {
                    string nombreColumna = eliminarRegistro.txtNombreColumna.Text;
                    string identificador = eliminarRegistro.txtIdentificador.Text;


                    connection.Open();
                    MySqlCommand command = new MySqlCommand("delete from " + seleccionada + " where "+nombreColumna+"="+identificador+ "; ", connection);
                             command.ExecuteNonQuery();
                    connection.Close();

             
                  


                            MessageBox.Show("Eliminado");

                }
                else if (eliminarRegistro.ShowDialog() == DialogResult.Cancel)
                {
                    eliminarRegistro.Close();

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error!!!");
            }

        }

        private void btnMostrarPor_Click(object sender, EventArgs e)
        {
            frmListarPorcs listarPor = new frmListarPorcs(bd, seleccionada);
            listarPor.Show();
           /* try
            {
                
                if (listarPor.ShowDialog() == DialogResult.OK)
                {
                    string agrupa = listarPor.cbListar.Text;// columna por la que se mostrara
                    connection.Open();
                    

                    // Datagrig view 
                    MySqlCommand comando = new MySqlCommand("select " + agrupa + " from " + seleccionada + ";", connection);
                    MySqlDataAdapter adaptador = new MySqlDataAdapter();
                    adaptador.SelectCommand = comando;
                    DataTable tabla = new DataTable();
                    adaptador.Fill(tabla);
                    listarPor.dgvListarPor.DataSource = tabla;
                    listarPor.dgvListarPor.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                    connection.Close();
                    MessageBox.Show("Agrupado por: " + agrupa);
                   



                }
                else if (listarPor.ShowDialog() == DialogResult.Cancel)
                {
                    listarPor.Close();

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error!!!");
            }*/

        }

        private void btnActulizarRegistro_Click(object sender, EventArgs e)
        {
            frmActualizarRegistro actualizarRegistro = new frmActualizarRegistro(bd, seleccionada);
            actualizarRegistro.Show();
        }
    }
    
    
}

