
using dotNetBasic.Models;
using Microsoft.AspNetCore.Mvc;

namespace dotNetBasic.Controllers;
public class BooksController:Controller
{
    private readonly IBookService _bookService;

    public BooksController(IBookService bookService)
    {
        _bookService = bookService;
    }

    [HttpGet]
    public IActionResult Index(string genre)
    {
        var books = string.IsNullOrEmpty(genre)
            ? _bookService.GetAllBooks()
            : _bookService.GetBookByGenre(genre);

        var highlightedBooks = _bookService.GetHighlightBooks();
        ViewBag.SelectedGenre = genre; // to keep dropdown selected
        ViewBag.HighlightedBooks = highlightedBooks;
        return View(books);
    }

    public IActionResult Details(int id)
    {
        
            var book = _bookService.GetBookDetails(id);

            if (book == null)
                return NotFound();   

            return View(book);
        

    }

}