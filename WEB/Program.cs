using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder();

var connection = builder.Configuration
    .GetConnectionString("DefaultConnection");

builder.Services.AddDbContext<WEB.Models.AppContext>(options => 
    options.UseSqlServer(connection));

// Add services to the container.
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

app.MapGet("/", (WEB.Models.AppContext db) => db.Employees.ToList());

app.Run();
