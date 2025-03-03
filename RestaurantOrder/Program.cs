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
// Producer D.I
builder.Services.AddScoped<IProducerOrderService, ProducerService>();
builder.Services.AddScoped<IProducerRepository, ProducerOrderQueue>();
// Consumer D.I
builder.Services.AddScoped<IConsumerOrderService, ConsumerService>();
builder.Services.AddScoped<IConsumerRepository, ConsumerOrderQueue>();

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
