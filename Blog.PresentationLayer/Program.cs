using Blog.BusinessLayer.Abstract;
using Blog.BusinessLayer.Concrete;
using Blog.DataAccessLayer.Abstract;
using Blog.DataAccessLayer.Concrete;
using Blog.DataAccessLayer.EntityFramework;
using Microsoft.EntityFrameworkCore;
using System;
var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<DbBlogContext>(options =>
{
    // Burada connection string'i manuel olarak da ekleyebilirsiniz
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});

// Add services to the container.

builder.Services.AddScoped<IAboutDal,EfAboutDal>();
builder.Services.AddScoped<IAboutService, AboutManager>();

builder.Services.AddScoped<ICategoryDal, EfCategoryDal>();
builder.Services.AddScoped<ICategoryService, CategoryManager>();

builder.Services.AddScoped<IContactDal, EfContactDal>();
builder.Services.AddScoped<IContactService, ContactManager>();

builder.Services.AddScoped<IInformationDal, EfInformationDal>();
builder.Services.AddScoped<IInformationService, InformationManager>();

builder.Services.AddScoped<IMapDal, EfMapDal>();
builder.Services.AddScoped<IMapService, MapManager>();

builder.Services.AddScoped<IRecipeDal, EfRecipeDal>();
builder.Services.AddScoped<IRecipeService, RecipeManager>();

builder.Services.AddScoped<ISubscribeDal,EfSubscribeDal>();
builder.Services.AddScoped<ISubscribeService, SubscribeManager>();

builder.Services.AddControllersWithViews();


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

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
