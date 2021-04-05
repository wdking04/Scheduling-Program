using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WInstonKingC969.Universal
{// Sql database info
    class DatabaseSQL
    {
        public static string Server = "3.227.166.251";
        public static string Database = "U06D4F";
        public static string Uid = "U06D4F";
        public static string Password = "53688729876";

        public static string ConnectionString => $"SERVER={Server}; DATABASE={Database}; Uid ={Uid}; Pwd={Password}; SslMode=None; Convert Zero Datetime = true";
    }
}
