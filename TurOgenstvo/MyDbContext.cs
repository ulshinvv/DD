using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TurOgenstvo.model;

namespace TurOgenstvo
{
    internal class MyDbContext: DbContext
    {
        public string connectionString = @"Data Source=VOVA; Initial Catalog=ttt3t; Integrated Security=true;";

        public DbSet<Тур> Тур {  get; set; }


    }
}
