using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codefirst_sample.Models
{
    public class TrainingContext : DbContext
    {
        public DbSet<book> books { get; set; } = null!;
        public DbSet<buyer> buyers { get; set; } =null!;
        public DbSet<author> author { get; set; } = null!;
        public DbSet<Customer> customer { get; set; } 
        public DbSet<Order> Orders { get; set; } 

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=LAPTOP-DT14ODGQ;Database=BookDb;Trusted_Connection=True;MultipleActiveResultSets=true;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Property Configurations

            modelBuilder.Entity<book>()
            .Property(b => b.bookage)
            .IsRequired() //[Required]
            .HasColumnName("Book_Age") //[Column("Book_Age")]
            .HasDefaultValue(2);
        }
        
    }

}
