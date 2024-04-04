
//using ECommerce.API.Configurations;
using ECommerce.Infrastructure;
using ECommerce.Application;
using Microsoft.EntityFrameworkCore;
using ECommerce.InfrastructureDatabase.Context;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//builder.Services.AddDatabaseSetup(builder.Configuration);
string connectionString = builder.Configuration.GetConnectionString("SqlConnection");

builder.Services.AddDbContext<CommerceContext>(options => {
    options.UseSqlServer(connectionString);
});
builder.Services.AddInfrastructureRepositories();
builder.Services.AddApplicationServices();

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



