using Login.Dominio;
using Login.Presentadores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Login.Ventanas
{
    public partial class RegistrarClienteView : Form
    {
        private AgregarUsuarioPresenter _presentador;
        public RegistrarClienteView()
        {
            InitializeComponent();
            _presentador = new AgregarUsuarioPresenter();
        }

        private void btnAgregarUsuario_Click(object sender, EventArgs e)
        {
            string name = textBoxNombre.Text;
            string lastname = textBoxApellido.Text;
            string dni = textBoxDNI.Text;
            string correo = textBoxCorreo.Text;
            string password = textBoxEdad.Text;

            Usuario usuario = new Usuario();
            usuario.Nombre = name;
            usuario.Apellido = lastname;
            usuario.DNI = dni;
            usuario.Correo = correo;
            usuario.Edad = int.Parse(password);

            _presentador.AgregarUsuario(usuario);

        }
    }
}
