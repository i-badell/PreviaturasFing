using Microsoft.EntityFrameworkCore;
using PreviaturasFing.Infrastructure.Context;
using AutoMapper;
using PreviaturasFing.Application.Profiles;
using PreviaturasFing.Infrastructure.Repositories;
using PreviaturasFing.Domain.Interfaces;
using PreviaturasFing.Domain.Models;
using Microsoft.Extensions.Logging;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<SubjectDbContext>(b =>
{
    b.UseSqlServer(builder.Configuration.GetConnectionString("Default"));
}); // Todo -> Create Db extension method

builder.Services.AddAutoMapper(typeof(SubjectProfile)); // Todo -> Create Automapper extension method

builder.Services.AddTransient<IRepository<Subject>, SubjectRepository>(); // Todo -> Change repositories to not use generics

builder.Logging.ClearProviders();
builder.Services.AddLogging(); 

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
