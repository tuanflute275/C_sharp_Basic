using Backend.Models;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using X.PagedList;

namespace Backend.Controllers
{
    [Route("api")]
    [ApiController]
    [EnableCors("AllowOrigin")]
    public class HomeController : ControllerBase
    {
        private readonly DemoTestAsp01Context _context;

        public HomeController(DemoTestAsp01Context context)
        {
            _context = context;
        }

        [HttpGet]
        [Route("category")]
        public async Task<ActionResult<IEnumerable<Category>>> GetAllCategory()
        {
            var categories = await _context.Categories.Include(c => c.Products).ToListAsync();

            return categories;
        }

        [HttpGet]
        [Route("product")]
        public async Task<X.PagedList.IPagedList<Product>> GetPaginated(int page = 1, int limit = 3)
        {
            page = page <= 1 ? 1 : page;
            limit = limit <= 1 ? 1 : limit;
            var prods = _context.Products.ToPagedListAsync(page, limit);

            return await prods;
        }

        [HttpGet]
        [Route("productByCate/{cateId}")]
        public async Task<ActionResult<Category>> GetProductByCate([FromRoute] int cateId)
        {
            var category = _context.Categories.Include(x => x.Products).FirstOrDefaultAsync(x => x.Id == cateId);

            return await category;
        }

        [HttpGet]
        [Route("product/{id}")]
        public async Task<ActionResult<Product>> GetProduct([FromRoute] int id)
        {
            var product = _context.Products.Include(x => x.Category).FirstOrDefaultAsync(x => x.Id == id);

            return await product;
        }
    }
}
