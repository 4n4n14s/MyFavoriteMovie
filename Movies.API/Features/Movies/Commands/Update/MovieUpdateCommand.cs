using MediatR;

namespace Movies.API.Features.Movies.Commands.Update;

public class MovieUpdateCommand
{
    public record UpdateCommand(Guid UUId, string Title, string Genre, int Year) : IRequest<bool>;
}
