using Microsoft.EntityFrameworkCore;
using TestAPPBackend.Models;

var builder = WebApplication.CreateBuilder(args);

var connectionString = builder.Configuration.GetSection("ConnectionString").Get<string>();

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddDbContext<BooksContext>(options =>
        options.UseSqlServer(connectionString)
);

var app = builder.Build();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
