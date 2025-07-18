using MediatR;

namespace Movies.API.Features.Movies.Queries.GetAllMovies;

public static class MoviesGetAllEndPoint
{
    public static void MapGetAllMovies(this IEndpointRouteBuilder app)
    {
        app.MapGet("/movies", async (ISender sender) =>
        {
            var movies = await sender.Send(new MoviesGetAllQuery.Query());
            return Results.Ok(movies);
        });

    }
}
