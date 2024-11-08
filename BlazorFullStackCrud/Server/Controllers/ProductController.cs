using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BlazorFullStackCrud.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly DataContext _context;

        public ProductController(DataContext dataContext)
        {
            _context = dataContext;
        }

        [HttpGet]
        public async Task<ActionResult<List<Product>>> GetProduct()
        {
            var products = await _context.Products.Include(pr => pr.Category).ToListAsync();
            return Ok(products);
        }

        [HttpPost()]
        public async Task<ActionResult<List<Product>>> CreateSuperHero(Product product)
        {
            product.Category = null;
            _context.Products.Add(product);
            await _context.SaveChangesAsync();
            return Ok(await GetDbProduct());
        }

        [HttpGet("categories")]
        public async Task<ActionResult<List<Category>>> GetCategories()
        {
            var categories = await _context.Categories.ToListAsync();
            return Ok(categories);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<List<Category>>> GetSinglepProduct(int id)
        {
            var product = await _context.Products
                .Include(h => h.Category)
                .FirstOrDefaultAsync(h => h.Id == id);
            if (product == null)
            {
                return NotFound("Sorry, no hero here. :/");
            }

            return Ok(product);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<List<Category>>> UpdateProduct(Product product, int id)
        {
            var dbProduct = await _context.Products
                .Include(sh => sh.Category)
                .FirstOrDefaultAsync(sh => sh.Id == id);
            if (dbProduct == null)
                return NotFound("Sorry, but no product for you. :/");

            dbProduct.Code = product.Code;
            dbProduct.ProductName = product.ProductName;
            dbProduct.ProductDescribe = product.ProductDescribe;
            dbProduct.Supplier = product.Supplier;
            dbProduct.MinimumStock = product.MinimumStock;
            dbProduct.Stock = product.Stock;
            dbProduct.Prohibited = product.Prohibited;
            dbProduct.PurchaseValue = product.PurchaseValue;
            dbProduct.UnitaryValue = product.UnitaryValue;
            dbProduct.SaleValue = product.SaleValue;
            dbProduct.Profit = product.Profit;
            dbProduct.DatePurchase = product.DatePurchase;
            dbProduct.CategoryId = product.CategoryId;
            await _context.SaveChangesAsync();
            return Ok(await GetDbProduct());
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<List<Product>>> DeleteProduct(int id)
        {
            var dbProduct = await _context.Products
                .Include(sh => sh.Category)
                .FirstOrDefaultAsync(sh => sh.Id == id);
            if (dbProduct == null)
                return NotFound("Sorry, but no product for you. :/");

            _context.Products.Remove(dbProduct);
            await _context.SaveChangesAsync();

            return Ok(await GetDbProduct());
        }


        private async Task<List<Product>> GetDbProduct()
        {
            return await _context.Products.Include(sh => sh.Category).ToListAsync();
        }
    }
}
