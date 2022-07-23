using Ass3.Library;
using eStore.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

IConfiguration config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", true, true)
                .Build();
var strConn = config["ConnectionStrings:BankAccountTypeDB"];
IServiceCollection services = builder.Services;
services.AddDbContext<ASS2_DBContext>(options =>
            options.UseSqlServer(connectionString: strConn));
services.AddScoped<ASS2_DBContext>();
services.AddHttpContextAccessor();
builder.Services.AddDistributedMemoryCache();

builder.Services.AddSession(options =>
{
    options.IdleTimeout = TimeSpan.MaxValue;
    options.Cookie.HttpOnly = true;
    options.Cookie.IsEssential = true;
});
services.AddRazorPages();
services.AddControllersWithViews();

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseSession();
app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    //pattern: "{controller=Home}/{action=Index}/{id?}");
    pattern: "{controller=Login}/{action=Index}/{id?}");

DBHelper.GetDefaultAccount();

app.Run();
