using CRUDpractice.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace CRUDpractice.Data
{
    public class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }

        public DbSet<Student> Students { get; set; } 

    }
    
}
