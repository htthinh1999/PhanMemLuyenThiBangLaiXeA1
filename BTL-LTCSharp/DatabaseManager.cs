using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_LTCSharp
{
    class DatabaseManager
    {
        public static string username;

        static SqlConnection sqlConnection = new SqlConnection(@"Data Source=DESKTOP-UIBSI5T;Initial Catalog=BTLThiLaiXe; User ID=sa; Password=123456;");
        static SqlDataAdapter sqlData;

        public static void GetData()
        {
            sqlData = new SqlDataAdapter("Select * from CauHoi", sqlConnection);
            DataTable dataTable = new DataTable();
            sqlData.Fill(dataTable);
            foreach(DataRow row in dataTable.Rows)
            {
                Console.WriteLine(row[1]);
            }
        }

        public static DataTable executeQuery(string sql)
        {
            sqlData = new SqlDataAdapter(sql, sqlConnection);
            DataTable dataTable = new DataTable();
            sqlData.Fill(dataTable);
            return dataTable;
        }
    }
}
