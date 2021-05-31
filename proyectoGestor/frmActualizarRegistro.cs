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
    public partial class frmActualizarRegistro : Form
    {
        string bd;
        string seleccionada;
        MySqlConnection connection;
        public frmActualizarRegistro(string bd, string seleccionada)
        {
            InitializeComponent();
            this.bd = bd;
            this.seleccionada = seleccionada;
            connection = new MySqlConnection("Server=localhost;Database=" + bd + ";UserId=root;PWD=Unicornio123;");
            connection.Open();
            MySqlDataAdapter adaptador = new MySqlDataAdapter("SHOW COLUMNS FROM  " + seleccionada + ";", connection);
            //adaptador.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            cbColumna.DataSource = tabla;
            cbColumna.ValueMember = "Field";

            // Datagrig view 
            MySqlCommand comando = new MySqlCommand("select * from " + seleccionada + ";", connection);
            MySqlDataAdapter adaptador2 = new MySqlDataAdapter();
            adaptador2.SelectCommand = comando;
            DataTable tabla2 = new DataTable();
            adaptador2.Fill(tabla2);
            dataGridView1.DataSource = tabla2;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            connection.Close();
        }

        private void cbColumna_SelectedIndexChanged(object sender, EventArgs e)
        {
            string columna = cbColumna.Text;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                string columna = cbColumna.Text;
                string viejo = txtViejo.Text;
                string nuevo = txtNuevo.Text;
                connection.Open();
                MySqlCommand command = new MySqlCommand("update " + seleccionada + " set " + columna +"="+ nuevo + " where "+columna+ "="+ viejo+";", connection);
                command.ExecuteNonQuery();
                
                connection.Close();
                MessageBox.Show(this, "Actualizado correctamente");
            }
            catch { MessageBox.Show(this, "No se pudo actualizar"); }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            // Datagrig view 
            connection.Open();
            MySqlCommand comando = new MySqlCommand("select * from " + seleccionada + ";", connection);
            MySqlDataAdapter adaptador2 = new MySqlDataAdapter();
            adaptador2.SelectCommand = comando;
            DataTable tabla2 = new DataTable();
            adaptador2.Fill(tabla2);
            dataGridView1.DataSource = tabla2;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            connection.Close();

        }
    }
}
