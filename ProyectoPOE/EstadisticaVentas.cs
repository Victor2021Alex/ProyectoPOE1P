using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoPOE
{
    public partial class EstadisticaVentas : Form
    {
        public EstadisticaVentas()
        {
            InitializeComponent();
        }

        private void btn_Regresar_Click(object sender, EventArgs e)
        {
            new MenuPage().Show();
            this.Hide();
        }

        private void btn_MasVendido_Click(object sender, EventArgs e)
        {
            ListViewItem inventarioItems = new ListViewItem();
            // generate list of how many sells have a item in a month in lv_EstadisticaVentas
            inventarioItems = lv_EstadisticaVentas.Items.Add("Papel bond");
            inventarioItems.SubItems.Add("1");
            inventarioItems.SubItems.Add("12");
        }
    }
}
