using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTier101_Live
{
    internal class DBOperation
    {
        private SqlDataAdapter dataAdapter;
        public SqlConnection Connection { get; set; }

        // constructor
        public DBOperation()
        {
            dataAdapter = new SqlDataAdapter();
            
            Connection = new SqlConnection(@"Data Source=EGITMEN\PC;Initial Catalog=NTier101DB;Integrated Security=True;TrustServerCertificate=True;");
        }




    }
}
