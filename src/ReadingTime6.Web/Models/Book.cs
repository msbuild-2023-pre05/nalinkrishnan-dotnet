using System.ComponentModel.DataAnnotations;

namespace ReadingTime6.Web.Models
{
    public class Book
    {
        [Required]
        [StringLength(100, MinimumLength = 3)]
        public string Title { get; set; }
        [Required]
        [StringLength(60, MinimumLength = 3)]
        public string Author { get; set; }
        public string Cover { get; set; }

        // add a property for ratings
        public int Rating { get; set; }

        public Book()
        {

        }

        public Book(string title, string author)
        {
            Title = title;
            Author = author;
        }
        public Book(string title, string author, string cover)
        {
            Title = title;
            Author = author;
            Cover = cover;
        }

        // add a contructor that takes a title, author, cover, and rating
        public Book(string title, string author, string cover, int rating)
        {
        Title = title;
        Author = author;
        Cover = cover;
        Rating = rating;
        }
    }

}
