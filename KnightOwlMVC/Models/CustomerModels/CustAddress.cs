using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace KnightOwlMVC.Models.CustomerModels
{
    public class CustAddress
    {
        [ScaffoldColumn(false)]
        public int CustAddressId {get; set; }

        [DisplayName("Address Line 1")]
        [Required(ErrorMessage = "Please enter the customers first line of their address")]
        public string AddressLine1 { get; set; }

        [DisplayName("Address Line 2 (optional)")]
        public string AddressLine2 { get; set; }

        [DisplayName("City")]
        [Required(ErrorMessage = "Please enter the customers City")]
        public string AddressLine3 { get; set; }

        [DisplayName("County")]
        [Required(ErrorMessage = "Please enter the customers County")]
        public string AddressLine4 { get; set; }

        [DisplayName("Post Code")]
        [Required(ErrorMessage = "Please enter the customers post code")]
        [DataType(DataType.PostalCode)]
        public string Postcode { get; set; }

        [DisplayName("Country")]
        [Required(ErrorMessage = "Please enter the customers Country")]
        public string Country { get; set; }

        [DisplayName("Check this box if the customer wishes to not be contacted via this address")]
        [Required(ErrorMessage = "Please select an option")]
        public bool DoNotContact { get; set; }
    }
}