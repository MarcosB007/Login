using Login.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login.Presentadores
{
    public class ValidarUsuarioPresenter: IValidarUsuario
    {
        public bool Validar(string user, string password)
        {
            string cadenaDeConexion = "Server=MARCOS;Database=UsuariosDB;Integrated Security=True;";
            string consulta = "SELECT COUNT() FROM Usuarios WHERE Correo = @user AND Contraseña = @password";

            using (SqlConnection conexion = new SqlConnection(cadenaDeConexion))
            {

                SqlCommand comando = new SqlCommand(consulta, conexion);
                comando.Parameters.AddWithValue("@user", user);
                comando.Parameters.AddWithValue("@password", password);

                try
                {
                    conexion.Open();
                    int cantidad = (int)comando.ExecuteScalar();
                    if(cantidad > 0) return true;
                    else return false;
                }
                catch (Exception)
                {
                    return true;
                }
            }

            
        }
    }
}
