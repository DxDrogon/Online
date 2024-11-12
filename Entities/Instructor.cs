using System.ComponentModel.DataAnnotations;

namespace Online.Entities
{
    public class Instructor
    {
        public int Id { get; set; }

        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string Subject { get; set; }
        [Required]
        public string Email { get; set; }
    }
}
