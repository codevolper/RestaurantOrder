using RestaurantOrderRouting.Api;
using RestaurantOrderRouting.Domain.Application.Interfaces;
using RestaurantOrderRouting.Domain.Application.Services;
using RestaurantOrderRouting.Domain.Domain.Interfaces;
using RestaurantOrderRouting.Infrastructure.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//builder.Services.AddHostedService<ConsumerBackgroundService>();

// Dependecy Injection - How the project is small, I put the dependency injection directly here
builder.Services.AddScoped<IProducerOrderService, ProducerService>();
builder.Services.AddScoped<IProducerRepository, ProducerOrderQueue>();
//builder.Services.AddScoped<IConsumerOrderService, ConsumerOrderQueue>();

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
