using ASP_013_api.Model;
using Microsoft.AspNetCore.Mvc;

namespace ASP_013_api.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : Controller
    {
        IProductRepository repo;
        public ProductController(IProductRepository r)
        {
            repo = r;
        }

        [HttpGet]
        public IEnumerable<Product> GetAll()
        {
            return repo.GetAll();
        }
    }
}
