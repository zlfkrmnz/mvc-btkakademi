using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StoreApp.Models;

namespace StoreApp.Controllers
{
    public class ProductController : Controller
    {
        private readonly RepositoryContext _repositoryContext;
        public ProductController(RepositoryContext repositoryContext)
        {
            _repositoryContext = repositoryContext;
        }
        public IActionResult Index()
        {
            var model = _repositoryContext.Products.ToList();
            return View(model);
        }

        public IActionResult Get(int id)
        {
            Product product = _repositoryContext.Products.First(p => p.ProductId == id);
            return View(product);
        }
    }
}
