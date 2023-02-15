using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace new_supermarket
{
    class DBConnect
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        private string con;
        public string myconnection()
        {
            con = @"Data Source=HARRISON-MURAYA;Initial Catalog=point_of _sale;Integrated Security=True";
            return con;
        }
        public DataTable getTable(string qury)
        {
            cn.ConnectionString = myconnection();
            cm = new SqlCommand(qury, cn);
            SqlDataAdapter adapter = new SqlDataAdapter(cm);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
    }
}
