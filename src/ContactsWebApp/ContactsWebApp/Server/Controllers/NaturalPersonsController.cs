using System.Linq;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using ContactsWebApp.Shared;

namespace ContactsWebApp.Server.Controllers
{
    [ApiController]
    [Route("natural-persons")]
    public class NaturalPersonsController : ControllerBase
    {
        /// <summary>
        /// Create a new person
        /// </summary>
        [HttpPost]
        public IActionResult Create(NaturalPerson naturalPerson)
        {
            naturalPerson.Create();

            return Ok();
        }

        /// <summary>
        /// Get a person
        /// </summary>
        /// <returns>Person's info</returns>
        [HttpGet("{contactId}")]
        public NaturalPerson Get(int contactId)
        {
            var naturalPerson = (NaturalPerson)new NaturalPerson().Get(contactId);
            return naturalPerson;
        }

        /// <summary>
        /// List all persons
        /// </summary>
        /// <returns>List of persons</returns>
        [HttpGet("all")]
        public List<NaturalPerson> GetAll()
        {
            var naturalPersons = new NaturalPerson().ListAll().Cast<NaturalPerson>().ToList();

            return naturalPersons;
        }

        /// <summary>
        /// Update a person
        /// </summary>
        [HttpPut]
        public IActionResult Update(NaturalPerson naturalPerson)
        {
            naturalPerson.Update();

            return Ok();
        }
    }
}
