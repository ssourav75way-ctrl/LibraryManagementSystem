using dotNetBasic.Models;
public interface IBookService
{
    List<Book>GetAllBooks();
    List<Book>GetBookByGenre(string genre);
    Book? GetBookDetails(int id);
    List<Book> GetHighlightBooks();
}