using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace AccSamse._1._1.Models
{
    internal class ConexionDataBase
    {
        private string cadenaConexion = "" +
                "Data Source=KEXXX\\SQLEXPRESS;Initial " +
                "Catalog=AccSamseDb;" +
                "Integrated Security=True";
        public SqlConnection conectDb = new SqlConnection();

        public ConexionDataBase()
        {
            conectDb.ConnectionString = cadenaConexion;
        }

        public void openConnection()
        {
            try
            {
                conectDb.Open();
                System.Windows.Forms.MessageBox.Show("Conexion Exitosa");
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Error de conexion: " + 
                    ex.ToString());
            }
        }

        public void closeConnection()
        {
            try
            {
                conectDb.Close();
                System.Windows.Forms.MessageBox.Show("Conexion Cerrada");
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(
                    "Error al cerrar la conexion: " + ex.ToString());
            }
        }

    }
}
