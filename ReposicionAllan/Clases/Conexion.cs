
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReposicionAllan.Clases
{
    public class Conexion
    {
        private static string CadenaConexion()
        {

            return ConfigurationManager.ConnectionStrings["repodb"].ConnectionString;
        }

        protected static IDbConnection Conectar()
        {
            IDbConnection db = new SQLiteConnection(CadenaConexion());
            return db;
        } 
    }
}
