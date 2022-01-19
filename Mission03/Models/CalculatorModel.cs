using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mission03.Models
{
    public class CalculatorModel
    {
        [Required(ErrorMessage = "An Album Title is required")]
        //[Range(0, 100)]
        public int Assignment { get; set; }

        [Required(ErrorMessage ="Hello")]
        [Range(0, 100)]
        public int Group { get; set; }

        [Required]
        [Range(0, 100)]
        public int Quiz { get; set; }

        [Required]
        [Range(0, 100)]
        public int Exam { get; set; }

        [Range(0, 100)]
        public int Intex { get; set; }
    }

}
