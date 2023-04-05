// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Text;
// using System.Threading.Tasks;
using System.Data.SqlClient;
using System;

namespace canalsat.Models{
    public class Connection{
        public SqlConnection connection(){
        //parameter
            string connString = "Server=ETU1763-FANDRES;Database=canalsat;Trusted_Connection=True;";
        
        //connection
            SqlConnection conn = new SqlConnection(connString);
            return conn;
        }
    }
}
