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
    public partial class frmListarPorcs : Form
    {
        string bd;
        string seleccionada;
        MySqlConnection connection;
        public frmListarPorcs(string bd, string seleccionada)
        {
            InitializeComponent();
            this.bd = bd;
            this.seleccionada = seleccionada;
            cbCondicion.Items.Add(">");
            cbCondicion.Items.Add(">=");
            cbCondicion.Items.Add("<");
            cbCondicion.Items.Add("<=");
            cbCondicion.Items.Add("=");
            cbCondicion.Items.Add("!=");
            connection = new MySqlConnection("Server=localhost;Database=" + bd + ";UserId=root;PWD=Unicornio123;");
            connection.Open();
            MySqlDataAdapter adaptador = new MySqlDataAdapter("SHOW COLUMNS FROM  " + seleccionada + ";", connection);
            //adaptador.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            cbListar.DataSource = tabla;
            cbListar.ValueMember = "Field";


            // Datagrig view 
            MySqlCommand comando = new MySqlCommand("select * from " + seleccionada + ";", connection);
            MySqlDataAdapter adaptador2 = new MySqlDataAdapter();
            adaptador2.SelectCommand = comando;
            DataTable tabla2 = new DataTable();
            adaptador2.Fill(tabla2);
            dgvListarPor.DataSource = tabla2;
            dgvListarPor.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            connection.Close();
        }

        private void cbListar_SelectedIndexChanged(object sender, EventArgs e)
        {
            string columna = cbListar.Text;
        }

        private void dgvListarPor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string agrupa = cbListar.Text;// columna por la que se mostrara
            string condicion = cbCondicion.Text;
            connection.Open();
            

            // Datagrig view 
            MySqlCommand comando = new MySqlCommand("select * from " + seleccionada + " where "+ agrupa + condicion + txtCondicion.Text +";", connection);
            MySqlDataAdapter adaptador = new MySqlDataAdapter();
            adaptador.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dgvListarPor.DataSource = tabla;
            dgvListarPor.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            connection.Close();
           // MessageBox.Show("Agrupado por: " + agrupa);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmListarPorcs_Load(object sender, EventArgs e)
        {

        }
    }
}
