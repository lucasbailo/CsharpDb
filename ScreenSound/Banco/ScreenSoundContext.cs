using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using ScreenSound.Modelos;
using static System.Net.Mime.MediaTypeNames;

namespace ScreenSound.Banco
{
    internal class ScreenSoundContext: DbContext
    {
        public DbSet<Artista> Artistas { get; set; }
        public DbSet<Musica> Musicas { get; set; }

        private string conectionString = "Data Source=DEVFRONT;Integrated Security=True;Initial Catalog=ScreenSoundDbV2;Encrypt=False;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False";
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(conectionString);
        }
    }
}
