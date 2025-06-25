using Microsoft.EntityFrameworkCore;
using Wallet.Domain.Entities;

namespace Wallet.Infrastructure.Data;
public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public DbSet<Domain.Entities.Usuario> Usuarios { get; set; }
    public DbSet<Domain.Entities.Wallet> Carteiras { get; set; }
    public DbSet<Domain.Entities.Transacoes> Transferencias { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Usuario>(entity =>
        {
            entity.ToTable("usuarios");

            entity.HasKey(u => u.Id);

            entity.Property(u => u.Nome).IsRequired().HasMaxLength(100);
            entity.Property(u => u.SobreNome).IsRequired().HasMaxLength(100);
            entity.Property(u => u.Cpf).IsRequired().HasMaxLength(14);
            entity.Property(u => u.DataNascimento).IsRequired();

            entity.HasIndex(u => u.Cpf).IsUnique();

            entity.HasOne(u => u.Wallet)
                  .WithOne(w => w.Usuario)
                  .HasForeignKey<Domain.Entities.Wallet>(w => w.UsuarioId)
                  .OnDelete(DeleteBehavior.Cascade);
        });

        modelBuilder.Entity<Domain.Entities.Wallet>(entity =>
        {
            entity.ToTable("wallets");

            entity.HasKey(w => w.Id);

            entity.Property(w => w.Saldo)
                  .HasColumnType("decimal(18,2)")
                  .IsRequired();

            entity.Property(w => w.UsuarioId)
                  .IsRequired();

            entity.HasIndex(w => w.UsuarioId)
                  .IsUnique(); // 1:1
        });

        modelBuilder.Entity<Transacoes>(entity =>
        {
            entity.ToTable("transacoes");

            entity.HasKey(t => t.Id);

            entity.Property(t => t.Valor)
                  .HasColumnType("decimal(18,2)")
                  .IsRequired();

            entity.Property(t => t.DataHora)
                  .IsRequired();

            entity.HasOne(t => t.FromUsuario)
                  .WithMany()
                  .HasForeignKey(t => t.FromUsuarioId)
                  .OnDelete(DeleteBehavior.Restrict);

            entity.HasOne(t => t.ToUsuario)
                  .WithMany()
                  .HasForeignKey(t => t.ToUsuarioId)
                  .OnDelete(DeleteBehavior.Restrict);
        });
    }

}