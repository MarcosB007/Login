using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace Login
{
    public class Conexion
    {
        public static void ConectarConDB()
        {
            string cadenaDeConexion = "Server=MARCOS;Database=UsuariosDB;Integrated Security=True;";

            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaDeConexion))
                {
                    conexion.Open();
                    //Console.WriteLine("Conexion exitosa.");
                    //MessageBox.Show("Conexion exitosa");

                }
            }
            catch (Exception ex) 
            {
                //Console.WriteLine($"Error al conectar con la base de datos: {ex.Message}");
                MessageBox.Show($"Error en la conexion {ex.Message}");
            }
        }
    }
}
