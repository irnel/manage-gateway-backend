using Hangfire;
using ManageGateway.Application.Extensions;
using ManageGateway.Infrastructure.Extensions;
using ManageGateway.Persistence.Extensions;
using ManageGateway.Server.Extensions;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);
var config = builder.Configuration;

// Add services to the container.
builder.Services.AddCors(options => 
    options.AddDefaultPolicy(builder =>
    {
        builder.AllowAnyOrigin()
               .AllowAnyHeader()
               .AllowAnyMethod();
    })
);

builder.Services.AddApplicationLayer();
builder.Services.AddPersistenceLayer(config);
builder.Services.AddInfrastructureLayer();

builder.Services.AddControllers()
    .AddValidators()
    .AddJsonOptions(
        opt => opt.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c => c.DisplayRequestDuration());
}

app.UseCors();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.UseHangfireDashboard("/mydashboard");

app.UseCustomMiddlewares();

app.Run();
