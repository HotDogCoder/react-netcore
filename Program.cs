using Microsoft.EntityFrameworkCore;
using time_of_your_life.Application.RepositoriesInterfaces;
using time_of_your_life.Application.Services;
using time_of_your_life.Application.ServicesInterfaces;
using time_of_your_life.Infrastructure.Contexts;
using time_of_your_life.Infrastructure.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddScoped<PresetRepositoryInterface, PresetRepository>();
builder.Services.AddScoped<PresetServiceInterface, PresetService>();

// Register the DbContext with the connection string
builder.Services.AddDbContext<SqlLiteContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller}/{action=Index}/{id?}");

app.MapFallbackToFile("index.html");

app.Run();
