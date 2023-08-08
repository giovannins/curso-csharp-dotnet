using MetodosREST.Models;
using MetodosREST.Models.Context;

namespace MetodosREST.Services.Implementations
{
    public class PessoaServiceImplementation : IPessoaService
    {

        private readonly MySQLContext _context;

        public PessoaServiceImplementation(MySQLContext context)
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
}