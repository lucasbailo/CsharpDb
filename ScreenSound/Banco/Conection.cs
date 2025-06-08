using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using ScreenSound.Modelos;
using static System.Net.Mime.MediaTypeNames;

namespace ScreenSound.Banco
{
    internal class Conection
    {

        private string conectionString = "Data Source=DEVFRONT;Integrated Security=True;Initial Catalog=ScreenSoundDb;Encrypt=False;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False";

        public SqlConnection ObterConexao()
        {
            return new SqlConnection(conectionString);
        }
    }
}
