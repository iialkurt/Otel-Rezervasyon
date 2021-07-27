using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Otel_Rezervasyon
{
    class SqlBaglantisi
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection(@"Data Source=DESKTOP-31VI8OS\SQLEXPRESS;Initial Catalog=OtelRezervasyon;Integrated Security=True");
            baglan.Open();
            return baglan;
        }

    }
}
        
       

