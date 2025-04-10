using Login.Dominio;
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
        public RegistrarClienteView()
        {
            InitializeComponent();
        }

        private void btnAgregarUsuario_Click(object sender, EventArgs e)
        {
            string name = textBoxNombre.Text;
            string lastname = textBoxApellido.Text;
            string dni = textBoxDNI.Text;
            string correo = textBoxCorreo.Text;
            string password = textBoxContraseña.Text;

            Usuario usuario = new Usuario();
            usuario.Nombre = name;
            usuario.Apellido = lastname;
            usuario.DNI = dni;
            usuario.Correo = correo;
            usuario.Contraseña = password;

        }
    }
}
