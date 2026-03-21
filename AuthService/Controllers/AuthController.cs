using Microsoft.AspNetCore.Mvc;
using AuthService.DTOs;
using AuthService.Services;

namespace AuthService.Controllers;

[ApiController]
[Route("api/auth")]
public class AuthController : ControllerBase
{
    private readonly AuthServiceHandler _service;

    public AuthController(AuthServiceHandler service)
    {
        _service = service;
    }

    [HttpPost("login")]
    public IActionResult Login(LoginDto dto)
    {
        var token = _service.Login(dto);

        if (token == null)
            return Unauthorized();

        return Ok(new { token });
    }
}
