using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoligSystem.DataAccess
{
    internal class DbHandler
    {
        string ConnectionString;
        public DbHandler()
        {
            // skaber forbindelse til databasen, baseret på default serveren i App.config
            ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["default"].ToString();
        }

    }
}
