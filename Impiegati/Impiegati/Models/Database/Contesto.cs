using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Impiegati.Models.Database
{
    public class Contesto:DbContext
    {
        public Contesto(DbContextOptions<Contesto> opzioni):base(opzioni)
        {

        }

        public DbSet<Impiegato> Impiegati { get; set; }
        public DbSet<Dipartimento> Dipartimenti { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Impiegato>().Property(x => x.Id).IsRequired().UseSqlServerIdentityColumn();
            modelBuilder.Entity<Impiegato>().Property(x => x.Nome).IsRequired();
            modelBuilder.Entity<Impiegato>().Property(x => x.Datanascita).IsRequired();
            modelBuilder.Entity<Impiegato>().Property(x => x.Dataassunzione).IsRequired();
            modelBuilder.Entity<Impiegato>().Property(x => x.Dipartimento);
            modelBuilder.Entity<Impiegato>().HasKey(x => x.Id);
            modelBuilder.Entity<Impiegato>().HasOne(x => x.DipartimentoNavigation).WithMany(x => x.Impiegati).HasForeignKey(x => x.Dipartimento).OnDelete(DeleteBehavior.Cascade);


            modelBuilder.Entity<Dipartimento>().Property(x => x.Id).IsRequired().UseSqlServerIdentityColumn();
            modelBuilder.Entity<Dipartimento>().Property(x => x.Nome).IsRequired();
            modelBuilder.Entity<Dipartimento>().Property(x => x.Area).IsRequired();
            modelBuilder.Entity<Dipartimento>().Property(x => x.Manager);
            modelBuilder.Entity<Dipartimento>().HasKey(x => x.Id);
            modelBuilder.Entity<Dipartimento>().HasOne(x => x.ImpiegatoNavigation).WithMany(x => x.Dipartimenti).HasForeignKey(x => x.Manager).OnDelete(DeleteBehavior.Cascade);





        }
    }
}
