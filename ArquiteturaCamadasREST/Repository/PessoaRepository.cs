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
}