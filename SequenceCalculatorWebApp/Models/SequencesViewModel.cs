using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SequenceCalculatorWebApp.Models
{
    public class SequencesViewModel
    {
        [Required]
        [Range(0, Int32.MaxValue, ErrorMessage = "Please enter positive and a whole number only")]
        [Display(Name = "Enter number")]
        public int InputNumber { get; set; }

        [Display(Name = "All Numbers")]
        public string AllNumbers { get; set; }

        [Display(Name = "Even Numbers")]
        public string EvenNumbers { get; set; }

        [Display(Name = "Odd Numbers")]
        public string OddNumbers { get; set; }

        [Display(Name = "Custom Sequence")]
        public string CustomSequence { get; set; }

        [Display(Name = "Fibonacci Numbers")]
        public string FibonacciNumbers { get; set; }

        public bool AreSequencesGenerated { get; set; }
    }
}