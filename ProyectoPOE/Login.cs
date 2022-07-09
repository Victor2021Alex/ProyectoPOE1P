namespace ProyectoPOE
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btn_IniciarSesion_Click(object sender, EventArgs e)
        {
            panel_Login.BringToFront();
        }

        private void btn_RegistarAhora_Click(object sender, EventArgs e)
        {
            panel_Registro.BringToFront();
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Ingresar_Click(object sender, EventArgs e)
        {
            if (txt_Usuario.Text == "admin" && txt_Contraseña.Text == "admin")
            {
                new MenuPage().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos");
                txt_Usuario.Clear();
                txt_Contraseña.Clear();
                txt_Usuario.Focus();
            }
        }

        private void bnt_Registrar_Click(object sender, EventArgs e)
        {
            //register user to a list
        }
    }
}
