using Microsoft.AspNetCore.Mvc;
using OrderService.Models;
using System.Net.Http.Json;

[ApiController]
[Route("api/orders")]
public class OrderController : ControllerBase
{
    private static List<Order> orders = new();
    private readonly HttpClient _httpClient;

    public OrderController(IHttpClientFactory factory)
    {
        _httpClient = factory.CreateClient();
    }

    [HttpPost]
    public async Task<IActionResult> Create(Order order)
    {
        // Call Product Service (inside Docker network)
        var response = await _httpClient.GetAsync(
            $"http://product-service:8080/api/products/{order.ProductId}"
        );

        if (!response.IsSuccessStatusCode)
            return BadRequest("Product not found");

        orders.Add(order);
        return Ok(order);
    }
}