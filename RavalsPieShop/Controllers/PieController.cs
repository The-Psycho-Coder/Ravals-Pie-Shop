using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RavalsPieShop.Models.Interfaces;

namespace RavalsPieShop.Controllers
{
    public class PieController : ControllerBase
    {
        private readonly IPieRepository _pieRepository;
        private readonly ICategoryRepository _categoryRepository;

        public PieController(IPieRepository pieRepository, ICategoryRepository categoryRepository)
        {
            _pieRepository = pieRepository;
            _categoryRepository = categoryRepository;
        }


    }
}
