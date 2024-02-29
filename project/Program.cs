using kendoGridRev.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Builder; // Add missing using statement

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<EmpDbContext>(options =>
options.UseNpgsql(builder.Configuration.GetConnectionString("conn")));

var app = builder.Build();

// Remove error page in development environment
// if (env.IsDevelopment())
// {
//     app.UseDeveloperExceptionPage();
// }
app.UseExceptionHandler("/Home/Error");
app.UseHsts();

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
