using AuthService.Data;
using AuthService.Services;
using Microsoft.EntityFrameworkCore;
using AuthService.Models;


var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<AppDbContext>(opt =>
    opt.UseInMemoryDatabase("AuthDb"));

builder.Services.AddScoped<AuthServiceHandler>();

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

app.MapControllers();


using (var scope = app.Services.CreateScope())
{
    var db = scope.ServiceProvider.GetRequiredService<AppDbContext>();

    db.Users.Add(new User
    {
        Email = "test@test.com",
        PasswordHash = "1234",
        Role = "User"
    });

    db.SaveChanges();
}

app.Run();