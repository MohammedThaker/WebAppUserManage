using Application.Interfaces;
using Application.service;
using Domain.IRepository;

using Infrastructure.Interfacies;
using Infrastructure.LibraryDB;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.


builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddTransient<IBaseUnitOftWork, BaseUnitOfWork>();
builder.Services.AddScoped<IGetUserByIdService, GetUserByIdService>();
builder.Services.AddScoped<ICreateUserSerivce, CreateUserService>();
builder.Services.AddScoped<IDeleteUserServiceById, DeleteUserServiceById>();
builder.Services.AddScoped<IGetAllUserSerivce, GetAllUserSerivce>();
builder.Services.AddScoped<IUpdateUserService, UpdateUserService>();

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
