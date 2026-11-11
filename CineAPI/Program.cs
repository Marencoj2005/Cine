using CineAPI.Models;
using Microsoft.AspNetCore.OpenApi;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<CineContext>(x => x.UseSqlServer("name=LocalConnection")); //Dbcontext agregado para la comunicacion con la base de datos en la API
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowBlazor", policy =>
    {
        policy.WithOrigins("https://localhost:7138") // El puerto de Blazor
              .AllowAnyHeader()
              .AllowAnyMethod();
    });
    /*IMPORTANTISIMO Para evitar el error de tipo CORS Cross-Origin Resource Sharing*/
});
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseCors("AllowBlazor");

app.UseAuthorization();

app.MapControllers();

app.Run();
