using Library.Model;

namespace Library.Data
{
    public class Query
    {
        [UseProjection]
        [UseFiltering]
        [UseSorting]
        public IQueryable<Superhero> GetSuperheroes([Service] ApplicationDbContext context) =>
            context.Superheroes;
    }
}
