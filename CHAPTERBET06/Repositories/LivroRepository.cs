using CHAPTERBET06.Contexts;
using CHAPTERBET06.Models;

namespace CHAPTERBET06.Repositories
{
    public class LivroRepository
    {
        private readonly SqlContext _context;
        public LivroRepository(SqlContext context)
        {
            _context = context;
        }
        

        public List<Livro> Listar()
        {
            return _context.Livros.ToList();
        }
    }
}
