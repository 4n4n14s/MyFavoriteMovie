using MediatR;


namespace Movies.API.Features.Movies.Commands.Create;

public class MovieCreateCommand
{
    public record CreateCommand (string Title, string Genre, int Year ) :IRequest<Guid>;

    
    
}
