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
    public partial class MenuPage : Form
    {
        public MenuPage()
        {
            InitializeComponent();
        }

        private void btn_VerEstadistica_Click(object sender, EventArgs e)
        {
            new EstadisticaVentas().Show();
            this.Hide();
        }

        private void btn_RegistrarPedido_Click(object sender, EventArgs e)
        {
            new OpcionPedidos.Pedidos().Show();
            this.Hide();
        }

        private void btn_InventarioStock_Click(object sender, EventArgs e)
        {
            new InventarioStock().Show();
            this.Hide();
        }
    }
}
