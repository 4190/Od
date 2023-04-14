using Od.Data;
using System.ComponentModel.DataAnnotations;

namespace Od.Models
{
    public class Book : IEntity
    {
        public int Id { get; set; }
        [Display(Name = "Tytuł")]
        public string Title { get; set; }
        public string Author { get; set; }
    }
}
