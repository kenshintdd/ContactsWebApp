using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ContactsWebApp.Shared
{
    /// <summary>
    /// Person's info
    /// </summary>
    public class NaturalPerson : Contact
    {
        /// <summary>
        /// Person's name
        /// </summary>
        [Required]
        public string Name { get; set; }

        /// <summary>
        /// Person's tax ID in Brazil
        /// </summary>
        [Required]
        [RegularExpression(@"^\d{3}\.\d{3}\.\d{3}-\d{2}$", ErrorMessage = "Invalid CPF")]
        public string Cpf { get; set; }

        /// <summary>
        /// Person's birth date
        /// </summary>
        public DateTime BirthDate { get; set; }

        /// <summary>
        /// Person's gender
        /// </summary>
        public Gender Gender { get; set; }

        public NaturalPerson()
        {
            Address = new Address();
            Type = ContactType.NaturalPerson;
        }

        /// <summary>
        /// Create a new person
        /// </summary>
        public override void Create()
        {
            ContactId = InMemoryDatabase.Contacts.Count + 1;
            InMemoryDatabase.Contacts.Add(this);
        }

        /// <summary>
        /// Update the person's info
        /// </summary>
        public override void Update()
        {
            InMemoryDatabase.Contacts = InMemoryDatabase.Contacts
                .Where(w => !w.ContactId.Equals(ContactId))
                .ToList();
            InMemoryDatabase.Contacts.Add(this);
        }

        /// <summary>
        /// Get a person
        /// </summary>
        /// <param name="contactId">Contact ID</param>
        /// <returns>Person's info</returns>
        public override Contact Get(int contactId)
        {
            return InMemoryDatabase.Contacts
                .FirstOrDefault(w => w.ContactId.Equals(contactId));
        }

        /// <summary>
        /// List all persons
        /// </summary>
        /// <returns>List of all persons</returns>
        public override List<Contact> ListAll()
        {
            return InMemoryDatabase.Contacts
                .Where(w => w.Type == ContactType.NaturalPerson)
                .ToList();
        }
    }
}
