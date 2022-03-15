using DomainLayer.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ServiceLayer;

namespace Library.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private readonly IPersonDetails PersonService;

        #region "constructor init"
        public PersonController(IPersonDetails personService)
        {
            PersonService = personService;


        }
        #endregion

        #region "Api core func"

        [HttpGet]
        [Route("[action]")]
        public ActionResult GetPersonDetails()
        {
            var persons = PersonService.GetPersonDetails();
            if (persons != null && persons.Count > 1)
            {
                return Ok(persons);
            }
            return BadRequest("Not Found");
        }

        [HttpGet]
        [Route("[action]/bid")]
        public ActionResult GetBook(int bid)
        {
            var person = PersonService.GetPersonDetails(bid);
            if (person != null)
            {
                return Ok(person);
            }
            return BadRequest("Not Found");
        }

        [HttpPost]

        public ActionResult AddPerson(PersonDetails personDetails)
        {

            PersonService.InsertPerson(personDetails);
            return Ok("Person added");
        }

        [HttpPut]

        public ActionResult UpdatePerson(PersonDetails personDetails)
        {

            PersonService.UpdatePerson(personDetails);
            return Ok("Book updated");
        }

        [HttpDelete]

        public ActionResult DeletePerson(int id)
        {

            PersonService.DeletePerson(id);
            return Ok("Person Deleted");
        }

        #endregion


    }
}
