using System;
using JoaoLuizDev.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace JoaoLuizDev.Models
{
    public class DefaultConectionContext : DbContext
    {
        public DefaultConectionContext()
        {
        }

        public DefaultConectionContext(DbContextOptions<DefaultConectionContext> options)
            : base(options)
        {
        }

        public virtual DbSet<SocialMedia> SocialMedia { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {

                optionsBuilder.UseSqlite("Server=(localdb)\\mssqllocaldb;Database=aspnet-JoaoLuizDevAdmin-B09D1114-2631-4D6B-860D-8F31A3477AE5;Trusted_Connection=True;MultipleActiveResultSets=true");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SocialMedia>(entity =>
            {
                entity.Property(e => e.Descricao).HasMaxLength(100);

                entity.Property(e => e.Icon).HasMaxLength(100);
            });
        }
    }
}