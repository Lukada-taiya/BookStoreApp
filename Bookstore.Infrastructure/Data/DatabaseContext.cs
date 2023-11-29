using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bookstore.Application.DTOs;
using Bookstore.Domain.Models;
using Microsoft.EntityFrameworkCore; 

namespace Bookstore.Infrastructure.Data
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options) 
        {
            
        }

        public DbSet<Book> Books {  get; set; }
        public DbSet<Book> Orders {  get; set; }
        public DbSet<Book> OrderItems { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<BookDto>().HasNoKey();
            modelBuilder.Entity<CreateUpdateBookDto>().HasNoKey(); 
            modelBuilder.Entity<Book>(entity =>
            {
                entity.HasKey(e => e.Id);
            });
            modelBuilder.Entity<Order>(entity =>
            {
                entity.HasKey(e => e.Id);
            });
            modelBuilder.Entity<OrderItem>(entity =>
            {
                entity.HasKey(e => e.Id);                
            });
             
            //Setting Database type for decimal columns
            var decimalProps = modelBuilder.Model
            .GetEntityTypes()
            .SelectMany(t => t.GetProperties())
            .Where(p => (System.Nullable.GetUnderlyingType(p.ClrType) ?? p.ClrType) == typeof(decimal));

            foreach (var property in decimalProps)
            {
                property.SetPrecision(18);
                property.SetScale(2);
            }
        }
    }
}
