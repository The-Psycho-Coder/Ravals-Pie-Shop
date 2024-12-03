var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();       // Application will know that it is an MVC application

var app = builder.Build();

app.UseStaticFiles();     // Looks for incoming requests for static files, such as a jpeg or a CSS file, and it will look into wwwroot folder

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

app.MapDefaultControllerRoute();      // Ability to navigate to our pages so that incoming requests are hadnled correctly

app.Run();
