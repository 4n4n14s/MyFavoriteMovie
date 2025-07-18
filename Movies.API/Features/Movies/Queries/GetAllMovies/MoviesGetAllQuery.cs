using MediatR;


namespace Movies.API.Features.Movies.Queries.GetAllMovies
{
    public static class MoviesGetAllQuery
    {
        public record Query : IRequest<IEnumerable<Domain.Entities.Movies>>;

        public record Response(Domain.Entities.Movies Movie);
  

    }
}
