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
        public AgregarUsuarioPresenter()
        {
        }

        public void AgregarUsuario(Usuario usuario)
        {
            string consulta = "INSERT INTO Clientes (Nombre, Apellido, Correo, DNI, Edad) VALUES (@Nombre, @Apellido, @Correo, @DNI, @Edad)";

            if (Conexion.ConectarConDB())
            {
                try
                {
                    SqlCommand comando = new SqlCommand(consulta, Conexion.conexion);
                    comando.Parameters.AddWithValue("@Nombre", usuario.Nombre);
                    comando.Parameters.AddWithValue("@Apellido", usuario.Apellido);
                    comando.Parameters.AddWithValue("@Correo", usuario.Correo);
                    comando.Parameters.AddWithValue("@DNI", usuario.DNI);
                    comando.Parameters.AddWithValue("@Edad", usuario.Edad);

                    comando.ExecuteNonQuery();

                }
                catch (Exception ex)
                {
                    throw new Exception($"Error al cargar el cliente: {ex}");
                }
                finally
                {
                    Conexion.DesconectarDB();
                }
            }
        }
    }
}
