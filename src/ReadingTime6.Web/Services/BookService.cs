using System.Collections.Generic;
using ReadingTime6.Web.Models;

namespace ReadingTime6.Web.Services
{
    public class BookService
    {
        private readonly List<Book> books = new List<Book>
        {
            // add ratings for each book from 1 to 5
            new Book("Accelerate: The Science of Lean Software and DevOps: Building and Scaling High Performing Technology Organizations", "Nicole Forsgren, PhD", "forsgren.jpg", 5),
            new Book("Scrum: The Art of Doing Twice the Work in Half the Time", "Jeff Sutherland", "scrum.jpg", 5),
            new Book("The Lean Startup: How Constant Innovation Creates Radically Successful Businesses","Eric Ries", "lean.jpg", 5),
            new Book("Crossing the Chasm", "Geoffrey A. Moore", "chasm.jpg", 4),
            new Book("The Pragmatic Programmer: From Journeyman to Master", "David Thomas", "pragmatic.jpg", 4),
            new Book("Don't Make Me Think, Revisited: A Common Sense Approach to Web Usability"," Steve Krug", "think.jpg", 4),
        };

        public List<Book> Books() => books;
    }
}
