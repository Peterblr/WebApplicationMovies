using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationMovies.Models
{
    public class Producer
    {
        [Key]
        public int ProducerID { get; set; }

        [Display(Name = "First Name"), StringLength(50, MinimumLength = 2)]
        public string FirstName { get; set; }

        [Display(Name = "Last Name"), StringLength(50, MinimumLength = 2)]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Image is requare!")]
        public string ImageURL { get; set; }

        [DataType(DataType.Date), Display(Name = "Birthday"), DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime DayOfBirth { get; set; }

        public virtual ICollection<Movie> Movies { get; set; }
    }
}
