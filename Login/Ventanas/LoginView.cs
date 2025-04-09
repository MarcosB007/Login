using Login.Interfaces;
using Login.Presentadores;

namespace Login
{
    public partial class LoginView : Form
    {
        ValidarUsuarioPresenter presentador = new ValidarUsuarioPresenter();
        public LoginView()
        {
            InitializeComponent();
        }
        
        private void btn_Conectar(object sender, EventArgs e)
        {
            string usuario = tbUsuario.Text;
            string contraseña = tbPassword.Text;
            //btnIngresar.Text = "Boton apretado";
            bool resultadoConexion = Conexion.ConectarConDB();
            if (resultadoConexion)
            {
                bool resultadoConsulta = presentador.Validar(usuario, contraseña);
                if (resultadoConsulta)
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrecta");
                }
            }

        }

    }
}
