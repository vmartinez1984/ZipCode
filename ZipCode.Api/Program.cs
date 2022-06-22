using AutoMapper;
using ZipCode.BusinessLayer.Bl;
using ZipCode.Core.DataSettings;
using ZipCode.Core.Interfaces.IBusinessLayer;
using ZipCode.Core.Interfaces.IRepositories;
using ZipCode.Core.Mappers;
using ZipCode.RepositoryMongoDb;
//using ZipCode.RepositoryEfMySql;
//using ZipCode.RepositoryEfMySql.Contexts;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.Configure<DataSettingMongoDb>(
    builder.Configuration.GetSection("DataSettingMongoDb")
);
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
//builder.Services.AddScoped<AppDbContext>();
builder.Services.AddScoped<IZipCodeRepository, ZipCodeRepository>();
builder.Services.AddScoped<IUnitOfWorkRepository, RepositoryMongoDb>();
builder.Services.AddScoped<IZipCodeBl, ZipCodeBl>();
builder.Services.AddScoped<IUnitOfWorkBl, UnitOfWork>();
var mapperConfig = new MapperConfiguration(mapperConfig =>
{
    mapperConfig.AddProfile<ZipCodeMapper>();
});
IMapper mapper = mapperConfig.CreateMapper();
builder.Services.AddSingleton(mapper);
builder.Services.AddCors(options => options.AddPolicy("AllowWebApp", builder => builder.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod()));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseCors("AllowWebApp");
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
