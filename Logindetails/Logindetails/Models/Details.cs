using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Logindetails.Models
{
    public class UserDetails
    {
        [Required]
        public string Fname { get; set; }
        public string Lname { get; set; }
        public string Mname { get; set; }
        public string Email { get; set; }
        public int Phone { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string State { get; set; }
        public int Zipcode { get; set; }
        [Key]
        public string password { get; set; }
    }
}
