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
    public partial class frmInsertaRegistro : Form
    {
        string seleccionada = null;
        MySqlConnection connection = new MySqlConnection("Server=localhost;Database=alumnos;UserId=root;PWD=Unicornio123;");
        public frmInsertaRegistro()
        {
            InitializeComponent();
            connection.Open();
            MySqlDataAdapter adaptador = new MySqlDataAdapter("show tables from alumnos;", connection);
            //adaptador.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            comboBox1.DataSource = tabla;
            comboBox1.ValueMember = "Tables_in_alumnos";
            connection.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            seleccionada = comboBox1.Text;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            seleccionada = comboBox1.Text;
            try
            {
                if (e.RowIndex >= 0)

                {


                    DataGridViewRow row = dataGridView1.Rows[e.RowIndex];


                    seleccionada = row.Cells["colums"].Value.ToString();



                }




            }
            catch { }
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            seleccionada = comboBox1.Text;
            MySqlCommand comando = new MySqlCommand("select * from "+ seleccionada + ";", connection);
            MySqlDataAdapter adaptador = new MySqlDataAdapter();
            adaptador.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dataGridView1.DataSource = tabla;
            connection.Close();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }
    }
}
