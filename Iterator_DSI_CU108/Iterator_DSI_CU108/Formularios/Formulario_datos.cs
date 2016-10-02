using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;

namespace Iterator_DSI_CU108
{
    public partial class Formulario_datos : Form
    {
        public Formulario_datos()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Formulario_datos_Load(object sender, EventArgs e)
        {
            cargarGrillaEdicionCongreso();
        }
        protected void cargarGrillaEdicionCongreso()
        {
            dgv_EdicionCongreso.AutoGenerateColumns = false;
            dgv_EdicionCongreso.DataSource = EdicionCongresoNeg.obtenerEdicionesCongreso();            
        }

        protected void cargarGrillaEdicionSimposio()
        {
            dgv_EdicionCongreso.
        }
    }
}
