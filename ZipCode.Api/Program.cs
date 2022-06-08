using AutoMapper;
using ZipCode.BusinessLayer.Bl;
using ZipCode.Core.Interfaces.IBusinessLayer;
using ZipCode.Core.Interfaces.IRepositories;
using ZipCode.Core.Mappers;
using ZipCode.RepositoryEfMySql;
using ZipCode.RepositoryEfMySql.Contexts;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<AppDbContext>();
builder.Services.AddScoped<IZipCodeRepository,ZipCodeRepository>();
builder.Services.AddScoped<IUnitOfWorkRepository, Repository>();
builder.Services.AddScoped<IZipCodeBl, ZipCodeBl>();
builder.Services.AddScoped<IUnitOfWorkBl,UnitOfWork>();
var mapperConfig = new MapperConfiguration( mapperConfig=>{
    mapperConfig.AddProfile<ZipCodeMapper>();
});
IMapper mapper = mapperConfig.CreateMapper();
builder.Services.AddSingleton(mapper);

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
