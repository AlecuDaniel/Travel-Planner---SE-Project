using Microsoft.EntityFrameworkCore;
using Travel_Planner___SE_Project.Data;
using Travel_Planner___SE_Project.Data.Repositories;
using Travel_Planner___SE_Project.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<TravelDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("TravelDbConnection")));

builder.Services.AddScoped<IDestinationRepository, DestinationRepository>();
builder.Services.AddScoped<IDestinationService, DestinationService>();

var app = builder.Build();

// Configure the HTTP request pipeline.awgawgwagawgawg
if (!app.Environment.IsDevelopment())
{awfawfawfwafwafa
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseRouting();

app.UseAuthorization();

app.MapStaticAssets();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}")
    .WithStaticAssets();


app.Run();
