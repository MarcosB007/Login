using Login.Interfaces;
using Login.Presentadores;

namespace Login
{
    public partial class Form1 : Form
    {
        ValidarUsuarioPresenter presentador = new ValidarUsuarioPresenter();
        public Form1()
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
                presentador.Validar(usuario, contraseña);
            }

        }

    }
}
