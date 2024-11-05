using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using FitHub.Data; // Your DbContext
using FitHub.Models; // Your User model

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

// Configure the DbContext for SQL Server and Identity
builder.Services.AddDbContext<FitHubContext>(options =>
    options.UseSqlServer(connectionString));

// Enable the developer exception page for database errors.
builder.Services.AddDatabaseDeveloperPageExceptionFilter();

// Ensure Identity is using the User class
builder.Services.AddIdentity<User, IdentityRole>(options =>
{
    options.SignIn.RequireConfirmedAccount = true;
})
  
.AddEntityFrameworkStores<FitHubContext>()
.AddDefaultTokenProviders();

builder.Services.AddRazorPages();

// Configure application cookie settings
builder.Services.ConfigureApplicationCookie(options =>
{
    options.LoginPath = "/Identity/Account/Login";
    options.AccessDeniedPath = "/Identity/Account/AccessDenied";
    options.ReturnUrlParameter = "/Custom Pages/Dashboard"; // Redirect to dashboard after login
});

var app = builder.Build();

// Configure the HTTP request pipeline.


if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}
else
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}



app.UseHttpsRedirection();
app.UseStaticFiles();


app.UseRouting();

app.UseAuthentication(); // Enable authentication middleware
app.UseAuthorization();

app.MapRazorPages();

// This sets the default page when no other URL is specified
app.MapFallbackToPage("/Index");


app.Run();
