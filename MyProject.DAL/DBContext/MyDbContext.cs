using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using MyProject.MODEL;

namespace MyProject.DAL.DBContext;

public partial class MyDbContext : DbContext
{
    public MyDbContext()
    {
    }

    public MyDbContext(DbContextOptions<MyDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Livro> Livros { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\project-multilayer\\MyProject.DAL\\database\\Database.mdf;Integrated Security=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Livro>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__tmp_ms_x__3214EC07205CA66E");

            entity.ToTable("Livro");

            entity.Property(e => e.Autor)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Editora)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Resumo).HasColumnType("text");
            entity.Property(e => e.Titulo)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
