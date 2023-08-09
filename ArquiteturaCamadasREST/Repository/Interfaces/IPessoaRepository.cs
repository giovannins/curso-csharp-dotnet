using ArquiteturaCamadasREST.Models;

namespace ArquiteturaCamadasREST.Repository.Interfaces;

public interface IPessoaRepository
{
    List<Pessoa> FindAll();
    Pessoa FindById(long id);
    Pessoa Create(Pessoa pessoa);
    Pessoa Update(Pessoa pessoa);
    void Delete(long id);
}