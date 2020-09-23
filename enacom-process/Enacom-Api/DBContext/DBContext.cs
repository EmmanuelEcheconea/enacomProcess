using Enacom_Api.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Enacom_Api.DBContext
{
    public class DBContext : DbContext
    {
        public DbSet<Noticias> noticias { get; set; }

        public DBContext (DbContextOptions<DBContext> options): base(options)
        {

        }


    }
}
