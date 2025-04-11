using Login.Dominio;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login.Presentadores
{
    public class AgregarUsuarioPresenter
    {
        //private readonly Conexion conexion;

        //public AgregarUsuarioPresenter()
        //{
        //}

        //public AgregarUsuarioPresenter(Conexion conexion)
        //{
        //    this.conexion = conexion;
        //}
        //public void AgregarUsuario(Usuario usuario)
        //{
        //    string consulta = "INSERT INTO Usuarios (Nombre, Apellido, Correo, Contraseña) VALUES (@Nombre, @Apellido, @Correo, @Contraseña)";

        //    if (conexion.ConectarConDB())
        //    {
        //        try
        //        {
        //            SqlCommand comando = new SqlCommand(consulta);
        //            comando.Parameters.AddWithValue("@Nombre",usuario.Nombre);
        //            comando.Parameters.AddWithValue("@Apellido", usuario.Apellido);
        //            comando.Parameters.AddWithValue("@Correo", usuario.Correo);
        //            comando.Parameters.AddWithValue("@Contraseña", usuario.Contraseña);

        //        }
        //        catch (Exception)
        //        {

        //            throw;
        //        }
        //    }
        //}
    }
}
