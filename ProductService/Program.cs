using ProductService.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// ✅ Add DB
builder.Services.AddDbContext<AppDbContext>(opt =>
    opt.UseInMemoryDatabase("ProductDb"));

// ✅ Add controllers (THIS WAS MISSING)
builder.Services.AddControllers();

var app = builder.Build();

// ❌ Remove unnecessary minimal API + OpenAPI (optional cleanup)
// app.UseHttpsRedirection();

// ✅ Map controllers (THIS WAS MISSING)
app.MapControllers();

app.Run();