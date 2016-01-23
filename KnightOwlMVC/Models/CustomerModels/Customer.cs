using System;

namespace KnightOwlMVC.Models.CustomerModels
{
    public class Customer
    {
        public int CustomerId { get; set; }

        public string Type { get; set; }

        public string Title { get; set; }

        public string FirstName { get; set; }

        public string Surname { get; set; }

        public virtual CustAddress CusAddressId { get; set; }

        public DateTime Birthday { get; set; }

        public DateTime LoggedDate { get; set; }

        public string Company { get; set; }

        public string JobTitle { get; set; }

        public string Notes { get; set; }
    }
}