using Microsoft.AspNetCore.Mvc;
using ProductService.Models;

namespace ProductService.Controllers;

[ApiController]
[Route("api/products")]
public class ProductController : ControllerBase
{
    private static List<Product> products = new();

    [HttpGet]
    public IActionResult Get() => Ok(products);

    [HttpPost]
    public IActionResult Create(Product product)
    {
        products.Add(product);
        return Ok(product);
    }
}
