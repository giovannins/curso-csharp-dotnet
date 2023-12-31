using ArquiteturaCamadasREST.Models;

namespace ArquiteturaCamadasREST.Repository.Interfaces;

public interface IEmprestadoRepository
{
    Emprestado Borrowing(Emprestado emprestado);
    void Return(long id);
    List<Emprestado> FindAll();
    Emprestado FindById(long id);
    List<Emprestado> FindByPessoa(long pessoaId);
    List<Emprestado> FindByLivro(long livroId);
}