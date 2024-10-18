using DenemeCalisma1.Data;
using DenemeCalisma1.Models.Services;
using Microsoft.EntityFrameworkCore;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<FirstDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("FirstDatabaseConnection")));

builder.Services.AddDbContext<SecondDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("SecondDatabaseConnection")));

builder.Services.AddScoped<AcenteService>();
builder.Services.AddScoped<KullaniciService>();

builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
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
