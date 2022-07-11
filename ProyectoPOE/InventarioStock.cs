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
                    lv_ListaProductos.Items.Clear();
                    AbarrotesInventario();
                    break;
                }
                case 1:
                {
                    lv_ListaProductos.Items.Clear();
                    EnlatadosInventario();
                    break;
                }
                case 11:
                {
                    lv_ListaProductos.Items.Clear();
                    AbarrotesInventario();
                    EnlatadosInventario();
                    break;
                }
            }
        }

        private void btn_EliminarProducto_Click(object sender, EventArgs e)
        {
            lv_ListaProductos.Items.Remove(lv_ListaProductos.SelectedItems[0]);
        }

        private void AbarrotesInventario()
        {
            string[][] str1 = new string[10][];
            str1[0] = new string[]
            {
                "Sal",
                "Abarrotes",
                "Comestibles",
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
                "Comestibles",
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
                "Comestibles",
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
                "Comestibles",
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
                "Comestibles",
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
                "Comestibles",
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
                "Comestibles",
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
                "Comestibles",
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
                "Comestibles",
                "77",
                "$6.00",
                "7/10/2025",
                "Bodega 2",
                "Buen Estado",
                "Nestle"
            };

            {
                ListViewItem[] items = new ListViewItem[str1.Length];
                for (int i = 0; i < str1.Length; i++)
                {
                    items[i] = new ListViewItem(str1[i]);
                }
                lv_ListaProductos.Items.AddRange(items);
            }
        }

        private void EnlatadosInventario()
        {
            string[][] str1 = new string[10][];
            str1[0] = new string[]
            {
                "Aceitunas",
                "Enlatados",
                "Comestibles",
                "90",
                "$0.74",
                "7/10/2023",
                "Bodega 1",
                "Buen Estado",
                "Nestle"
            };
            str1[1] = new string[]
            {
                "Champiñones enteros/rebanados",
                "Enlatados",
                "Comestibles",
                "65",
                "$1.00",
                "7/10/2023",
                "Bodega 1",
                "Buen Estado",
                "Nestle"
            };
            str1[2] = new string[]
            {
                "Chícharo con zanahoria",
                "Enlatados",
                "Comestibles",
                "59",
                "$2.07",
                "7/10/2023",
                "Bodega 1",
                "Buen Estado",
                "Nestle"
            };
            str1[3] = new string[]
            {
                "Chícharos enlatados",
                "Enlatados",
                "Comestibles",
                "65",
                "$1.50",
                "7/10/2023",
                "Bodega 1",
                "Buen Estado",
                "Nestle"
            };
            str1[4] = new string[]
            {
                "Frijoles enlatados",
                "Enlatados",
                "Comestibles",
                "88",
                "$3.00",
                "7/10/2023",
                "Bodega 1",
                "Buen Estado",
                "Nestle"
            };
            str1[5] = new string[]
            {
                "Frutas en almíbar",
                "Enlatados",
                "Comestibles",
                "92",
                "$1.50",
                "7/10/2023",
                "Bodega 1",
                "Buen Estado",
                "Nestle"
            };
            str1[6] = new string[]
            {
                "Sardinas",
                "Enlatados",
                "Comestibles",
                "77",
                "$2.00",
                "7/10/2023",
                "Bodega 1",
                "Buen Estado",
                "Nestle"
            };
            str1[7] = new string[]
            {
                "Atún en agua/aceite",
                "Enlatados",
                "Comestibles",
                "54",
                "$4.00",
                "7/10/2023",
                "Bodega 1",
                "Buen Estado",
                "Nestle"
            };
            str1[8] = new string[]
            {
                "Chiles enlatados",
                "Enlatados",
                "Comestibles",
                "77",
                "$6.00",
                "7/10/2023",
                "Bodega 1",
                "Buen Estado",
                "Nestle"
            };

            {
                ListViewItem[] items = new ListViewItem[str1.Length];
                for (int i = 0; i < str1.Length; i++)
                {
                    items[i] = new ListViewItem(str1[i]);
                }
                lv_ListaProductos.Items.AddRange(items);
            }
        }
    }
}
