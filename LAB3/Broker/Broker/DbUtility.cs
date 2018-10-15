using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace Broker
{
    class DbUtility
    {
        public static readonly string connString = @"Data Source=.\;Initial Catalog=Theme;Integrated Security=True";


        public static Theme GetThemeFromDb(int themeid)
        {
            Theme t;

            using (SqlConnection conn = new SqlConnection(DbUtility.connString))
            {
                t = conn.QueryFirstOrDefault<Theme>($"SELECT * FROM Theme WHERE id = @id", new { id = themeid});
            }
            return t;
        }
    }
}
