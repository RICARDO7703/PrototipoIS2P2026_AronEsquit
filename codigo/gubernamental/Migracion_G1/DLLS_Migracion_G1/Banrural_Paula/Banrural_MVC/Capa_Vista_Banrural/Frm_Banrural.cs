using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Vista_Banrural
{
    public partial class Frm_Banrural : Form
    {
        public Frm_Banrural()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Buscar_Click(object sender, EventArgs e)
        {
            Frm_BuscarBoleta frm = new Frm_BuscarBoleta();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void Btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Txt_Dpi_TextChanged(object sender, EventArgs e)
        {

        }

        private void Btn_BuscarDpi_Click(object sender, EventArgs e)
        {

        }

        private void Txt_Nombres_TextChanged(object sender, EventArgs e)
        {

        }

        private void Txt_Apellidos_TextChanged(object sender, EventArgs e)
        {

        }

        private void Txt_Edad_TextChanged(object sender, EventArgs e)
        {

        }

        private void Txt_NoBoleta_TextChanged(object sender, EventArgs e)
        {

        }

        private void Btn_GenerarBoleta_Click(object sender, EventArgs e)
        {

        }

        private void Cmb_TipoPasaporte_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Cmb_Duracion_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Txt_TotalPagar_TextChanged(object sender, EventArgs e)
        {

        }

        private void Btn_Guardar_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Imprimir_Click(object sender, EventArgs e)
        {

        }

        private void Btn_LimpiarTodo_Click(object sender, EventArgs e)
        {

        }
    }
}
