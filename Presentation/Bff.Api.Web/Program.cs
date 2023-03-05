using System.Configuration;
using Bff.Infrastructure.Engine;
using Bff.Infrastructure.Jwt;
using Bff.Service;
using Bff.Service.LoginService;

var builder = WebApplication.CreateBuilder(args);
var configuration = builder.Configuration;


builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<ILoginService, LoginService>();
builder.Services.AddScoped<IJwtSecurity, JwtSecurity>();


builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddMemoryCache();
builder.JwtAndSwaggerRegister();
builder.Services.Configure<JwtModel>(configuration.GetSection("Jwt"));


builder.Services.AddCors(p => p.AddPolicy("CorsApp", builder =>
{
    builder.WithOrigins("*").AllowAnyMethod().AllowAnyHeader();
}));


var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors("CorsApp");

app.UseExceptionHandlerRegister();

app.UseAuthorization();

app.MapControllers();

app.Run();

