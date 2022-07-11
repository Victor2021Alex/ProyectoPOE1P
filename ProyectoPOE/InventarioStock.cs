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
    public partial class InventarioStock : Form
    {
        public InventarioStock()
        {
            InitializeComponent();
        }

        private void btn_Regresar_Click(object sender, EventArgs e)
        {
            new MenuPage().Show();
            this.Hide();
        }

        private void cmb_FiltrarStock_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmb_FiltrarStock.SelectedIndex)
            {
                case 0:
                {
                    AbarrotesInventario();
                    break;
                }
                case 1:
                {
                    lv_ListaProductos.Items.Clear();
                    break;
                }
                case 2:
                {
                    lv_ListaProductos.Items.Clear();
                    break;
                }
            }
        }

        private void AbarrotesInventario()
        {
            string[][] str1 = new string[10][];
            str1[0] = new string[]
            {
                "Sal",
                "Abarrotes",
                "$85",
                "90",
                "$0.74",
                "7/10/2025",
                "Bodega 2",
                "Buen Estado",
                "Nestle"
            };
            str1[1] = new string[]
            {
                "Salsas envasadas",
                "Abarrotes",
                "$99",
                "65",
                "$1.00",
                "7/10/2025",
                "Bodega 2",
                "Buen Estado",
                "Nestle"
            };
            str1[2] = new string[]
            {
                "Sazonadores",
                "Abarrotes",
                "$56",
                "59",
                "$2.07",
                "7/10/2025",
                "Bodega 2",
                "Buen Estado",
                "Nestle"
            };
            str1[3] = new string[]
            {
                "Sopas en sobre",
                "Abarrotes",
                "$79",
                "65",
                "$1.50",
                "7/10/2025",
                "Bodega 2",
                "Buen Estado",
                "Nestle"
            };
            str1[4] = new string[]
            {
                "Cajeta",
                "Abarrotes",
                "$67",
                "88",
                "$3.00",
                "7/10/2025",
                "Bodega 2",
                "Buen Estado",
                "Nestle"
            };
            str1[5] = new string[]
            {
                "Catsup",
                "Abarrotes",
                "$82",
                "92",
                "$1.50",
                "7/10/2025",
                "Bodega 2",
                "Buen Estado",
                "Nestle"
            };
            str1[6] = new string[]
            {
                "Mayonesa",
                "Abarrotes",
                "$87",
                "77",
                "$2.00",
                "7/10/2025",
                "Bodega 2",
                "Buen Estado",
                "Nestle"
            };
            str1[7] = new string[]
            {
                "Mermelada",
                "Abarrotes",
                "$83",
                "54",
                "$4.00",
                "7/10/2025",
                "Bodega 2",
                "Buen Estado",
                "Nestle"
            };
            str1[8] = new string[]
            {
                "Miel",
                "Abarrotes",
                "$85",
                "77",
                "$6.00",
                "7/10/2025",
                "Bodega 2",
                "Buen Estado",
                "Nestle"
            };

            ListViewItem[] items = new ListViewItem[str1.Length];
            {
                for (int i = 0; i < str1.Length; i++)
                {
                    items[i] = new ListViewItem(str1[i]);
                }
                lv_ListaProductos.Items.AddRange(items);
            }
        }
    }
}
