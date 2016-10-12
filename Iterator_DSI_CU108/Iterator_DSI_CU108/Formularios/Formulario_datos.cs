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
            cargarGrillaEdicion();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
                

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Formulario_datos_Load(object sender, EventArgs e)
        {
            

        }

        // hay que borrarlo, es el boton para cargar la grilla de los simposios
        private void button1_Click(object sender, EventArgs e)
        {
            
        }
        //cargo el resultado
        private void btn_generarReporte_Click(object sender, EventArgs e)
        {
            cargarGrillaResultado();
        }
        //obtengo los numeros de las grillas
        public List<int> numeroSimposio()
        {
            List<int> lista = new List<int>();
            foreach (DataGridViewRow row in dgv_simposio.Rows)
            {
                if (row.Cells[4].Value != null)
                {
                    if ((Boolean)row.Cells[4].Value == true)
                    {
                        if (row.Cells[5].Value != null)
                        {
                            lista.Add(int.Parse(row.Cells[5].Value.ToString()));
                        }
                    }
                }
            }
           
            return lista;
        }

        public List<int> numeroSimpCon()
        {
            List<int> lista = new List<int>();
            foreach (DataGridViewRow row in dgv_simposio.Rows)
            {
                if (row.Cells[4].Value != null)
                {
                    if ((Boolean)row.Cells[4].Value == true)
                    {
                        if (row.Cells[6].Value != null)
                        {
                            lista.Add(int.Parse(row.Cells[6].Value.ToString()));
                        }
                    }
                }
            }

            return lista;
        }

        public List<int> numeroCongreso()
        {
            List<int> lista = new List<int>();
            foreach (DataGridViewRow row in dgv_edicion.Rows)
            {
                if (row.Cells[1].Value != null)
                {
                    if ((Boolean)row.Cells[1].Value == true)
                    {
                        if (row.Cells[0].Value != null)
                        {
                            lista.Add(int.Parse(row.Cells[0].Value.ToString()));                            
                        }
                    }
                }
            }

            return lista;
        }
        // Carga de las 3 grillas
        protected void cargarGrillaEdicionSimposio()
        {
                dgv_simposio.AutoGenerateColumns = false;
                dgv_simposio.DataSource = EdicionSimposioNeg.ediSimpFiltrada(numeroCongreso());
        }

        public void cargarGrillaResultado()
        {
            dgv_resultado.DataSource = TrabajoDeInvestigacionNeg.tpsFiltrados(numeroSimposio(), numeroSimpCon());
        }

       public void cargarGrillaEdicion()
        {
            dgv_edicion.AutoGenerateColumns = false;
            dgv_edicion.DataSource = EdicionCongresoNeg.obtenerEdicionesCongreso();

        }

       private void dgv_edicion_CellClick(object sender, DataGridViewCellEventArgs e)
       {
           cargarGrillaEdicionSimposio();
       }

       

       
               
    }
}
