using Microsoft.EntityFrameworkCore;

namespace ArquiteturaCamadasREST.Models.Context;

public class MySQLContext : DbContext
{
    public MySQLContext() { }

    public MySQLContext(DbContextOptions<MySQLContext> options) : base(options) { }
    public DbSet<Emprestado> Emprestados { get; set; }
    public DbSet<Livro> Livros { get; set; }
    public DbSet<Pessoa> Pessoas { get; set; }
}