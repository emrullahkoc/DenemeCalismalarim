using DenemeCalisma1.Models.VeriTabaný3;
using DenemeCalisma1.Models.VeriTabani1;
using DenemeCalisma1.Models.VeriTabani2;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDistributedMemoryCache();
builder.Services.AddSession(options => {
    options.Cookie.HttpOnly = true;
    options.Cookie.IsEssential = true;
});

builder.Services.AddDbContext<AnaContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("AnaDatabaseConnection")));
builder.Services.AddDbContext<MtlContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("MtlDatabaseConnection")));
builder.Services.AddDbContext<TtContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("TtDatabaseConnection")));

builder.Services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
builder.Services.AddControllersWithViews();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();

app.UseSession();  // Session middleware ekliyoruz
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
