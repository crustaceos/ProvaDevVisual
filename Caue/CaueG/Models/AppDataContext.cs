namespace CaueG.Models;

using Microsoft.EntityFrameworkCore;

public class AppDataContext : DbContext
{
    public DbSet<Funcionario> Funcionarios { get; set; }
    public DbSet<Folha> Folhas { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=caueGoncalves.db");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Folha>()
            .HasOne(f => f.Funcionario) 
            .WithMany(f => f.Folhas) 
            .HasForeignKey(f => f.FuncionarioId); 
    }
}

