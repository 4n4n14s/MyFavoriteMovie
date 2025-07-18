using MediatR;

namespace Movies.API.Features.Movies.Commands.Delete;

public  class MovieDeleteCommand
{
    public record DeleteCommand(Guid UUId) : IRequest<bool>;
}
