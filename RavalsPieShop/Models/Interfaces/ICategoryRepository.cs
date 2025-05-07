using RavalsPieShop.Models.Data;

namespace RavalsPieShop.Models.Interfaces
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> AllCategories { get; }

    }
}
