namespace KnightOwlMVC.Models.CustomerModels
{
    public class CustAddress
    {
        public int CustAddressId {get; set; }

        public string AddressLine1 { get; set; }

        public string AddressLine2 { get; set; }

        public string AddressLine3 { get; set; }

        public string AddressLine4 { get; set; }

        public string Postcode { get; set; }

        public string Country { get; set; }

        public bool DoNotContact { get; set; }
    }
}