using System.ComponentModel.DataAnnotations.Schema;

namespace ArquiteturaCamadasREST.Models;

[Table("livro")]
public class Livro
{
    [Column("id")]
    public long Id { get; set; }
    [Column("nome")]
    public string Nome { get; set; }
    [Column("autor")]
    public string Autor { get; set; }
    [Column("edicao")]
    public int Edicao { get; set; }
    [Column("ano")]
    public int Ano { get; set; }
    public ICollection<Emprestado> Emprestado { get; set; }

}