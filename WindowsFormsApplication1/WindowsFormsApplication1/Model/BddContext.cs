using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace CasseBrique.Model
{
    public class BddContext : DbContext
    {
        public DbSet<Model_User> Users { get; set; }
    }
}
