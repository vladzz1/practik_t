using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using PD411_Shop.Data;
using PD411_Shop.Models;
using PD411_Shop.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

// DbContext
builder.Services.AddDbContext<AppDbContext>(options =>
{
    string connectionString = @"Data Source = DESKTOP-B6M267U\SQLEXPRESS; Initial Catalog = PD411_MVC_SHOP; Integrated Security = true; TrustServerCertificate = True";
    //string connectionString = @"Data Source = (localdb)\MSSqlLocalDb; Initial Catalog = PD411_MVC_SHOP; Integrated Security = true; TrustServerCertificate = True";
    options.UseSqlServer(connectionString);
});

// Identity
builder.Services.AddIdentity<UserModel, IdentityRole>(options =>
{
    options.User.RequireUniqueEmail = true;

    options.Password.RequiredLength = 6;
    options.Password.RequireDigit = false;
    options.Password.RequireNonAlphanumeric = false;
    options.Password.RequireUppercase = false;
    options.Password.RequireLowercase = false;
}).AddEntityFrameworkStores<AppDbContext>().AddDefaultTokenProviders().AddDefaultUI();

// DI 
// builder.Services.AddSingleton(); // патерн Singleton - об'єкт класу буде існувати в єдиноиу екземплярі
// builder.Services.AddTransient(); // об'єкт класу буде створюватися при кожному використанні
builder.Services.AddScoped<ProductRepostitory>(); // об'єкт класу буде створюватися при запиті та видаляти після його завершення

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.MapRazorPages();

app.MapStaticAssets();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}")
    .WithStaticAssets();

app.Run();