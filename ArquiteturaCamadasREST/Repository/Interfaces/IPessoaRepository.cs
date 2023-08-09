using ArquiteturaCamadasREST.Models;

namespace ArquiteturaCamadasREST.Repository.Interfaces;

public interface IPessoaRepository
{
    List<Pessoa> FindAll();
    Pessoa GetById(long id);
    Pessoa Create(Pessoa pessoa);
    Pessoa Update(Pessoa pessoa);
    Pessoa Delete(long id);
}