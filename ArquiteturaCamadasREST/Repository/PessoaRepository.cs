using ArquiteturaCamadasREST.Models;
using ArquiteturaCamadasREST.Models.Context;
using ArquiteturaCamadasREST.Repository.Interfaces;

namespace ArquiteturaCamadasREST.Repository;

public class PessoaRepository : IPessoaRepository
{
    private readonly MySQLContext _context;
    public PessoaRepository(MySQLContext context)
    {
        _context = context;
    }

    public Pessoa Create(Pessoa pessoa)
    {
        throw new NotImplementedException();
    }

    public void Delete(long id)
    {
        throw new NotImplementedException();
    }

    public List<Pessoa> FindAll()
    {
        throw new NotImplementedException();
    }

    public Pessoa FindById(long id)
    {
        throw new NotImplementedException();
    }

    public Pessoa Update(Pessoa pessoa)
    {
        throw new NotImplementedException();
    }
}