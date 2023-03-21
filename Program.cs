using Dota2App.Context;
using Dota2App.Controllers;
using Dota2App.Models.DataManagers;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var connection = builder.Configuration.GetConnectionString("ConnectionStrings:Database");

builder.Services.AddDbContext<ApplicationContext>(options =>
{
    options.UseMySql(builder.Configuration["ConnectionStrings:Database"],
        ServerVersion.AutoDetect(builder.Configuration["ConnectionStrings:Database"]));
});

builder.Services.AddTransient<DataManager>();
builder.Services.AddTransient<DotaAppBaseController>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
