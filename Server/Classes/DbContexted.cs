using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace Server.Classes
{
    public class DbContexted : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<BlackList> blackLists { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseMySql(
                "server=127.0.0.1;port=3306;database=license;user=root;password=",
                new MySqlServerVersion(new Version(8, 0)));
        }

    }
}
