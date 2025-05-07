using Microsoft.EntityFrameworkCore;
using RavalsPieShop.Models.Data;
using RavalsPieShop.Models.EntityFramework;
using RavalsPieShop.Models.Interfaces;

namespace RavalsPieShop.Models.Repositories
{
    public class PieRepository : IPieRepository
    {
        private readonly RavalsPieShopDbContext _ravalsPieShopDbContext;
        public PieRepository(RavalsPieShopDbContext ravalsPieShopDbContext)
        {
            _ravalsPieShopDbContext = ravalsPieShopDbContext;
        }

        public IEnumerable<Pie> AllPies => _ravalsPieShopDbContext.Pies.Include(c => c.Category);
        public IEnumerable<Pie> PiesOfTheWeek => _ravalsPieShopDbContext.Pies.Include(c => c.Category).Where(p => p.IsPieOfTheWeek);
        public IEnumerable<Pie> SearchPies(string searchQuery) => _ravalsPieShopDbContext.Pies.Include(c => c.Category).Where(p => p.Name.ToLower().Contains(searchQuery.ToLower())).ToList();
        public Pie? GetPieById(int pieId) => _ravalsPieShopDbContext.Pies.Include(c => c.Category).FirstOrDefault(p => p.PieId == pieId);

    }
    
}
