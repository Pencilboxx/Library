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
            if (persons != null && persons.Count > 0)
            {
                return Ok(persons);
            }
            return BadRequest("Not Found");
        }

        [HttpGet]
        [Route("[action]/personid")]
        public ActionResult GetBook(int personid)
        {
            var person = PersonService.GetPersonDetails(personid);
            if (person != null)
            {
                return Ok(person);
            }
            return BadRequest("Not Found");
        }

        [HttpPost]
        [Route("[action]/insert_person")]

        public ActionResult AddPerson(PersonDetails personDetails)
        {

            PersonService.InsertPerson(personDetails);
            return Ok("Person added");
        }

        
     

        [HttpDelete]

        public ActionResult DeletePerson(int personid)
        {

            PersonService.DeletePerson(personid);
            return Ok("Person Removed");
        }

       

        #endregion


    }
}
