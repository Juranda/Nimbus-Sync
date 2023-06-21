using AutoMapper;
using Microsoft.EntityFrameworkCore;
using NimbusSync.Server.Data;
using NimbusSync.Server.Repositories;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<NimbusSyncDBContext>(options => 
    options.UseMySql(
        builder.Configuration.GetConnectionString("NimbusDb"), 
        new MySqlServerVersion(new Version(8,0,31))
        )
    );
builder.Services.AddAutoMapper(typeof(Program).Assembly);
builder.Services.AddScoped<ITecnicalDrawRepository, TecnicalDrawStaticRepository>();
builder.Services.AddAutoMapper(typeof(Program).Assembly);

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