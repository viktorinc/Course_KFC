using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Entities
{
    public class EFContext : DbContext
    {
        public EFContext() : base("KFC") { }
        public DbSet<Dish> Dishes { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
