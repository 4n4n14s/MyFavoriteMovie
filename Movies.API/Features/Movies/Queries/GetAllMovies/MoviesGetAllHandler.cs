using MediatR;
using Microsoft.EntityFrameworkCore;
using Movies.API.Infrastructure.Data;

namespace Movies.API.Features.Movies.Queries.GetAllMovies;

public class MoviesGetAllHandler(MoviesDbContext context) : IRequestHandler<MoviesGetAllQuery.Query, IEnumerable<Domain.Entities.Movies>>
{       
    private readonly MoviesDbContext _context = context;

    public async Task<IEnumerable<Domain.Entities.Movies>> Handle(MoviesGetAllQuery.Query request, CancellationToken cancelationToken)
    {
        return await _context.Movies.ToListAsync(cancelationToken);
    }


    
}
