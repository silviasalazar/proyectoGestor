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
    public partial class frmEliminarColumna : Form
    {
        string bd;
        string seleccionada;
        MySqlConnection connection;
        public frmEliminarColumna(string bd, string seleccionada)
        {
            InitializeComponent();
            this.bd = bd;
            this.seleccionada = seleccionada;
            connection = new MySqlConnection("Server=localhost;Database=" + bd + ";UserId=root;PWD=Unicornio123;");
            connection.Open();
            MySqlDataAdapter adaptador = new MySqlDataAdapter("SHOW COLUMNS FROM  " +  seleccionada + ";", connection);
            //adaptador.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            cbColumna.DataSource = tabla;
            cbColumna.ValueMember = "Field";
            connection.Close();
        }

        private void cbColumna_SelectedIndexChanged(object sender, EventArgs e)
        {
            string columna = cbColumna.Text;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }
    }
}
