using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlPenitenciario
{
    public class DataAccess
    {

        public Usuarios Auth(Usuarios usuario)
        {
            using (IDbConnection db = new SqlConnection(Helper.ConnectionValue("ControlPenitenciariaDb")))
            {
                var result = db.Query<Usuarios>($"SELECT * FROM usuarios WHERE Nick = '{usuario.Nick}' AND contra = '{usuario.contra}' ");
                return result.FirstOrDefault();
            }

            //return null ;
        }

    }
}
