using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace FestivalCartage.Models
{
    public class Concert
    {
      
        public int id { get; set; }
        [Required]
        public string concertName { get; set; }
        [Required]
        [DisplayName("Concert Date")]
        public DateTime concertDate { get; set; }
        [Required]
        public string artistName { get; set; }
    }
}
