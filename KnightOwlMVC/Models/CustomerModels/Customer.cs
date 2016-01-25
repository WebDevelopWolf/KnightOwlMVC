using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace KnightOwlMVC.Models.CustomerModels
{
    public class Customer
    {
        [ScaffoldColumn(false)]
        public int CustomerId { get; set; }

        [DisplayName("Customer Type")]
        [Required(ErrorMessage = "Eg. Donor, Visitor etc.")]
        public string Type { get; set; }

        [Required(ErrorMessage = "Please enter the customers title")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Please enter the customers first name")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Please enter the customers surname")]
        public string Surname { get; set; }

        [DisplayName("Customer Address")]
        public virtual CustAddress CusAddressId { get; set; }

        public DateTime Birthday { get; set; }

        [DisplayName("Logged Date")]
        [Required(ErrorMessage = "Please enter the date this customer was logged")]
        [DataType(DataType.Date)]
        public DateTime LoggedDate { get; set; }

        public string Company { get; set; }

        [DisplayName("Job Title")]
        public string JobTitle { get; set; }

        [DataType(DataType.MultilineText)]
        public string Notes { get; set; }
    }
}