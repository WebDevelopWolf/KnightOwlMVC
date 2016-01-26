using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Web;
using KnightOwlMVC.Models.ConsumerModels;
using KnightOwlMVC.Models.CustomerModels;
using KnightOwlMVC.Models.DonationsModels;
using KnightOwlMVC.Models.EventsModels;
using KnightOwlMVC.Models.MarketingModels;
using KnightOwlMVC.Models.StaffModels;
using KnightOwlMVC.Models.WebModels;

namespace KnightOwlMVC.Models
{
    public class KnightOwlContext : DbContext
    {
        #region AnimalModel
        public DbSet<AnimalModels.Animal> Animals { get; set; }
        public DbSet<AnimalModels.Enclosure> Enclosures { get; set; }
        public DbSet<AnimalModels.Feeding> Feedings { get; set; }
        public DbSet<AnimalModels.Helpline> Helplines { get; set; }
        public DbSet<AnimalModels.KeeperLog> KeeperLogs { get; set; }
        public DbSet<AnimalModels.Medical> Medicals { get; set; }
        public DbSet<AnimalModels.RehomingLog> RehomingLogs { get; set; }
        public DbSet<AnimalModels.RescueCentre> RescueCentres { get; set; }
        public DbSet<AnimalModels.Species> Specieses { get; set; }
        public DbSet<AnimalModels.SubSpecies> SubSpecieses { get; set; }
        public DbSet<AnimalModels.MobileEntry> MobileEntries { get; set; }
        #endregion

        #region ConsumerModel
        public DbSet<Product> Products { get; set; }
        public DbSet<Stock> Stocks { get; set; }
        public DbSet<Warehouse> Warehouses { get; set; }
        #endregion

        #region CustomerModels
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<CustAddress> CustAddresses { get; set; }
        public DbSet<Relationships> Relationships { get; set; }
        #endregion

        #region DonationsModels
        public DbSet<Donation> Donations { get; set; }
        public DbSet<Grant> Grants { get; set; }
        public DbSet<Sponsorship> Sponsorships { get; set; }
        #endregion

        #region EventModels
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<EventDays> EventDays { get; set; }
        public DbSet<EventMonths> EventMonths { get; set; }
        public DbSet<Script> Scripts { get; set; }
        #endregion

        #region MarketingModels
        public DbSet<SocialCampaign> SocialCampaigns { get; set; }
        public DbSet<SocialMedia> SocialMedia { get; set; }
        #endregion

        #region StaffModels
        public DbSet<Accident> Accidents { get; set; }
        public DbSet<StaffMedical> StaffMedicals { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Phobia> Phobias { get; set; }
        public DbSet<Staff> Staff { get; set; }
        public DbSet<StaffContact> StaffContacts { get; set; }
        #endregion

        #region WebModels
        public DbSet<ApplicationSettings> ApplicationSettings { get; set; }
        public DbSet<Lookups> Lookups { get; set; }
        public DbSet<MobileSetting> MobileSettings { get; set; }
        public DbSet<StaffUsers> StaffUsers { get; set; }
        public DbSet<PaymentSetting> PaymentSettings { get; set; }
        #endregion
    }
}