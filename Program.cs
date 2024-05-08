using BislariumCW.Data;
using BislariumCW.Extensions;
using BislariumCW.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


builder.Services.AddDbContext<DBConnect>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DatabaseConnectionString")));

builder.Services.RegisterDependencies();
builder.Services.ConfigureMapping();
builder.Services.ConfigureLoggerService();
builder.Services.ConfigureRepositoryManager();
builder.Services.AddHttpContextAccessor();
builder.Services.AddScoped<UserAuthenticationRepository, UserAuthenticationRepository>();

builder.Services.AddAuthentication();
builder.Services.ConfigureIdentity();
builder.Services.ConfigureJWT(builder.Configuration);

builder.Services.AddEndpointsApiExplorer();
builder.Services.ConfigureSwagger();
builder.Services.AddSwaggerGen();

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
