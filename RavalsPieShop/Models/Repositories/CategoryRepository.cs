using RavalsPieShop.Models.Data;
using RavalsPieShop.Models.EntityFramework;
using RavalsPieShop.Models.Interfaces;

namespace RavalsPieShop.Models.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly RavalsPieShopDbContext _ravalsPieShopDbContext;

        public CategoryRepository(RavalsPieShopDbContext ravalsPieShopDbContext)
        {
            _ravalsPieShopDbContext = ravalsPieShopDbContext;
        }

        public IEnumerable<Category> AllCategories => _ravalsPieShopDbContext.Categories.OrderBy(c => c.CategoryName);
    }
}
