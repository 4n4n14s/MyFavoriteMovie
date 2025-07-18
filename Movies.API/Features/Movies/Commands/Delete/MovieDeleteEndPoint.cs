using MediatR;

namespace Movies.API.Features.Movies.Commands.Delete;

public class MovieDeleteEndPoint
{
    public static void MapDeleteEndPoint(IEndpointRouteBuilder app)
    {
        app.MapDelete("/DeleteMovie/{UUId}", async (Guid UUId, ISender sender) =>
        {
            var result = await sender.Send(new MovieDeleteCommand.DeleteCommand(UUId));
            return result ? Results.Ok("Movie Deleted") : Results.NotFound();
        });
    }
}
