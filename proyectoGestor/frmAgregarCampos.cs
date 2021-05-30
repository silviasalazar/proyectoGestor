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
    public partial class frmAgregarCampos : Form
    {
        frmCrearTabla crearTabla;
        string bd = null;
        string nombreTabla = null;
        MySqlConnection connection;
        public frmAgregarCampos(frmCrearTabla crearTabla, string bd)
        {
            InitializeComponent();
            this.bd = bd;
            this.crearTabla = crearTabla;
            connection = new MySqlConnection("Server=localhost;Database=" + bd + ";UserId=root;PWD=Unicornio123;");
            //connection.Open();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox1.Items.Add("int");
            comboBox1.Items.Add("varchar");
            comboBox1.Items.Add("date");
           
            string tipoDato = comboBox1.Text;
        }

        private void btnAgregarOtro_Click(object sender, EventArgs e)
        {

        }

        private void btnAceptarCampo_Click(object sender, EventArgs e)
        {
            try
            {
                string nombreTabla = crearTabla.txtNombreTabla.Text;
                string nombreCampo = txtNombreCampo.Text;
                string tipoDato = comboBox1.Text;
                string longitud = txtLongitud.Text;



                    connection.Open();
                    MySqlCommand command = new MySqlCommand("create table " + nombreTabla + "( " + nombreCampo + " " + tipoDato +" (" + longitud + "));", connection);
                    command.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show(this, "Tabla creada exitosamente");

                
                

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo crear la tabla");
            }
            

        }
    }
}
