using Microsoft.EntityFrameworkCore;
using Movies.API.Features.Movies.Commands.Create;

using Movies.API.Features.Movies.Commands.Delete;
using Movies.API.Features.Movies.Commands.Update;
using Movies.API.Features.Movies.Queries.GetAllMovies;
using Movies.API.Infrastructure.Data;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<MoviesDbContext>(opt => opt.UseMySql(builder.Configuration.GetConnectionString("DefaultConnection"), new MySqlServerVersion(new Version(8, 0, 0))));
builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblyContaining<Program>());


var app = builder.Build();

MoviesGetAllEndPoint.MapGetAllMovies(app);
MovieCreateEndpoint.MapCreateEndPoint(app);
MovieDeleteEndPoint.MapDeleteEndPoint(app);
MovieUpdateEndPoint.MapUpdateEndPoint(app);


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
