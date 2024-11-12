using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Online.Entities
{
    public class Course
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        [Required]
        public int StudentId { get; set; }

        [JsonIgnore]
        public Student Student { get; set; }
    }
}
