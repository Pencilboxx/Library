using DomainLayer.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ServiceLayer;

namespace Library.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersoBookController : ControllerBase
    {
        private readonly IPersoBookDetails PersoBookService;


        public PersoBookController(IPersoBookDetails persoBookService )
        {

            PersoBookService= persoBookService;

        }

        [HttpGet]
        [Route("[action]")]
        public ActionResult GetPersoBooks()
        {
            var books = PersoBookService.GetPersoBooks();
            if (books != null )
            {
                return Ok(books);
            }
            return BadRequest("Not Found");
        }

        [HttpGet]
        [Route("[action]/")]
        public ActionResult GetBook(string bookid)
        {
            var book = PersoBookService.GetPersoBooks(bookid);
            if (book != null)
            {
                return Ok(book);
            }
            return BadRequest("Not Found");
        }

        

        [HttpPost]
        [Route("[action]/")]

        public ActionResult AddBook(PersoBooks book)
        {

            PersoBookService.InsertBookIn(book);
            return Ok("Issued");
        }

        [HttpPut]

        public ActionResult UpdatePerson(PersoBooks book)
        {
            PersoBookService.UpdateBookIn(book);
            return Ok("Updated");
        }

    }
}
