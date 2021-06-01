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
    public partial class frmInsertarColumna : Form
    {
        public frmInsertarColumna()
        {
            InitializeComponent();
            cbTipoDato.Items.Add("INT");
            cbTipoDato.Items.Add("TINYINT");
            cbTipoDato.Items.Add("SMALLINT");
            cbTipoDato.Items.Add("VARCHAR");
            cbTipoDato.Items.Add("CHAR");
            cbTipoDato.Items.Add("DATE");
            cbLongitud.Items.Add("10");
            cbLongitud.Items.Add("15");
            cbLongitud.Items.Add("20");
            cbLongitud.Items.Add("25");
            cbLongitud.Items.Add("30");
            cbLongitud.Items.Add("50");
            cbLongitud.Items.Add("100");
        }

        private void cbTipoDato_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tipo = cbTipoDato.Text;
            if (tipo == "VARCHAR" | tipo == "CHAR")
            {

                cbLongitud.Enabled = true;


            }
            else if (tipo == "INT" | tipo == "TINYINT" | tipo == "SMALLINT")
            {

                cbLongitud.Enabled = false;

            }


        }

        private void cbLongitud_SelectedIndexChanged(object sender, EventArgs e)
        {
            string longitud = cbLongitud.Text;
        }
    }
}
