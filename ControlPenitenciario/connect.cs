using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlPenitenciario
{
    public class connect
    {
        public void abrir()
        {
            try
            {
                Connection = new SqlConnection("Data Source=(local);Initial Catalog=ControlPenitenciario;Trusted_Connection=True;");
                Connection.Open();
            }
            catch (Exception ex)
            {

            }
        }

        public SqlConnection Connection { get; set; }
        public SqlCommand Enunciado { get; set; }
        public SqlDataReader Respuesta { get; set; }
        
        public string contras (string NUser)
        {
            var result = "";
            try
            {
                abrir();
                Enunciado = new SqlCommand("select contra from usuarios where Nick='" + NUser + "'", Connection);
                Respuesta = Enunciado.ExecuteReader();

                if (Respuesta.Read())
                {
                    result = Respuesta.GetValue(Respuesta.GetOrdinal("contra")).ToString();
                    return result;
                }
                Connection.Close();
                return result;
            }
            catch (Exception ex)
            {
                Connection.Close();
                return result;
            }
        }
    }
}
