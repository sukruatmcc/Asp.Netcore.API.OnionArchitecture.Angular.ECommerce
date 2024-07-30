using ECommerceAPI.Application.Abstractions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ECommerceAPI.API.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class ProductsController : ControllerBase
  {
      private readonly IProductService _productService;
      public ProductsController(IProductService productService)
      {
        _productService = productService;
      }
      public IActionResult GeProducts()
      {
        var products = _productService.GetProducts();
        return Ok(products);
      }
  }
}
