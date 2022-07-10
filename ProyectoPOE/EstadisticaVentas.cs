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
            lv_EstadisticaVentas.Items.Clear();
            MasVendidos();
        }

        private void btn_MenosVendido_Click(object sender, EventArgs e)
        {
            lv_EstadisticaVentas.Items.Clear();
            MenosVendidos();
        }

        private void btn_MayorGanancia_Click(object sender, EventArgs e)
        {
            lv_EstadisticaVentas.Items.Clear();
            MasIngresos();
        }

        private void MasVendidos()
        {
            string[][] str1 = new string[10][];
            str1[0] = new string[]
            {
                "Aceite comestibles",
                "27",
                "19",
                "19",
                "27",
                "24",
                "46",
                "49",
                "21",
                "23",
                "26",
                "43",
                "36"
            };
            str1[1] = new string[]
            {
                "Aderezos",
                "21",
                "44",
                "39",
                "37",
                "31",
                "28",
                "27",
                "43",
                "41",
                "24",
                "32",
                "40"
            };
            str1[2] = new string[]
            {
                "Consome",
                "32",
                "49",
                "17",
                "25",
                "45",
                "17",
                "22",
                "19",
                "18",
                "45",
                "18",
                "15"
            };
            str1[3] = new string[]
            {
                "Crema de cacahuate",
                "24",
                "41",
                "47",
                "41",
                "36",
                "21",
                "45",
                "44",
                "25",
                "43",
                "44",
                "20"
            };
            str1[4] = new string[]
            {
                "Crema para café",
                "46",
                "49",
                "19",
                "43",
                "17",
                "41",
                "36",
                "34",
                "23",
                "29",
                "28",
                "38"
            };
            str1[5] = new string[]
            {
                "Pure de tomate",
                "22",
                "38",
                "20",
                "15",
                "42",
                "17",
                "19",
                "25",
                "45",
                "22",
                "39",
                "26"
            };
            str1[6] = new string[]
            {
                "Alimento para bebe",
                "18",
                "47",
                "41",
                "47",
                "35",
                "24",
                "28",
                "19",
                "31",
                "15",
                "39",
                "29"
            };
            str1[7] = new string[]
            {
                "Alimento para mascotas",
                "49",
                "42",
                "45",
                "37",
                "24",
                "16",
                "28",
                "47",
                "25",
                "34",
                "16",
                "26"
            };
            str1[8] = new string[]
            {
                "Avena",
                "42",
                "23",
                "17",
                "44",
                "35",
                "34",
                "38",
                "17",
                "32",
                "20",
                "32",
                "43"
            };
            str1[9] = new string[]
            {
                "Azúcar",
                "49",
                "18",
                "47",
                "30",
                "44",
                "27",
                "46",
                "49",
                "46",
                "27",
                "50",
                "42"
            };

            ListViewItem[] items = new ListViewItem[str1.Length];
            {
                for (int i = 0; i < str1.Length; i++)
                {
                    items[i] = new ListViewItem(str1[i]);
                }
                lv_EstadisticaVentas.Items.AddRange(items);
            }
        }

        private void MenosVendidos()
        {
            string[][] str1 = new string[10][];
            str1[0] = new string[]
            {
                "Café",
                "7",
                "3",
                "10",
                "6",
                "5",
                "10",
                "6",
                "4",
                "2",
                "10",
                "3",
                "10"
            };
            str1[1] = new string[]
            {
                "Cereales",
                "1",
                "9",
                "10",
                "3",
                "8",
                "10",
                "6",
                "1",
                "6",
                "9",
                "7",
                "10"
            };
            str1[2] = new string[]
            {
                "Chile piquín",
                "6",
                "7",
                "7",
                "7",
                "1",
                "5",
                "9",
                "6",
                "8",
                "4",
                "5",
                "2"
            };
            str1[3] = new string[]
            {
                "Especias",
                "6",
                "1",
                "6",
                "1",
                "2",
                "4",
                "4",
                "8",
                "3",
                "5",
                "4",
                "7"
            };
            str1[4] = new string[]
            {
                "Flan en polvo",
                "4",
                "8",
                "6",
                "3",
                "8",
                "3",
                "6",
                "7",
                "3",
                "9",
                "1",
                "6"
            };
            str1[5] = new string[]
            {
                "Formulas infantiles",
                "1",
                "1",
                "5",
                "4",
                "1",
                "9",
                "4",
                "4",
                "8",
                "5",
                "5",
                "2"
            };
            str1[6] = new string[]
            {
                "Gelatinas en polvo/Grenetina",
                "2",
                "8",
                "5",
                "3",
                "7",
                "9",
                "8",
                "6",
                "1",
                "2",
                "2",
                "7"
            };
            str1[7] = new string[]
            {
                "Harina",
                "9",
                "4",
                "8",
                "3",
                "2",
                "1",
                "3",
                "6",
                "7",
                "3",
                "4",
                "9"
            };
            str1[8] = new string[]
            {
                "Harina preparada",
                "9",
                "5",
                "6",
                "1",
                "7",
                "3",
                "9",
                "5",
                "8",
                "3",
                "9",
                "3"
            };
            str1[9] = new string[]
            {
                "Mole",
                "9",
                "3",
                "1",
                "4",
                "6",
                "8",
                "7",
                "3",
                "7",
                "8",
                "8",
                "3"
            };

            ListViewItem[] items = new ListViewItem[str1.Length];
            {
                for (int i = 0; i < str1.Length; i++)
                {
                    items[i] = new ListViewItem(str1[i]);
                }
                lv_EstadisticaVentas.Items.AddRange(items);
            }
        }

        private void MasIngresos()
        {
            string[][] str1 = new string[10][];
            str1[0] = new string[]
            {
                "Sal",
                "$60",
                "$85",
                "$90",
                "$74",
                "$51",
                "$99",
                "$59",
                "$80",
                "$70",
                "$69",
                "$84",
                "$80"
            };
            str1[1] = new string[]
            {
                "Salsas envasadas",
                "$75",
                "$99",
                "$65",
                "$100",
                "$52",
                "$70",
                "$90",
                "$79",
                "$69",
                "$58",
                "$83",
                "$61"
            };
            str1[2] = new string[]
            {
                "Sazonadores",
                "$93",
                "$56",
                "$59",
                "$57",
                "$61",
                "$63",
                "$93",
                "$100",
                "$75",
                "$77",
                "$91",
                "$85"
            };
            str1[3] = new string[]
            {
                "Sopas en sobre",
                "$65",
                "$79",
                "$65",
                "$56",
                "$96",
                "$78",
                "$56",
                "$70",
                "$81",
                "$62",
                "$97",
                "$50"
            };
            str1[4] = new string[]
            {
                "Cajeta",
                "$94",
                "$67",
                "$88",
                "$58",
                "$86",
                "$82",
                "$51",
                "$60",
                "$100",
                "$57",
                "$99",
                "$68"
            };
            str1[5] = new string[]
            {
                "Catsup",
                "$89",
                "$82",
                "$92",
                "$52",
                "$90",
                "$57",
                "$53",
                "$62",
                "$74",
                "$61",
                "$63",
                "$56"
            };
            str1[6] = new string[]
            {
                "Mayonesa",
                "$73",
                "$87",
                "$77",
                "$90",
                "$89",
                "$96",
                "$51",
                "$91",
                "$73",
                "$86",
                "$68",
                "$90"
            };
            str1[7] = new string[]
            {
                "Mermelada",
                "$81",
                "$83",
                "$54",
                "$62",
                "$69",
                "$97",
                "$91",
                "$87",
                "$60",
                "$99",
                "$73",
                "$79"
            };
            str1[8] = new string[]
            {
                "Miel",
                "$97",
                "$85",
                "$77",
                "$64",
                "$61",
                "$67",
                "$89",
                "$62",
                "$90",
                "$55",
                "$94",
                "$67"
            };
            str1[9] = new string[]
            {
                "Pastas",
                "$87",
                "$83",
                "$93",
                "$59",
                "$72",
                "$51",
                "$51",
                "$85",
                "$53",
                "$59",
                "$62",
                "$97"
            };

            ListViewItem[] items = new ListViewItem[str1.Length];
            {
                for (int i = 0; i < str1.Length; i++)
                {
                    items[i] = new ListViewItem(str1[i]);
                }
                lv_EstadisticaVentas.Items.AddRange(items);
            }
        }
    }
}
