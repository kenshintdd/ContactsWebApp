using System.Collections.Generic;

namespace ContactsWebApp.Shared
{
    /// <summary>
    /// In memory database
    /// </summary>
    public static class InMemoryDatabase
    {
        /// <summary>
        /// Contact's list
        /// </summary>
        public static List<Contact> Contacts = new List<Contact>();
    }
}
