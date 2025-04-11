using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace Login
{
    public static class Conexion
    {
        public static SqlConnection conexion;
        public static bool ConectarConDB()
        {
            string cadenaDeConexion = "Server=MARCOS;Database=UsuariosDB;Integrated Security=True;";

            try
            {
                
                conexion = new SqlConnection(cadenaDeConexion);
                conexion.Open();
                return true;
                //Console.WriteLine("Conexion exitosa.");
                //MessageBox.Show("Conexion exitosa");
                
            }
            catch (Exception ex) 
            {
                //Console.WriteLine($"Error al conectar con la base de datos: {ex.Message}");
                MessageBox.Show($"Error en la conexion {ex.Message}");
                return false;
            }
        }

        public static void DesconectarDB()
        {
            if (conexion != null && conexion.State == System.Data.ConnectionState.Open)
            {
                conexion.Close();
            }
        }
        
    }
}
