using dotNetBasic.Data;
using dotNetBasic.Models;
using Microsoft.AspNetCore.Http.HttpResults;

public class BookService : IBookService
{
   public List<Book> GetAllBooks()
   {
      return BookData.Books;
   }

   public List<Book> GetBookByGenre(string genre)
   {
      return BookData.Books
         .Where(b => b.Genre.Equals(genre, StringComparison.OrdinalIgnoreCase))
         .ToList();
   }

   public Book? GetBookDetails(int id)
   {
      return BookData.Books.FirstOrDefault(b => b.Id == id);
   }

   public List<Book> GetHighlightBooks()
   {
      return BookData.Books
         .Where(b => b.AddedOn >= DateTime.Now.AddDays(-3))
         .ToList();

   }
  
}