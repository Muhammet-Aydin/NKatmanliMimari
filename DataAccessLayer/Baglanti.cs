using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DataAccessLayer
{
    public class Baglanti
    {
        public static SqlConnection bgl = new SqlConnection(@"data source = DESKTOP - 3341JEP\SQLEXPRESS; initial catalog = DbPersonel; integrated security = True; MultipleActiveResultSets=True;App=EntityFramework");

    }
}
