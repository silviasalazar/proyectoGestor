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
    public partial class frmBorrarTabla : Form
    {
        string seleccionada = null;
        MySqlConnection connection = new MySqlConnection("Server=localhost;Database=alumnos;UserId=root;PWD=Unicornio123;"); // conectar BD
        public frmBorrarTabla()
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
    }
}
