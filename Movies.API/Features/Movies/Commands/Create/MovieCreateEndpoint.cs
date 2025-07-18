using MediatR;
using static Movies.API.Features.Movies.Commands.Create.MovieCreateCommand;

namespace Movies.API.Features.Movies.Commands.Create
{
    public class MovieCreateEndpoint
    {
        public static void MapCreateEndPoint(IEndpointRouteBuilder app)
        {
            app.MapPost("/SaveMovie", async (CreateCommand command, ISender sender) =>
            {
                var id = await sender.Send(command);
                return Results.Created($"/SaveMovie{id}", new { id });
            });
        }
    }
}
