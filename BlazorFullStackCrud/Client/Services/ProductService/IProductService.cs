namespace BlazorFullStackCrud.Client.Services.ProductService
{
    public interface IProductService
    {
        List<Product> Products { get; set; }
        List<Category> Categories { get; set; }

        Task CreateProduct(Product product);
        Task GetCategories();
        Task GetProducts();

        Task<Product> GetSingleProduct(int id);


        Task UpdateProduct(Product product);

        /// <summary>
        /// Task UpdateHero(SuperHero hero);
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>

        Task Delete(int id);
    }
}
