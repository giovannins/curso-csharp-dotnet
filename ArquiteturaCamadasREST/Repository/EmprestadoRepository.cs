using ArquiteturaCamadasREST.Models;
using ArquiteturaCamadasREST.Models.Context;
using ArquiteturaCamadasREST.Repository.Interfaces;

namespace ArquiteturaCamadasREST.Repository;

public class EmprestadoRepository : IEmprestadoRepository
{

    private readonly MySQLContext _context;

    public EmprestadoRepository(MySQLContext context)
    {
        _context = context;
    }

    public Emprestado Borrowing(Emprestado emprestado)
    {
        throw new NotImplementedException();
    }

    public List<Emprestado> FindAll()
    {
        throw new NotImplementedException();
    }

    public Emprestado FindById(long id)
    {
        throw new NotImplementedException();
    }

    public List<Emprestado> FindByLivro(long livroId)
    {
        throw new NotImplementedException();
    }

    public List<Emprestado> FindByPessoa(long pessoaId)
    {
        throw new NotImplementedException();
    }

    public void Return(long id)
    {
        throw new NotImplementedException();
    }
}