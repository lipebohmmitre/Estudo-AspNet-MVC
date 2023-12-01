using AplicacaoLanches.Context;
using AplicacaoLanches.Models;
using AplicacaoLanches.Repository.InterfacesRepository;

namespace AplicacaoLanches.Repository
{
    public class CategoriaRepository : ICategoriaRepository
    {
        private readonly AppDbContext _context;

        public CategoriaRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Categoria> Categorias => _context.Categorias;
    }
}
