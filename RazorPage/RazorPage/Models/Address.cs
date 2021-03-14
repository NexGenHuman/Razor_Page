using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace RazorPage.Models
{
    public class Address
    {
        [Display(Name = "Twoja ulubiona ulica")]
        [StringLength(60, MinimumLength = 3), Required(ErrorMessage ="Pole jest wymagane")]
        public string Street { get; set; }
        [Display(Name = "Twój kod pocztowy")]
        [DataType(DataType.PostalCode), Required(ErrorMessage = "Pole jest wymagane")]
        public string ZipCode { get; set; }
        [Display(Name = "Twoje miasto")]
        [StringLength(60, MinimumLength = 3), Required(ErrorMessage = "Pole jest wymagane")]
        public string City { get; set; }
        [Display(Name = "Twój numer")]
        [DataType(DataType.PhoneNumber), Required(ErrorMessage = "Pole jest wymagane")]
        public int Number { get; set; }
    }
}
