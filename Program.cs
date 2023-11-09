global using myfirstapi.Models;
using Microsoft.EntityFrameworkCore;
using myfirstapi.Repositories;
using myfirstapi.src.Database;

var builder = WebApplication.CreateBuilder(args);
var configuration = builder.Configuration;

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<UsersDatabaseContext>(
    options => options.UseSqlServer(configuration.GetConnectionString("UsersApi"))
);
builder.Services.AddScoped<IUserRepository, UserRepository>();

var app = builder.Build();
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();
