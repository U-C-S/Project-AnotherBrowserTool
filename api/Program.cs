using Microsoft.EntityFrameworkCore;
using Satellite.Data;

var builder = WebApplication.CreateBuilder(args);
string _CORS_DEV = "cors-dev";
string _CORS_PROD = "cors-prod";


builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddDbContext<DataContext>(options => options.UseNpgsql("Host=my_host;Database=my_db;Username=my_user;Password=my_pw"));
builder.Services.AddSwaggerGen(); // configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddCors(options =>
{
    options.AddPolicy(_CORS_DEV, policy =>
                        policy.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());

    options.AddPolicy(_CORS_PROD, policy =>
    {
        // TODO: Multiple Origins from env vars
        string? ALLOWED_ORIGIN = Environment.GetEnvironmentVariable("ALLOWED_ORIGIN");

        if (!string.IsNullOrWhiteSpace(ALLOWED_ORIGIN))
        {
            policy.WithOrigins(ALLOWED_ORIGIN).AllowAnyMethod().AllowAnyHeader();
        }
        else if (Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") != "Development")
        {
            throw new Exception("No value set for mandatory environment variable ALLOWED_ORIGIN.");
        }
    });
});

var app = builder.Build();
var env = app.Environment;

if (env.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseCors(env.IsDevelopment() ? _CORS_DEV : _CORS_PROD);

app.UseAuthorization();

app.MapControllers();

app.Run();
