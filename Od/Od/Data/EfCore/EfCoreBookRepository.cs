using Od.Models;

namespace Od.Data.EfCore
{
    public class EfCoreBookRepository : EfCoreRepository<Book, ApplicationDbContext>
    {
        public EfCoreBookRepository(ApplicationDbContext context) : base(context)
        {

        }
    }
}
