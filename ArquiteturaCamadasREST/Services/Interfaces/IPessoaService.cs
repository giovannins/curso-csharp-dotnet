using ArquiteturaCamadasREST.Models;

namespace ArquiteturaCamadasREST.Services.Interfaces;

public interface IPessoaService
{
    List<Pessoa> FindAll();
    Pessoa Create(Pessoa pessoa);
}