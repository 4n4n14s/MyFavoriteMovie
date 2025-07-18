using MediatR;
using Microsoft.EntityFrameworkCore;
using Movies.API.Infrastructure.Data;

namespace Movies.API.Features.Movies.Commands.Update
{
    public class MovieUpdateHandler(MoviesDbContext context) : IRequestHandler<MovieUpdateCommand.UpdateCommand, bool>
    {
        private readonly MoviesDbContext _context = context;

        public async Task<bool> Handle(MovieUpdateCommand.UpdateCommand request, CancellationToken cancellationToken)
        {
            var movie = await _context.Movies.FirstOrDefaultAsync(m => m.UUId == request.UUId, cancellationToken);

            if (movie is null) return false;

            movie.Title = request.Title;
            movie.Genre = request.Genre;
            movie.ReleaseYear = request.Year;

            await _context.SaveChangesAsync(cancellationToken);
            return true;
        }
    }
    
}
