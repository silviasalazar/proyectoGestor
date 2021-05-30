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
    public partial class frmInsertarRegistro : Form
    {
        string bd; //BD
        string seleccionada; //Tabla
        MySqlConnection connection;
        public frmInsertarRegistro(string bd, string seleccionada)
        {
            InitializeComponent();
            this.bd = bd;
            this.seleccionada = seleccionada;
            connection = new MySqlConnection("Server=localhost;Database="+bd+";UserId=root;PWD=Unicornio123;");
            connection.Open();
            MySqlCommand comando = new MySqlCommand("select * from " + seleccionada+";", connection);
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
           /* try
            {
                if (e.RowIndex >= 0)

                {


                    DataGridViewRow row = dgvRegistros.Rows[e.RowIndex];


                    //bd = row.Cells["Database"].Value.ToString();



                }




            }
            catch { }*/
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {

        }
    }
}
