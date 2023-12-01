using AplicacaoLanches.Context;
using AplicacaoLanches.Models;
using AplicacaoLanches.Repository.InterfacesRepository;
using Microsoft.EntityFrameworkCore;

namespace AplicacaoLanches.Repository
{
    public class LancheRepository : ILancheRepository
    {
        private readonly AppDbContext _context;

        public IEnumerable<Lanche> Lanches => _context.Lanches.Include(c => c.Categoria);

        public IEnumerable<Lanche> LanchesPreferidos => _context.Lanches.Where(p => p.IsLanchePreferido == true).Include(c => c.Categoria);



        public LancheRepository(AppDbContext context)
        {
            _context = context;   
        }

        public Lanche GetLancheById(int id)
        {
            return _context.Lanches.FirstOrDefault(i => i.LancheId == id);
        }
    }
}
