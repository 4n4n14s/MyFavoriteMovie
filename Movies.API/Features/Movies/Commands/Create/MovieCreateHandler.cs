using MediatR;
using Movies.API.Infrastructure.Data;
using static Movies.API.Features.Movies.Commands.Create.MovieCreateCommand;

namespace Movies.API.Features.Movies.Commands.Create;

public class MovieCreateHandler(MoviesDbContext context) : IRequestHandler<CreateCommand, Guid>
{
    
    
        private readonly MoviesDbContext _context = context;

    public async Task<Guid> Handle(CreateCommand Command, CancellationToken CancelationToken)
        {
            var movie = new Domain.Entities.Movies
            {


                Title = Command.Title,
                Genre = Command.Genre,
                ReleaseYear = Command.Year
            };

            _context.Movies.Add(movie);
            await _context.SaveChangesAsync(CancelationToken);

            return movie.UUId;


        }


    
}
