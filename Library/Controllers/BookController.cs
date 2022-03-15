
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
            if(books != null && books.Count>1)
            {
                return Ok(books);
            }
            return BadRequest("Not Found");
        }

        [HttpGet]
        [Route("[action]/bid")]
        public ActionResult GetBook(int bid)
        {
            var book = BookService.GetBookDetails(bid);
            if (book != null)
            {
                return Ok(book);
            }
            return BadRequest("Not Found");
        }

        [HttpPost]

        public ActionResult AddBook(BookDetails bookDetails )
        {
           
            BookService.InsertBook(bookDetails);
            return Ok("Book added");
        }

        [HttpPut]

        public ActionResult UpdateBooks(BookDetails bookDetails)
        {

            BookService.UpdateBook(bookDetails);
            return Ok("Book updated");
        }

        [HttpDelete]

        public ActionResult DeleteBooks(int id)
        {

            BookService.DeleteBook(id);
            return Ok("Book Deleted");
        }

        #endregion

    }
}
