using Microsoft.EntityFrameworkCore;
using P04Sklep.API.Data;
using P05Sklep.Shared;
using P06Sklep.DataSeeder;

namespace P04Sklep.API.Services.ProductService
{
    public class ProductService : IProductService
    {
        private readonly DataContext _context;

        public ProductService(DataContext context)
        {
            _context = context;
        }
        public async Task<ServiceResponse<Product[]>> GetProductAsync()
        {
            var respone = new ServiceResponse<Product[]>
            {
                Data = await _context.Products.ToArrayAsync()
            };

            return respone;
            // odwołanie się do DataContext (baza danych)
            //var data = new Product[2]
            //{
            //    new Product()
            //    {
            //        Id = 1,
            //        Title = "Product 1",
            //        Description = "Desc 1"

            //    }, new Product()
            //    {
            //        Id = 2,
            //        Title = "Product 2",
            //        Description = "Desc 2"
            //    }
            //};



            //var response = new ServiceResponse<Product[]>()
            //{
            //    Data = ProductSeeder.GenerateProductData()
            //};

            //return response;
        }

        public async Task<ServiceResponse<Product>> UpdateProduct(Product product)
        {
            var p = _context.Products.FirstOrDefault(x => x.Id == product.Id);

            if (p == null)
                return new ServiceResponse<Product>
                {
                    Success = false,
                    Message = "Not found product"
                };

            p.Title = product.Title;
            p.Description = product.Description;
            p.Color = product.Color;
            p.ImgUrl = product.ImgUrl;

            await _context.SaveChangesAsync();

            return new ServiceResponse<Product>()
            {
                Data = p
            };

            
        }
    }
}
