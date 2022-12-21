using System.ComponentModel.DataAnnotations;


namespace SantasEmporium.Models
{
    public class Recipient
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        public string Location { get; set; }
        public bool IsNice { get; set; }
        public string Present { get; set; }
    }
}
