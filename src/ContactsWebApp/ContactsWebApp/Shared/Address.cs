
namespace ContactsWebApp.Shared
{
    public class Address
    {
        /// <summary>
        /// Address' ID
        /// </summary>
        public int AddressId { get; set; }

        /// <summary>
        /// Main info of the address
        /// </summary>
        public string AddressLine1 { get; set; }

        /// <summary>
        /// Additional info about the address
        /// </summary>
        public string AddressLine2 { get; set; }

        /// <summary>
        /// City
        /// </summary>
        public string City { get; set; }

        /// <summary>
        /// State
        /// </summary>
        public string State { get; set; }

        /// <summary>
        /// Country
        /// </summary>
        public string Country { get; set; }

        /// <summary>
        /// Postal code
        /// </summary>
        public string ZipCode { get; set; }
    }
}
