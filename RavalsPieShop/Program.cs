using Microsoft.EntityFrameworkCore;
using RavalsPieShop.Models.EntityFramework;
using RavalsPieShop.Models.Interfaces;
using RavalsPieShop.Models.Repositories;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<IPieRepository, PieRepository>(); // Dependency Injection - we are telling the application to use the PieRepository class whenever it needs an IPieRepository
builder.Services.AddScoped<ICategoryRepository, CategoryRepository>();

builder.Services.AddControllersWithViews();       // Application will know that it is an MVC application

builder.Services.AddDbContext<RavalsPieShopDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("RavalsPieShopDbContext"))); // Add the connection string to the database

var app = builder.Build();

app.UseStaticFiles();     // Looks for incoming requests for static files, such as a jpeg or a CSS file, and it will look into wwwroot folder

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

app.MapDefaultControllerRoute();      // Ability to navigate to our pages so that incoming requests are hadnled correctly

app.Run();
