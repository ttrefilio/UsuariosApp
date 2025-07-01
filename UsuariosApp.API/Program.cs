using Microsoft.EntityFrameworkCore;
using Scalar.AspNetCore;
using UsuariosApp.API.Contexts;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddRouting(map => map.LowercaseUrls = true);
builder.Services.AddOpenApi();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<DataContext>(
    options => options.UseSqlServer(
        builder.Configuration.GetConnectionString("UsuariosApp")));

var app = builder.Build();


app.MapOpenApi();
app.UseSwagger();
app.UseSwaggerUI();
app.MapScalarApiReference(s => s.WithTheme(ScalarTheme.BluePlanet));

app.UseAuthorization();

app.MapControllers();

app.Run();
