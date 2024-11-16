using C__Cumulative_1.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Register the DbContext with the DI container and configure the connection string
builder.Services.AddDbContext<SchoolDbContext>(options =>
    options.UseMySQL(builder.Configuration.GetConnectionString("SchoolDb"))); // Make sure "SchoolDb" exists in appsettings.json

builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts(); // Enforces HTTPS
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
builder.Services.AddDbContext<SchoolDbContext>(options =>
    options.UseMySQL(builder.Configuration.GetConnectionString("SchoolDb")));

