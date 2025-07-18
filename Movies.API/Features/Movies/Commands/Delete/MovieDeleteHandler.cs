using MediatR;
using Microsoft.EntityFrameworkCore;
using Movies.API.Infrastructure.Data;

namespace Movies.API.Features.Movies.Commands.Delete;

public class MovieDeleteHandler(MoviesDbContext context) : IRequestHandler<MovieDeleteCommand.DeleteCommand, bool>
{
    private readonly MoviesDbContext _context = context;

    public async Task<bool> Handle(MovieDeleteCommand.DeleteCommand request, CancellationToken cancellationToken)
    {
        var movie = await _context.Movies.FirstOrDefaultAsync(m => m.UUId == request.UUId, cancellationToken);

        if (movie is null) return false;

        _context.Movies.Remove(movie);
        await _context.SaveChangesAsync(cancellationToken);
        return true;
    }
}
