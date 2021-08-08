using System.Collections.Generic;

namespace ContactsWebApp.Shared
{
    /// <summary>
    /// Contact's info
    /// </summary>
    public abstract class Contact
    {
        /// <summary>
        /// Contact's ID
        /// </summary>
        public int ContactId { get; set; }

        /// <summary>
        /// Contact type (Person/Company)
        /// </summary>
        public ContactType Type { get; set; }

        /// <summary>
        /// Address info
        /// </summary>
        public Address Address { get; set; }

        /// <summary>
        /// Create a new contact
        /// </summary>
        public abstract void Create();

        /// <summary>
        /// Update a contact
        /// </summary>
        public abstract void Update();

        /// <summary>
        /// Get a contact
        /// </summary>
        /// <param name="contactId">Contact ID</param>
        /// <returns>Contact</returns>
        public abstract Contact Get(int contactId);

        /// <summary>
        /// List all contacts
        /// </summary>
        /// <returns></returns>
        public abstract List<Contact> ListAll();
    }
}
