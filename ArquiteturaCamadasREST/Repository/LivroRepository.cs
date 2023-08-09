using ArquiteturaCamadasREST.Models;
using ArquiteturaCamadasREST.Models.Context;
using ArquiteturaCamadasREST.Repository.Interfaces;

namespace ArquiteturaCamadasREST.Repository;

public class LivroRepository : ILivroRepository
{
    private readonly MySQLContext _context;
    public LivroRepository(MySQLContext context)
    {
        _context = context;
    }

    public Livro Create(Livro livro)
    {
        throw new NotImplementedException();
    }

    public void Delete(long id)
    {
        throw new NotImplementedException();
    }

    public List<Livro> FindAll()
    {
        throw new NotImplementedException();
    }

    public Livro FindByAno(int ano)
    {
        throw new NotImplementedException();
    }

    public Livro FindByAutor(string nome)
    {
        throw new NotImplementedException();
    }

    public Livro FindById(long id)
    {
        throw new NotImplementedException();
    }

    public Livro Update(Livro livro)
    {
        throw new NotImplementedException();
    }
}