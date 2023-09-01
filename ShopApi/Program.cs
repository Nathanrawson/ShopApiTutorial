using Microsoft.EntityFrameworkCore;
using ShopApi.Data;
using ShopApi.Data.Repositories.Interfaces;
using ShopApi.Data.Repositories;
using Microsoft.AspNetCore.OData;
using System.Linq;
using Microsoft.OData.Edm;
using Microsoft.OData.ModelBuilder;
using ShopApi.Data.EntityModels;
using Microsoft.AspNetCore.OData.Batch;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<ShopContext>(options => options.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=shopdb;Integrated Security=True"));
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddControllers();
builder.Services.AddScoped<IShopItemRepository, ShopItemRepository>();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

//app.UseAuthorization();

app.MapControllers();

app.Run();

