using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace CapaDatos
{
    public class Conexion
    {
        //Data Source=192.168.1.85\COMPAC;Initial Catalog=DB_SISTEMATICKETS;Persist Security Info=True;User ID=sa; password=contpaqi
        //Server=localhost\SQLEXPRESS;Database=DB_SISTEMAVENTAS;Trusted_Connection=True;
        //public static string cadena = "Server=localhost\\SQLEXPRESS;Database=DB_SISTEMATICKETS;Trusted_Connection=True;";
        public static string cadena = @"Data Source=192.168.1.85\COMPAC;Initial Catalog=DB_SISTEMATICKETS;Persist Security Info=True;User ID=sa; password=contpaqi";
    }
}
