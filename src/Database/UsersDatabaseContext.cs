using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace myfirstapi.src.Database
{
    public class UsersDatabaseContext : DbContext
    {
        public UsersDatabaseContext(DbContextOptions<UsersDatabaseContext> options) : base(options) { }

        public DbSet<UserModel> Users { get; set; }
    }
}