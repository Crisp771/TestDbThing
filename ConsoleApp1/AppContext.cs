using System.Data.SqlClient;
using Project2.Model;

namespace ConsoleApp1
{
    public class AppContext :Project2Context
    {
        public AppContext(string connectionString): base(connectionString)
        {
            
        }
    }
}
