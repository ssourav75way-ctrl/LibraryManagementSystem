using  dotNetBasic.Models;

namespace dotNetBasic.ViewModels
{
    public class BooksViewModel
    {
        public IEnumerable<Book> AllBooks { get; set; } = new List<Book>();
        public IEnumerable<Book> HighlightedBooks { get; set; } = new List<Book>();
        public string? SelectedGenre { get; set; }
        public List<string> Genres { get; set; } = new();
    }
}