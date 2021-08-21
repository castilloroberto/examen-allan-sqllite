using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReposicionAllan.Clases
{
    public class DataBase:Conexion
    {


        public static List<Contacto> ObtenerContactos()
        {
            //conectar vien de la clase padre "Conexion"
            using (var db = Conectar())
            {
                return db.Query<Contacto>("select * from Contacto").ToList();
            }

        }

        public static bool InsertarContacto(Contacto contacto)
        {
            using (var db = Conectar())
            {

                int res = db.Execute(@"Insert into Contacto(Codigo,Nombres,Apellidos,Direccion,TelFijo,Celular) 
                                values (@Codigo,@Nombres,@Apellidos,@Direccion,@TelFijo,@Celular)", contacto);
                return res > 0;
            }
        }

    }
}
