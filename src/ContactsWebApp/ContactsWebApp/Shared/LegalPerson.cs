using System.Linq;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ContactsWebApp.Shared
{
    /// <summary>
    /// Company's info
    /// </summary>
    public class LegalPerson : Contact
    {
        /// <summary>
        /// Company's name
        /// </summary>
        [Required]
        public string CompanyName { get; set; }

        /// <summary>
        /// Company's trade name
        /// </summary>
        public string TradeName { get; set; }

        /// <summary>
        /// Company's tax ID in Brazil
        /// </summary>
        [Required]
        [RegularExpression(@"(^(\d{2}.\d{3}.\d{3}/\d{4}-\d{2})|(\d{14})$)", ErrorMessage = "Invalid CNPJ")]
        public string Cnpj { get; set; }

        public LegalPerson()
        {
            Address = new Address();
            Type = ContactType.LegalPerson;
        }

        /// <summary>
        /// Create a new company
        /// </summary>
        public override void Create()
        {
            ContactId = InMemoryDatabase.Contacts.Count + 1;
            InMemoryDatabase.Contacts.Add(this);
        }

        /// <summary>
        /// Update the company info
        /// </summary>
        public override void Update()
        {
            InMemoryDatabase.Contacts = InMemoryDatabase.Contacts
                .Where(w => !w.ContactId.Equals(ContactId))
                .ToList();
            InMemoryDatabase.Contacts.Add(this);
        }

        /// <summary>
        /// Get a company
        /// </summary>
        /// <param name="contactId">Contact ID</param>
        /// <returns>Company info</returns>
        public override Contact Get(int contactId)
        {
            return InMemoryDatabase.Contacts
                .FirstOrDefault(w => w.ContactId.Equals(contactId));
        }

        /// <summary>
        /// List all companies
        /// </summary>
        /// <returns>List of all companies</returns>
        public override List<Contact> ListAll()
        {
            return InMemoryDatabase.Contacts
                .Where(w => w.Type.Equals(ContactType.LegalPerson))
                .ToList();
        }
    }
}
