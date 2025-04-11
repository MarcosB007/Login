using Login.Interfaces;
using Login.Presentadores;

namespace Login
{
    public partial class LoginView : Form, ILoginView
    {
        private ValidarUsuarioPresenter _presentador;
        public LoginView()
        {
            InitializeComponent();
            _presentador = new ValidarUsuarioPresenter(this);
        }


        private void btn_Conectar(object sender, EventArgs e)
        {
            string usuario = tbUsuario.Text;
            string contrase�a = tbPassword.Text;
            //btnIngresar.Text = "Boton apretado";
            bool resultadoConexion = Conexion.ConectarConDB();
            if (resultadoConexion)
            {
                bool resultadoConsulta = _presentador.Validar(usuario, contrase�a);
                if (resultadoConsulta)
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Usuario o contrase�a incorrecta");
                }
            }

        }

    }
}
