using MyApi.BusinessLayer.Abstract;
using MyApi.BusinessLayer.Concrete;
using MyApi.DataAccessLayer.Abstract;
using MyApi.DataAccessLayer.Context;
using MyApi.DataAccessLayer.EntityFramework;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddScoped<ICategoryService,CategoryManager>();
builder.Services.AddScoped<ICategoryDal,EfCategoryDal>();

builder.Services.AddScoped<IProductService,ProductManager>();
builder.Services.AddScoped<IProductDal,EfProductDal>();

builder.Services.AddDbContext<ApiContext>();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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
