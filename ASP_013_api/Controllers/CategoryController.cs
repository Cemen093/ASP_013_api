using ASP_013_api.Model;
using Microsoft.AspNetCore.Mvc;

namespace ASP_013_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : Controller
    {
        ICategoryRepository repo;
        public CategoryController(ICategoryRepository r)
        {
            repo = r;
        }

        [HttpGet]
        public IEnumerable<Category> GetAll()
        {
            return repo.GetAll();
        }
    }
}
