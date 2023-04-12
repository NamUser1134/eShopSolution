using eShopSolution.Application.Catalog.Products;
using eShopSolution.Data.EF;
using eShopSolution.Utilities.Constants;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<EShopDbContext>(options => options.UseSqlServer(
      // truy xuất chuỗi kết nối sql từ file appsettiing.json
      builder.Configuration.GetConnectionString(SystemConstants.MainConnectionString)

    ));

//Declare DI Khai bao 
builder.Services.AddTransient<IPublicProductService, PublicProductService>();
builder.Services.AddSwaggerGen( c => 
    {
        c.SwaggerDoc("v1", new OpenApiInfo { Title ="Swapper eShop Solution",Version ="v1"});
    });
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();
app.UseSwagger();
app.UseSwaggerUI(c => 
{
    c.SwaggerEndpoint("/swagger/v1/swagger.json", "Swagger eShopSolution V1");
});

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
