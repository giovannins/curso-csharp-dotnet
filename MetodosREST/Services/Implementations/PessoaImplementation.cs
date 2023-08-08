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
            try
            {
                _context.Pessoas.Add(pessoa);
                _context.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }

            return pessoa;
        }

        public void Delete(long id)
        {
            Pessoa pessoa = _context.Pessoas.FirstOrDefault(p => p.Id == id);
            if (pessoa != null)
            {
                try
                {
                    _context.Pessoas.Remove(pessoa);
                    _context.SaveChanges();
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        public List<Pessoa> FindAll()
        {
            return _context.Pessoas.ToList();
        }

        public Pessoa FindById(long id)
        {
            return _context.Pessoas.FirstOrDefault(predicate: p => p.Id == id);
        }

        public Pessoa Update(Pessoa pessoa)
        {
            if (!Exists(pessoa.Id)) return new Pessoa();

            Pessoa resultado = _context.Pessoas.FirstOrDefault(p => p.Id == pessoa.Id);
            if (resultado != null)
            {
                try
                {
                    _context.Pessoas.Update(pessoa);
                    _context.SaveChanges();
                }
                catch (Exception)
                {
                    throw;
                }
            }
            return pessoa;
        }

        private bool Exists(long id)
        {
            return _context.Pessoas.Any(p => p.Id == id);
        }
    }
}