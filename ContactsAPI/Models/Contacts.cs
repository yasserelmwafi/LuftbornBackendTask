using System.ComponentModel.DataAnnotations;

namespace ContactsAPI.Models
{
    public class Contacts
    {
       // [Key]
        public Guid Id { get; set; }

        public string FullName { get; set; }

        public string Email { get; set; }

        public long phone { get; set; }

        public string Adress { get; set; }
    }
}
