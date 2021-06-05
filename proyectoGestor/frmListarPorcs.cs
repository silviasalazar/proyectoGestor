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
            //cbCondicionOpcional
            cbCondicionOpcional.Items.Add(">");
            cbCondicionOpcional.Items.Add(">=");
            cbCondicionOpcional.Items.Add("<");
            cbCondicionOpcional.Items.Add("<=");
            cbCondicionOpcional.Items.Add("=");
            cbCondicionOpcional.Items.Add("!=");

            //cbAndOr
            cbAndOr.Items.Add("and");
            cbAndOr.Items.Add("or");
            //conexion
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


            //cbcolumnaOpcional
            MySqlDataAdapter adaptador3 = new MySqlDataAdapter("SHOW COLUMNS FROM  " + seleccionada + ";", connection);
            DataTable tabla3 = new DataTable();
            adaptador3.Fill(tabla3);
            cbColumnaOpcional.DataSource = tabla3;
            cbColumnaOpcional.ValueMember = "Field";
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
            string agrupaOpcional = cbColumnaOpcional.Text;
            string condicionOpcional = cbCondicionOpcional.Text;
            string textoOpcional = txtopcional.Text;
            connection.Open();
            
            if(cbAndOr.SelectedIndex==-1 || cbColumnaOpcional.SelectedIndex == -1 || cbCondicionOpcional.SelectedIndex == -1 || textoOpcional==null)
            {
                // Datagrig view 
                MySqlCommand comando = new MySqlCommand("select * from " + seleccionada + " where " + agrupa + condicion + txtCondicion.Text + ";", connection);
                MySqlDataAdapter adaptador = new MySqlDataAdapter();
                adaptador.SelectCommand = comando;
                DataTable tabla = new DataTable();
                adaptador.Fill(tabla);
                dgvListarPor.DataSource = tabla;
                dgvListarPor.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                connection.Close();
                // MessageBox.Show("Agrupado por: " + agrupa);

            }
            else
            {
                if(cbAndOr.SelectedItem.ToString()=="and")
                {
                    // Datagrig view 
                    MySqlCommand comando = new MySqlCommand("select * from " + seleccionada + " where " + agrupa + condicion + txtCondicion.Text + " and " + agrupaOpcional +condicionOpcional+ textoOpcional+";", connection);
                    MySqlDataAdapter adaptador = new MySqlDataAdapter();
                    adaptador.SelectCommand = comando;
                    DataTable tabla = new DataTable();
                    adaptador.Fill(tabla);
                    dgvListarPor.DataSource = tabla;
                    dgvListarPor.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                    connection.Close();

                }
                else if(cbAndOr.Text=="or")
                {
                    // Datagrig view 
                    MySqlCommand comando = new MySqlCommand("select * from " + seleccionada + " where " + agrupa + condicion + txtCondicion.Text + " or " + agrupaOpcional + condicionOpcional + textoOpcional + ";", connection);
                    MySqlDataAdapter adaptador = new MySqlDataAdapter();
                    adaptador.SelectCommand = comando;
                    DataTable tabla = new DataTable();
                    adaptador.Fill(tabla);
                    dgvListarPor.DataSource = tabla;
                    dgvListarPor.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                    connection.Close();
                }
            }
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmListarPorcs_Load(object sender, EventArgs e)
        {

        }

        private void cbAndOr_SelectedIndexChanged(object sender, EventArgs e)
        {
            string andOr = cbAndOr.Text;
        }

        private void cbColumnaOpcional_SelectedIndexChanged(object sender, EventArgs e)
        {
            string columnaOpcional = cbColumnaOpcional.Text;
        }

        private void cbCondicionOpcional_SelectedIndexChanged(object sender, EventArgs e)
        {
            string condicionOpcional = cbCondicionOpcional.Text;
        }
    }
}
