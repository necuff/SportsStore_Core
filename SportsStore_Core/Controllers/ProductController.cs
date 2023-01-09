using Microsoft.AspNetCore.Mvc;
using SportsStore_Core.Models;

namespace SportsStore_Core.Controllers
{
    public class ProductController : Controller
    {
        private IProductRepository repository;

        public ProductController(IProductRepository repo)
        {
            repository = repo;
        }

        public ViewResult List() => View(repository.Products);
    }
}
