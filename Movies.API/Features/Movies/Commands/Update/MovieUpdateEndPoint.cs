using MediatR;

namespace Movies.API.Features.Movies.Commands.Update;

public class MovieUpdateEndPoint
{
    public static void MapUpdateEndPoint(IEndpointRouteBuilder app)
    {
        app.MapPut("/editMovie/{UUId}", async (Guid UUId, MovieUpdateCommand.UpdateCommand command, ISender sender)=>
        {
            if (UUId != command.UUId) return Results.BadRequest("UUId mismatch");

            var result = await sender.Send(command);
            return result ? Results.Ok("Movie Update") : Results.NotFound("Movie not found");
        });
    }
}
