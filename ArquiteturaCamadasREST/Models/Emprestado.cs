using System.ComponentModel.DataAnnotations.Schema;

namespace ArquiteturaCamadasREST.Models;

[Table("emprestado")]
public class Emprestado
{
    [Column("id")]
    public long Id { get; set; }
    [Column("data_emprestado")]
    public DateTime DataEmprestado { get; set; }
    [Column("pessoa_id")]
    public long PessoaId { get; set; }
    [Column("livro_id")]
    public long LivroId { get; set; }
    public Pessoa Pessoa { get; set; }
    public Livro Livro { get; set; }
}