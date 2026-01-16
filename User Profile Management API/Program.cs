using User_Profile_Management_API.Models; 
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using User_Profile_Management_API.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

// If am using a real database:
//builder.Services.AddDbContext<UserProfileManagementApiContext>(options => options.UseSqlServer
//(builder.Configuration.GetConnectionString("Defaultconnection")));

// using InMemory database:
builder.Services.AddDbContext <UserProfileManagementApiContext>(options => options.UseInMemoryDatabase("UserProfileDb"));

// configuration for EF Core Identity
builder.Services.AddIdentity<User, IdentityRole>(options =>
{
    options.Password.RequireDigit = true;
    options.Password.RequireLowercase = true;
    options.Password.RequireNonAlphanumeric = true;
    options.User.RequireUniqueEmail = true;
    options.SignIn.RequireConfirmedEmail = true;
    options.SignIn.RequireConfirmedEmail = true;
    options.SignIn.RequireConfirmedPhoneNumber = true;
})

.AddEntityFrameworkStores<UserProfileManagementApiContext>() // Tells Identity where to store user information and roles 
    .AddDefaultTokenProviders(); // Used for generating tokens for email confirmation, password reset, Two-Factor Authentication, etc.

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.UseAuthentication(); // adds authentication middleware to the HTTP request pipeline.

app.UseAuthorization();

app.MapControllers();

app.Run();
