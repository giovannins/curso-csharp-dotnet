using System.ComponentModel.DataAnnotations.Schema;

namespace ArquiteturaCamadasREST.Models;

[Table("pessoa")]
public class Pessoa
{
    [Column("id")]
    public long Id { get; set; }
    [Column("nome")]
    public string Nome { get; set; }
    [Column("sobrenome")]
    public string Sobrenome { get; set; }
    [Column("idade")]
    public int Idade { get; set; }
    [Column("genero")]
    public char Genero { get; set; }
    [Column("endereco")]
    public string Endereco { get; set; }
    public ICollection<Emprestado> Emprestado { get; set; }
}
