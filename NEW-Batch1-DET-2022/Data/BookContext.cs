using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NEW_Batch1_DET_2022.Models
{
    public class BookContext : DbContext
    {
        public BookContext()
        {

        }


        public BookContext(DbContextOptions<BookContext> options)
            : base(options)
        {

        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }


        //public virtual DbSet<Book> Books { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
             {
            if (!optionsBuilder.IsConfigured)
             {
                //#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=H97NX52-SHEL\\SQLEXPRESS;Database=Training;Trusted_Connection=True;MultipleActiveResultSets = True");
                
            }
             }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Book>()
            //    .Property(x => x.price)
            //    .IsRequired() //Required
            //    .HasColumnName("BKPrice")
            //    .HasDefaultValue(200);

        }
    }
}
