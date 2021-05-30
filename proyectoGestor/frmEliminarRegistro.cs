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
    public partial class frmEliminarRegistro : Form
    {
        string bd;
        string seleccionada;
        MySqlConnection connection;
        public frmEliminarRegistro(string bd, string seleccionada)
        {
            InitializeComponent();
            this.bd = bd;
            this.seleccionada = seleccionada;
            
            connection = new MySqlConnection("Server=localhost;Database=" + bd + ";UserId=root;PWD=Unicornio123;");
            connection.Open();
            MySqlCommand comando = new MySqlCommand("select * from " + seleccionada + ";", connection);
            MySqlDataAdapter adaptador = new MySqlDataAdapter();
            adaptador.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dgvRegistros.DataSource = tabla;
            connection.Close();
            dgvRegistros.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void dgvRegistros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //obtienes el valor reservado
            string valorCelda = dgvRegistros.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();

            //nombre columna
            string nombrecolumna = dgvRegistros.Columns[e.ColumnIndex].HeaderText;

            //obtienes el valor de la primer columna
            string valorPrimerCelda = dgvRegistros.Rows[e.RowIndex].Cells[0].Value.ToString();
        }
    }
}
