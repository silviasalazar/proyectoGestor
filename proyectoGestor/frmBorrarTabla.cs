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
        string bd;
        //MySqlConnection connection = new MySqlConnection("Server=localhost;Database="+bd+";UserId=root;PWD=Unicornio123;"); // conectar BD
        MySqlConnection connection;
        public frmBorrarTabla(string bd)
        {
            InitializeComponent();
            this.bd = bd;
            connection = new MySqlConnection("Server=localhost;Database=" + bd + ";UserId=root;PWD=Unicornio123;");
            connection.Open();
            MySqlDataAdapter adaptador = new MySqlDataAdapter("show tables from " + bd +";", connection);
            //adaptador.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            comboBox1.DataSource = tabla;
            comboBox1.ValueMember = "Tables_in_"+bd;
            connection.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            seleccionada = comboBox1.Text;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void frmBorrarTabla_Load(object sender, EventArgs e)
        {

        }
    }
}
