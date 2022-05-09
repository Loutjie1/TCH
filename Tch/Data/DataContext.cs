using Microsoft.EntityFrameworkCore;
using Tch.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options) { }
        public DbSet<Company> Companies { get; set; }
        public DbSet<User> Users { get; set; }

    }
}
