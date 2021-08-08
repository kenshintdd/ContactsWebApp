using System.Linq;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using ContactsWebApp.Shared;

namespace ContactsWebApp.Server.Controllers
{
    [ApiController]
    [Route("legal-persons")]
    public class LegalPersonsController : ControllerBase
    {
        /// <summary>
        /// Create a new company
        /// </summary>
        [HttpPost]
        public IActionResult Create(LegalPerson legalPerson)
        {
            legalPerson.Create();

            return Ok();
        }

        /// <summary>
        /// Get a company
        /// </summary>
        /// <returns>Company's info</returns>
        [HttpGet("{contactId}")]
        public LegalPerson Get(int contactId)
        {
            var legalPerson = (LegalPerson)new LegalPerson().Get(contactId);
            return legalPerson;
        }

        /// <summary>
        /// List all companies
        /// </summary>
        /// <returns>List of companies</returns>
        [HttpGet("all")]
        public List<LegalPerson> GetAll()
        {
            var legalPersons = new LegalPerson().ListAll().Cast<LegalPerson>().ToList();

            return legalPersons;
        }

        /// <summary>
        /// Update a company
        /// </summary>
        [HttpPut]
        public IActionResult Update(LegalPerson legalPerson)
        {
            legalPerson.Update();

            return Ok();
        }
    }
}
