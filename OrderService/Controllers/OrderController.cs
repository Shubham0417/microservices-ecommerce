using Microsoft.AspNetCore.Mvc;
using OrderService.Models;

namespace OrderService.Controllers;

[ApiController]
[Route("api/orders")]
public class OrderController : ControllerBase
{
    private static List<Order> orders = new();

    [HttpPost]
    public IActionResult Create(Order order)
    {
        orders.Add(order);
        return Ok(order);
    }
}
