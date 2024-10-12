using Microsoft.EntityFrameworkCore;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

//--

//builder.Services.AddDbContext<>(op => op.UseSqlServer(builder.Configuration.GetConnectionString("userportal")));

//--

builder.Services.AddControllers();

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseAuthorization();

app.MapControllers();

app.Run();
