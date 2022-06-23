using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;

namespace Ass1.DataAccess
{
    public class BaseDAL
    {
        public StockDataProvider dataProvider { get; set; } = null;
        public SqlConnection connection = null;
        //--------------------------------------------
        public BaseDAL()
        {
            var connnectionString = GetConnectionString();
            dataProvider = new StockDataProvider(connnectionString);
        }
        //--------------------------------------------
        public string GetConnectionString()
        {
            string connectionString;
            IConfiguration config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", true, true)
                .Build();
            connectionString = config["ConnectionString:ASS1_DB"];
            return connectionString;
        }
        //--------------------------------------------
        public void CloseConnection()
            => dataProvider.CloseConnection(connection);
    }//end class
}
