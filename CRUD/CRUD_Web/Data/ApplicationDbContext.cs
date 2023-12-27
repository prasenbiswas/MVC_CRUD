using CRUD_Web.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace CRUD_Web.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Category> categories { get; set; }
    }
}
