using ArquiteturaCamadasREST.Models;
using ArquiteturaCamadasREST.Models.Context;
using ArquiteturaCamadasREST.Repository.Interfaces;

namespace ArquiteturaCamadasREST.Repository;

public class PessoaRepository : IPessoaRepository
{
    private readonly MySQLContext _context;
    private readonly ILogger<PessoaRepository> _logger;
    public PessoaRepository(MySQLContext context, ILogger<PessoaRepository> logger)
    {
        _logger = logger;
        _context = context;
    }

    public Pessoa Create(Pessoa pessoa)
    {
        if (pessoa == null)
        {
            return new Pessoa();
        }

        try
        {
            _context.Pessoas.Add(pessoa);
            _context.SaveChanges();
        }
        catch (Exception ex)
        {
            _logger.LogError(ex.Message.ToString());
            throw;
        }
        return pessoa;

    }

    public void Delete(long id)
    {
        throw new NotImplementedException();
    }

    public List<Pessoa> FindAll()
    {
        return _context.Pessoas.ToList();
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