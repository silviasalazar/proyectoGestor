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
    public partial class frmModificar : Form
    {
       // string usando = null;
        MySqlConnection connection = new MySqlConnection("Server=localhost;Database=alumnos;UserId=root;PWD=Unicornio123;"); // conectar BD
        public frmModificar()
        {
            InitializeComponent();
            //connection.Open();
        }

        private void frmModificar_Load(object sender, EventArgs e)
        {

        }

        private void btnCrearTabla_Click(object sender, EventArgs e)
        {
            frmCrearTabla crearTabla = new frmCrearTabla();
            //crearTabla.Show();

            try
            {

                if (crearTabla.ShowDialog() == DialogResult.OK)
                {
                    string nombre = crearTabla.txtNombre.Text;

                    connection.Open();
                    MySqlCommand command = new MySqlCommand("create table " + nombre + " ( id int primary key);", connection);
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

        private void btnBorrarTabla_Click(object sender, EventArgs e)
        {
            frmBorrarTabla borrarTabla = new frmBorrarTabla();
            //borrarTabla.Show();

            try
            {

                if (borrarTabla.ShowDialog() == DialogResult.OK)
                {
                    string usando = borrarTabla.comboBox1.Text;

                    connection.Open();
                    MySqlCommand command = new MySqlCommand("drop table " + usando + ";", connection);
                    command.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show(this, "Tabla borrada exitosamente");
                   // connection.Close();

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo borrar la tabla");
            }

        }

        private void btnInsertarRegistros_Click(object sender, EventArgs e)
        {
            frmInsertaRegistro insertar = new frmInsertaRegistro();
            insertar.Show();
        }
    }
}
