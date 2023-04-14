using Od.Data;

namespace Od.Models
{
    public class Book : IEntity
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
    }
}
