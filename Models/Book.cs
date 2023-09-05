using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RantlhagoSM_Assign1.Models
{
    public class Book
    {
        [BindNever]
        public int BookId { get; set; }
        [Required(ErrorMessage ="Enter title of the book")]
        [StringLength(100)]
        public string BookTitle { get; set; }
        [Required(ErrorMessage = "Enter author of the book")]
        public string BookAuthor { get; set; }
        [Required(ErrorMessage ="Enter ISBN number of the book")]
        [StringLength(13)]
        [RegularExpression(@"^(?:ISBN(?:-1[03])?:?\\ )?(?=[0-9X]{10}$|(?=(?:[0-9]+[-\\ ]){3})[-\\ 0-9X]{13}$|97[89][0-9]{10}$|(?=(?:[0-9]+[-\\ ]){4})[-\\ 0-9]{17}$)(?:97[89][-\\ ]?)?[0-9]{1,5}[-\\ ]?[0-9]+[-\\ ]?[0-9]+[-\\ ]?[0-9X]$",
            ErrorMessage ="Please enter a valid 10-digit or 13-digit ISBN number")]
        public string BookISBN { get; set; }
        [Required(ErrorMessage = "Indicate if you already read this book")]
        public string BookIsRead { get; set; }
    }
}
