using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ServiceLayer;

namespace Library.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CurrentbookController : ControllerBase
    {
        private readonly ICurrentbook Currentbook;


        public CurrentbookController(ICurrentbook currentbook)
        {
            Currentbook = currentbook;

        }
        //[HttpGet]
        //[Route("[action]")]
        //public ActionResult GetPersoBooks()
        //{
        //    var books = Currentbook.GetPersoBooks();
        //    if (books != null)
        //    {
        //        return Ok(books);
        //    }
        //    return BadRequest("Not Found");
        //}
        [HttpGet]
        [Route("[action]/")]
        public ActionResult GetCurrentBook(string personid)
        {
            var pid = Currentbook.GetCurrentBook(personid);
            if (pid != null )
            {
                return Ok(pid);
            }
            return BadRequest("Not Found");
        }

    }
}
