using AutoMapper;
using Ecommerce.Api.Dtos;
using Ecommerce.Business.Models;
using Ecommerce.Business.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Ecommerce.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;
        private readonly IMapper _mapper;

        public ProductController(IProductService productService, IMapper mapper)
        {
            _productService = productService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllAsync()
        {
            var products = await _productService.GetAllAsync();

            return Ok(products);
        }

        [HttpPost]
        public async Task<IActionResult> CreateProductAsync([FromBody] CreateProductDto productDto)
        {
            var product = _mapper.Map<Product>(productDto);

            await _productService.InsertAsync(product);

            return Ok(product);
        }
    }
}
