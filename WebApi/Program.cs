using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System.Reflection;
using WebApi;
using WebApi.Mapping;
using WebApi.Services.Abstract;
using WebApi.Services.Concrete;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddAutoMapper(Assembly.GetExecutingAssembly());
builder.Services.AddDbContext<KaderKutusuDbContext>();
builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddDbContext<KaderKutusuDbContext>(options =>
options.UseNpgsql(builder.Configuration.GetConnectionString("PostgreSql")));
var app = builder.Build();



// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
