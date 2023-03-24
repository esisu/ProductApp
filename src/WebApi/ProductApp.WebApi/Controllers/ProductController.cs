using Microsoft.AspNetCore.Mvc;
using ProductApp.Application.Dto;
using ProductApp.Application.Interfaces.Repository;

namespace ProductApp.WebApi.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductRepository _productRepository;

        public ProductController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<IActionResult> Get()
        {
            var list = await _productRepository.GetAll();
            var result = list.Select(i => new ProductViewDto()
            {
                Id = i.Id,
                Name = i.Name
            }).ToList();

            return Ok(result);
        }
    }
}
