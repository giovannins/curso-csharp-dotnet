using ArquiteturaCamadasREST.Models;
using ArquiteturaCamadasREST.Repository.Interfaces;
using ArquiteturaCamadasREST.Services.Interfaces;

namespace ArquiteturaCamadasREST.Services;

public class PessoaService : IPessoaService
{
    private readonly IPessoaRepository _pessoaRepository;

    public PessoaService(IPessoaRepository pessoaRepository)
    {
        _pessoaRepository = pessoaRepository;
    }

    public Pessoa Create(Pessoa pessoa)
    {
        if (pessoa == null)
        {
            return new Pessoa();
        }
        return _pessoaRepository.Create(pessoa);
    }

    public List<Pessoa> FindAll()
    {
        return _pessoaRepository.FindAll();
    }
}