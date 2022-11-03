using System.Data.SqlClient;

namespace DataAccess.Generic.Context
{
    public static class Db
    {
        public static SqlConnection GetConnection()
        {
            var con = new SqlConnection
            {
                ConnectionString = "Data Source=DG;Initial Catalog=ECommerce2021; Persist Security Info=True; MultipleActiveResultSets=True; User ID=sa; password=123D654!;"
            };
            return con;
        }
    }
}
