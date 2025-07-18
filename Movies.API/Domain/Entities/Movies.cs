namespace Movies.API.Domain.Entities
{
    public class Movies 
    {

        public int Id { get; set; }
        public Guid UUId { get; set; } = Guid.NewGuid();
        public string Title { get; set; } = string.Empty;
        public string Genre { get; set; } = string.Empty;
        public int ReleaseYear { get; set; }
    }
}
