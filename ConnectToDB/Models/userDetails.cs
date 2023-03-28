using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConnectToDB.Models
{
    [Table("userdetails")]
    public class userDetails
    {
        public string FName { get; set; }
        public string LName { get; set; }
        public string Mname { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string? Address1{ get; set; }
        public string? State  { get; set; }
        public string Zipcode { get; set; }
        [Key]
        public string Password { get; set; }
    }
}
