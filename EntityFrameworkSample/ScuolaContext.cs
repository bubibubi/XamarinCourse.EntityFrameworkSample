using System;
using System.Data.Entity;

namespace EntityFrameworkSample
{
class ScuolaContext : DbContext
{
    public ScuolaContext() : base("DefaultConnection")
    {
        JetEntityFrameworkProvider.JetConnection.ShowSqlStatements = true;
    }

    public DbSet<Studente> Studenti { get; set; }
    public DbSet<Classe> Classi { get; set; }

    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Studente>()
            .ToTable("Studenti")
            .HasKey(e => e.Id)
            .Property(e => e.Nome).HasMaxLength(50);

        modelBuilder.Entity<Classe>()
            .ToTable("Classi")
            .HasKey(e => e.Id)
            .Property(e => e.Nome).HasMaxLength(10);

        modelBuilder.Entity<Studente>()
            .HasOptional(e => e.Classe)
            .WithMany(e => e.Studenti);
    }
}
}
