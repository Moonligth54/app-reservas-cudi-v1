using WinFormsApp1.Services;

namespace WinFormsApp1
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoginService loginService = new LoginService();

            if (!loginService.ValidarCampos(txtUsuario.Text, txtContraseña.Text))
            {
                MessageBox.Show("Complete todos los campos.");
                return;
            }

            bool acceso = loginService.IniciarSesion(txtUsuario.Text, txtContraseña.Text);

            if (acceso)
            {
                MessageBox.Show("Bienvenido.");
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos.");
            }
        }
    }
}
