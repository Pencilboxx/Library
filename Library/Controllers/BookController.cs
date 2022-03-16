
using DomainLayer.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ServiceLayer;

namespace Library.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly IBookDetails BookService;

        #region "constructor init"
        public BookController(IBookDetails bookService)
        {
            BookService = bookService;
            

        }
        #endregion

        #region "Api core func"
        
        [HttpGet]
        [Route("[action]")]
        public ActionResult GetBookDetails()
        {
            var books =BookService.GetBookDetails();
            if(books != null && books.Count>0)
            {
                return Ok(books);
            }
            return BadRequest("Not Found");
        }

        [HttpGet]
        [Route("[action]/one_book_details")]
        public ActionResult GetBook(int bookid)
        {
            var book = BookService.GetBookDetails(bookid);
            if (book != null)
            {
                return Ok(book);
            }
            return BadRequest("Not Found");
        }

        [HttpPost]
        [Route("[action]/insert_book")]

        public ActionResult AddBook(BookDetails bookDetails )
        {
           
            BookService.InsertBook(bookDetails);
            return Ok("Book added");
        }

     

        #endregion

    }
}
