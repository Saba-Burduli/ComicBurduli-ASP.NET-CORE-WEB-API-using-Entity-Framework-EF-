using Microsoft.EntityFrameworkCore;
using SalesManagementSystem.DAL;
using SalesManagementSystem.DAL.Repositories;
using SalesManagementSystem.DATA;
using SalesManagementSystem.SERVICE;
using SalesManagementSystem.SERVICE.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
//Db Connection
builder.Services.AddDbContext<SalesManagmentSystemDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("SalesManagementSystemDbConnection"));
});
//add Interface Repositories to Class  Repositories
builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<IPasswordHasher, PasswordHasher>();  
builder.Services.AddScoped<IRatingRepository, RatingRepository>();

//imgonna add in there RoleRepository ++++ UP



//add services for Services
builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<IRatingService, RatingService>();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//add services for Repositories
builder.Services.AddScoped<IRatingRepository, RatingRepository>();
builder.Services.AddScoped<IRatingService, RatingService>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
