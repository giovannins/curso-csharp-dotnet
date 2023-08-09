using ArquiteturaCamadasREST.Models;

namespace ArquiteturaCamadasREST.Repository.Interfaces;

public interface ILivroRepository
{
    List<Livro> FindAll();
    Livro FindById(long id);
    Livro FindByAutor(string nome);
    Livro FindByAno(int ano);
    Livro Create(Livro livro);
    Livro Update(Livro livro);
    void Delete(long id);
}