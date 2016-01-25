namespace KnightOwlMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Accidents",
                c => new
                    {
                        AccidentId = c.Int(nullable: false, identity: true),
                        Date = c.DateTime(nullable: false),
                        Location = c.String(),
                        Cause = c.String(),
                        Injury = c.String(),
                        Treatment = c.String(),
                        FurtherTreatment = c.Boolean(nullable: false),
                        StaffId_StaffId = c.Int(),
                    })
                .PrimaryKey(t => t.AccidentId)
                .ForeignKey("dbo.Staffs", t => t.StaffId_StaffId)
                .Index(t => t.StaffId_StaffId);
            
            CreateTable(
                "dbo.Staffs",
                c => new
                    {
                        StaffId = c.Int(nullable: false, identity: true),
                        Forename = c.String(),
                        Surname = c.String(),
                        Type = c.String(),
                        Placement = c.Boolean(nullable: false),
                        EduInst = c.String(),
                        EduContact = c.String(),
                        Started = c.DateTime(nullable: false),
                        Ended = c.DateTime(nullable: false),
                        Status = c.String(),
                        DrivingLicence = c.Boolean(nullable: false),
                        HealthSaftey = c.Boolean(nullable: false),
                        Tetnus = c.Boolean(nullable: false),
                        DoctorsName = c.String(),
                        DoctorContact = c.String(),
                        NextOfKin = c.String(),
                        NextOfKinContact = c.String(),
                        FirstAid = c.Boolean(nullable: false),
                        FirstAidExp = c.DateTime(nullable: false),
                        FireWarden = c.Boolean(nullable: false),
                        FireWardenExp = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.StaffId);
            
            CreateTable(
                "dbo.Animals",
                c => new
                    {
                        AnimalId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        AquiredDate = c.DateTime(nullable: false),
                        Picture = c.Binary(),
                        Age = c.Int(nullable: false),
                        Notes = c.String(),
                        Tempriment = c.String(),
                        ResidentStatus = c.String(),
                        LicenceNo = c.String(),
                        EnclosureId_EnclosureId = c.Int(),
                        SpeciesId_SpeciesId = c.Int(),
                    })
                .PrimaryKey(t => t.AnimalId)
                .ForeignKey("dbo.Enclosures", t => t.EnclosureId_EnclosureId)
                .ForeignKey("dbo.Species", t => t.SpeciesId_SpeciesId)
                .Index(t => t.EnclosureId_EnclosureId)
                .Index(t => t.SpeciesId_SpeciesId);
            
            CreateTable(
                "dbo.Enclosures",
                c => new
                    {
                        EnclosureId = c.Int(nullable: false, identity: true),
                        EnclosureName = c.String(),
                        Location = c.String(),
                    })
                .PrimaryKey(t => t.EnclosureId);
            
            CreateTable(
                "dbo.Species",
                c => new
                    {
                        SpeciesId = c.Int(nullable: false, identity: true),
                        AnimalSpecies = c.String(),
                    })
                .PrimaryKey(t => t.SpeciesId);
            
            CreateTable(
                "dbo.ApplicationSettings",
                c => new
                    {
                        ApplicationSettingsId = c.Int(nullable: false, identity: true),
                        InstitutionName = c.String(),
                        InstitutionContact = c.String(),
                        InstitutionOwner = c.String(),
                        Mail = c.Boolean(nullable: false),
                        Animal = c.Boolean(nullable: false),
                        Customer = c.Boolean(nullable: false),
                        Donation = c.Boolean(nullable: false),
                        Events = c.Boolean(nullable: false),
                        Marketing = c.Boolean(nullable: false),
                        Staff = c.Boolean(nullable: false),
                        Consumer = c.Boolean(nullable: false),
                        Web = c.Boolean(nullable: false),
                        Vet = c.String(),
                        VetContact = c.String(),
                    })
                .PrimaryKey(t => t.ApplicationSettingsId);
            
            CreateTable(
                "dbo.Bookings",
                c => new
                    {
                        BookingId = c.Int(nullable: false, identity: true),
                        TelephoneContact = c.String(),
                        VoucherType = c.String(),
                        VoucherCode = c.String(),
                        AdditionalInfoGiven = c.String(),
                        Notes = c.String(),
                        Date = c.DateTime(nullable: false),
                        CustomerId_CustomerId = c.Int(),
                        EventId_EventId = c.Int(),
                    })
                .PrimaryKey(t => t.BookingId)
                .ForeignKey("dbo.Customers", t => t.CustomerId_CustomerId)
                .ForeignKey("dbo.Events", t => t.EventId_EventId)
                .Index(t => t.CustomerId_CustomerId)
                .Index(t => t.EventId_EventId);
            
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        CustomerId = c.Int(nullable: false, identity: true),
                        Type = c.String(),
                        Title = c.String(),
                        FirstName = c.String(),
                        Surname = c.String(),
                        Birthday = c.DateTime(nullable: false),
                        LoggedDate = c.DateTime(nullable: false),
                        Company = c.String(),
                        JobTitle = c.String(),
                        Notes = c.String(),
                        CusAddressId_CustAddressId = c.Int(),
                    })
                .PrimaryKey(t => t.CustomerId)
                .ForeignKey("dbo.CustAddresses", t => t.CusAddressId_CustAddressId)
                .Index(t => t.CusAddressId_CustAddressId);
            
            CreateTable(
                "dbo.CustAddresses",
                c => new
                    {
                        CustAddressId = c.Int(nullable: false, identity: true),
                        AddressLine1 = c.String(),
                        AddressLine2 = c.String(),
                        AddressLine3 = c.String(),
                        AddressLine4 = c.String(),
                        Postcode = c.String(),
                        Country = c.String(),
                        DoNotContact = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.CustAddressId);
            
            CreateTable(
                "dbo.Events",
                c => new
                    {
                        EventId = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Type = c.String(),
                        Description = c.String(),
                        Price = c.Double(nullable: false),
                        Cost = c.Double(nullable: false),
                        NoPerDay = c.Int(nullable: false),
                        NoPerSession = c.Int(nullable: false),
                        Recurring = c.Boolean(nullable: false),
                        StartTime = c.DateTime(nullable: false),
                        EndTime = c.DateTime(nullable: false),
                        Location = c.String(),
                    })
                .PrimaryKey(t => t.EventId);
            
            CreateTable(
                "dbo.Contacts",
                c => new
                    {
                        ContactId = c.Int(nullable: false, identity: true),
                        Method = c.String(),
                        ContactSpecific = c.String(),
                        DoNotContact = c.Boolean(nullable: false),
                        CustomerId_CustomerId = c.Int(),
                    })
                .PrimaryKey(t => t.ContactId)
                .ForeignKey("dbo.Customers", t => t.CustomerId_CustomerId)
                .Index(t => t.CustomerId_CustomerId);
            
            CreateTable(
                "dbo.Donations",
                c => new
                    {
                        DonationId = c.Int(nullable: false, identity: true),
                        Value = c.Double(nullable: false),
                        Date = c.DateTime(nullable: false),
                        FundsTowards = c.String(),
                        ItemsDonated = c.String(),
                        Notes = c.String(),
                        CustomerId_CustomerId = c.Int(),
                    })
                .PrimaryKey(t => t.DonationId)
                .ForeignKey("dbo.Customers", t => t.CustomerId_CustomerId)
                .Index(t => t.CustomerId_CustomerId);
            
            CreateTable(
                "dbo.EventDays",
                c => new
                    {
                        EventDaysId = c.Int(nullable: false, identity: true),
                        Monday = c.Boolean(nullable: false),
                        Tuesday = c.Boolean(nullable: false),
                        Wednesday = c.Boolean(nullable: false),
                        Thursday = c.Boolean(nullable: false),
                        Friday = c.Boolean(nullable: false),
                        Saturday = c.Boolean(nullable: false),
                        Sunday = c.Boolean(nullable: false),
                        EventId_EventId = c.Int(),
                    })
                .PrimaryKey(t => t.EventDaysId)
                .ForeignKey("dbo.Events", t => t.EventId_EventId)
                .Index(t => t.EventId_EventId);
            
            CreateTable(
                "dbo.EventMonths",
                c => new
                    {
                        EventMonthsId = c.Int(nullable: false, identity: true),
                        Jan = c.Boolean(nullable: false),
                        Feb = c.Boolean(nullable: false),
                        Mar = c.Boolean(nullable: false),
                        Apr = c.Boolean(nullable: false),
                        May = c.Boolean(nullable: false),
                        Jun = c.Boolean(nullable: false),
                        Jul = c.Boolean(nullable: false),
                        Aug = c.Boolean(nullable: false),
                        Sep = c.Boolean(nullable: false),
                        Oct = c.Boolean(nullable: false),
                        Nov = c.Boolean(nullable: false),
                        Dec = c.Boolean(nullable: false),
                        EventId_EventId = c.Int(),
                    })
                .PrimaryKey(t => t.EventMonthsId)
                .ForeignKey("dbo.Events", t => t.EventId_EventId)
                .Index(t => t.EventId_EventId);
            
            CreateTable(
                "dbo.Feedings",
                c => new
                    {
                        FeedingId = c.Int(nullable: false, identity: true),
                        Day = c.String(),
                        Amount = c.String(),
                        Food = c.String(),
                        AnimalId_AnimalId = c.Int(),
                    })
                .PrimaryKey(t => t.FeedingId)
                .ForeignKey("dbo.Animals", t => t.AnimalId_AnimalId)
                .Index(t => t.AnimalId_AnimalId);
            
            CreateTable(
                "dbo.Grants",
                c => new
                    {
                        GrantId = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        AwardingBody = c.String(),
                        Amount = c.Double(nullable: false),
                        Status = c.String(),
                        EvidenceSupplied = c.String(),
                        Granted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.GrantId);
            
            CreateTable(
                "dbo.Helplines",
                c => new
                    {
                        HelplineId = c.Int(nullable: false, identity: true),
                        NameOfCaller = c.String(),
                        LocationOfCaller = c.String(),
                        TelephoneOfCaller = c.Int(nullable: false),
                        Injury = c.String(),
                        Outcome = c.String(),
                        AnimalId_AnimalId = c.Int(),
                        RescueCentreId_RescueCentreId = c.Int(),
                        StaffId_StaffId = c.Int(),
                    })
                .PrimaryKey(t => t.HelplineId)
                .ForeignKey("dbo.Animals", t => t.AnimalId_AnimalId)
                .ForeignKey("dbo.RescueCentres", t => t.RescueCentreId_RescueCentreId)
                .ForeignKey("dbo.Staffs", t => t.StaffId_StaffId)
                .Index(t => t.AnimalId_AnimalId)
                .Index(t => t.RescueCentreId_RescueCentreId)
                .Index(t => t.StaffId_StaffId);
            
            CreateTable(
                "dbo.RescueCentres",
                c => new
                    {
                        RescueCentreId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Contact = c.String(),
                        Location = c.String(),
                    })
                .PrimaryKey(t => t.RescueCentreId);
            
            CreateTable(
                "dbo.KeeperLogs",
                c => new
                    {
                        KeeperLogId = c.Int(nullable: false, identity: true),
                        IncidentDateTime = c.DateTime(nullable: false),
                        Notes = c.String(),
                        AnimalId_AnimalId = c.Int(),
                        StaffId_StaffId = c.Int(),
                    })
                .PrimaryKey(t => t.KeeperLogId)
                .ForeignKey("dbo.Animals", t => t.AnimalId_AnimalId)
                .ForeignKey("dbo.Staffs", t => t.StaffId_StaffId)
                .Index(t => t.AnimalId_AnimalId)
                .Index(t => t.StaffId_StaffId);
            
            CreateTable(
                "dbo.Lookups",
                c => new
                    {
                        LookupsId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Value1 = c.String(),
                        Value2 = c.String(),
                        Value3 = c.String(),
                        Value4 = c.String(),
                        Value5 = c.String(),
                    })
                .PrimaryKey(t => t.LookupsId);
            
            CreateTable(
                "dbo.Medicals",
                c => new
                    {
                        MedicalId = c.Int(nullable: false, identity: true),
                        TreatmentDate = c.DateTime(nullable: false),
                        TreatmentType = c.String(),
                        MedicationsAdministered = c.String(),
                        Dosage = c.Int(nullable: false),
                        AffectedAreaOrIllness = c.String(),
                        Notes = c.String(),
                        OutComeOrChange = c.String(),
                        AnimalId_AnimalId = c.Int(),
                    })
                .PrimaryKey(t => t.MedicalId)
                .ForeignKey("dbo.Animals", t => t.AnimalId_AnimalId)
                .Index(t => t.AnimalId_AnimalId);
            
            CreateTable(
                "dbo.Messages",
                c => new
                    {
                        MessageId = c.Int(nullable: false, identity: true),
                        Subject = c.String(),
                        Body = c.String(),
                        Date = c.DateTime(nullable: false),
                        Read = c.Boolean(nullable: false),
                        Important = c.Boolean(nullable: false),
                        Draft = c.Boolean(nullable: false),
                        Trash = c.Boolean(nullable: false),
                        FromStaff_StaffId = c.Int(),
                        ToStaff_StaffId = c.Int(),
                    })
                .PrimaryKey(t => t.MessageId)
                .ForeignKey("dbo.Staffs", t => t.FromStaff_StaffId)
                .ForeignKey("dbo.Staffs", t => t.ToStaff_StaffId)
                .Index(t => t.FromStaff_StaffId)
                .Index(t => t.ToStaff_StaffId);
            
            CreateTable(
                "dbo.MobileEntries",
                c => new
                    {
                        MobileEntryId = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Body = c.String(),
                    })
                .PrimaryKey(t => t.MobileEntryId);
            
            CreateTable(
                "dbo.MobileSettings",
                c => new
                    {
                        MobileSettingId = c.Int(nullable: false, identity: true),
                        Mobile = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.MobileSettingId);
            
            CreateTable(
                "dbo.Notifications",
                c => new
                    {
                        NotificationId = c.Int(nullable: false, identity: true),
                        Type = c.String(),
                        Seen = c.Boolean(nullable: false),
                        StaffId_StaffId = c.Int(),
                    })
                .PrimaryKey(t => t.NotificationId)
                .ForeignKey("dbo.Staffs", t => t.StaffId_StaffId)
                .Index(t => t.StaffId_StaffId);
            
            CreateTable(
                "dbo.PaymentSettings",
                c => new
                    {
                        PaymentSettingId = c.Int(nullable: false, identity: true),
                        OnlineBooking = c.Boolean(nullable: false),
                        PaymentMethod = c.String(),
                        PayPal = c.String(),
                        SagePay = c.String(),
                        WorldPay = c.String(),
                        SecureTrading = c.String(),
                        RealEx = c.String(),
                    })
                .PrimaryKey(t => t.PaymentSettingId);
            
            CreateTable(
                "dbo.Phobias",
                c => new
                    {
                        PhobiaId = c.Int(nullable: false, identity: true),
                        PhobiaOf = c.String(),
                        VolunteerLimits = c.String(),
                        StaffId_StaffId = c.Int(),
                    })
                .PrimaryKey(t => t.PhobiaId)
                .ForeignKey("dbo.Staffs", t => t.StaffId_StaffId)
                .Index(t => t.StaffId_StaffId);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        ProductId = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Cost = c.Double(nullable: false),
                        NetPrice = c.Double(nullable: false),
                        VatCost = c.Double(nullable: false),
                        DiscountedPrice = c.Double(nullable: false),
                        WebDiscount = c.Double(nullable: false),
                        Picture = c.Binary(),
                        Description = c.String(),
                        Category = c.String(),
                    })
                .PrimaryKey(t => t.ProductId);
            
            CreateTable(
                "dbo.RehomingLogs",
                c => new
                    {
                        RehomingLogId = c.Int(nullable: false, identity: true),
                        RemhomingDate = c.DateTime(nullable: false),
                        RehomingTo_StatusCode = c.Int(nullable: false),
                        RehomingTo_Redirect = c.String(),
                        RehomingTo_LockItem = c.Boolean(nullable: false),
                        Notes = c.String(),
                        AnimalId_AnimalId = c.Int(),
                        RehomingFrom_CustomerId = c.Int(),
                    })
                .PrimaryKey(t => t.RehomingLogId)
                .ForeignKey("dbo.Animals", t => t.AnimalId_AnimalId)
                .ForeignKey("dbo.Customers", t => t.RehomingFrom_CustomerId)
                .Index(t => t.AnimalId_AnimalId)
                .Index(t => t.RehomingFrom_CustomerId);
            
            CreateTable(
                "dbo.Relationships",
                c => new
                    {
                        RelationshipsId = c.Int(nullable: false, identity: true),
                        Relationship = c.String(),
                        Probability = c.Int(nullable: false),
                        CustomerId_CustomerId = c.Int(),
                        RelatedTo_CustomerId = c.Int(),
                    })
                .PrimaryKey(t => t.RelationshipsId)
                .ForeignKey("dbo.Customers", t => t.CustomerId_CustomerId)
                .ForeignKey("dbo.Customers", t => t.RelatedTo_CustomerId)
                .Index(t => t.CustomerId_CustomerId)
                .Index(t => t.RelatedTo_CustomerId);
            
            CreateTable(
                "dbo.Scripts",
                c => new
                    {
                        ScriptId = c.Int(nullable: false, identity: true),
                        EventScript = c.String(),
                        EventId_EventId = c.Int(),
                    })
                .PrimaryKey(t => t.ScriptId)
                .ForeignKey("dbo.Events", t => t.EventId_EventId)
                .Index(t => t.EventId_EventId);
            
            CreateTable(
                "dbo.SocialCampaigns",
                c => new
                    {
                        SocialCampaignId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Hashtag = c.String(),
                        Keywords = c.String(),
                        SocialMediaId_SocialMediaId = c.Int(),
                    })
                .PrimaryKey(t => t.SocialCampaignId)
                .ForeignKey("dbo.SocialMedias", t => t.SocialMediaId_SocialMediaId)
                .Index(t => t.SocialMediaId_SocialMediaId);
            
            CreateTable(
                "dbo.SocialMedias",
                c => new
                    {
                        SocialMediaId = c.Int(nullable: false, identity: true),
                        Type = c.String(),
                        SocialId = c.Int(nullable: false),
                        SocialUnique = c.String(),
                    })
                .PrimaryKey(t => t.SocialMediaId);
            
            CreateTable(
                "dbo.Sponsorships",
                c => new
                    {
                        SponsorshipId = c.Int(nullable: false, identity: true),
                        Package = c.String(),
                        Amount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        StartDate = c.DateTime(nullable: false),
                        EndDate = c.DateTime(nullable: false),
                        AnimalId_AnimalId = c.Int(),
                        CustomerId_CustomerId = c.Int(),
                    })
                .PrimaryKey(t => t.SponsorshipId)
                .ForeignKey("dbo.Animals", t => t.AnimalId_AnimalId)
                .ForeignKey("dbo.Customers", t => t.CustomerId_CustomerId)
                .Index(t => t.AnimalId_AnimalId)
                .Index(t => t.CustomerId_CustomerId);
            
            CreateTable(
                "dbo.StaffContacts",
                c => new
                    {
                        StaffContactId = c.Int(nullable: false, identity: true),
                        Method = c.String(),
                        ContactSpecific = c.String(),
                        StaffId_StaffId = c.Int(),
                    })
                .PrimaryKey(t => t.StaffContactId)
                .ForeignKey("dbo.Staffs", t => t.StaffId_StaffId)
                .Index(t => t.StaffId_StaffId);
            
            CreateTable(
                "dbo.StaffMedicals",
                c => new
                    {
                        StaffMedicalId = c.Int(nullable: false, identity: true),
                        MedicalCondition = c.String(),
                        Medication = c.String(),
                        Notes = c.String(),
                        StaffId_StaffId = c.Int(),
                    })
                .PrimaryKey(t => t.StaffMedicalId)
                .ForeignKey("dbo.Staffs", t => t.StaffId_StaffId)
                .Index(t => t.StaffId_StaffId);
            
            CreateTable(
                "dbo.StaffUsers",
                c => new
                    {
                        StaffUsersId = c.Int(nullable: false, identity: true),
                        Username = c.String(),
                        Password = c.String(),
                        AccessLevel = c.String(),
                        LastLogin = c.DateTime(nullable: false),
                        UserAgent = c.String(),
                        Picture = c.Binary(),
                    })
                .PrimaryKey(t => t.StaffUsersId);
            
            CreateTable(
                "dbo.Stocks",
                c => new
                    {
                        StockId = c.Int(nullable: false, identity: true),
                        StockNo = c.Int(nullable: false),
                        ResupplyLevel = c.Int(nullable: false),
                        ProductId_ProductId = c.Int(),
                        WarehouseId_WarehouseId = c.Int(),
                    })
                .PrimaryKey(t => t.StockId)
                .ForeignKey("dbo.Products", t => t.ProductId_ProductId)
                .ForeignKey("dbo.Warehouses", t => t.WarehouseId_WarehouseId)
                .Index(t => t.ProductId_ProductId)
                .Index(t => t.WarehouseId_WarehouseId);
            
            CreateTable(
                "dbo.Warehouses",
                c => new
                    {
                        WarehouseId = c.Int(nullable: false, identity: true),
                        WarehouseCode = c.Int(nullable: false),
                        WarehouseName = c.String(),
                        WarehouseLocation = c.String(),
                    })
                .PrimaryKey(t => t.WarehouseId);
            
            CreateTable(
                "dbo.SubSpecies",
                c => new
                    {
                        SubSpeciesId = c.Int(nullable: false, identity: true),
                        SubSpeciesName = c.String(),
                        SpeciesId_SpeciesId = c.Int(),
                    })
                .PrimaryKey(t => t.SubSpeciesId)
                .ForeignKey("dbo.Species", t => t.SpeciesId_SpeciesId)
                .Index(t => t.SpeciesId_SpeciesId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SubSpecies", "SpeciesId_SpeciesId", "dbo.Species");
            DropForeignKey("dbo.Stocks", "WarehouseId_WarehouseId", "dbo.Warehouses");
            DropForeignKey("dbo.Stocks", "ProductId_ProductId", "dbo.Products");
            DropForeignKey("dbo.StaffMedicals", "StaffId_StaffId", "dbo.Staffs");
            DropForeignKey("dbo.StaffContacts", "StaffId_StaffId", "dbo.Staffs");
            DropForeignKey("dbo.Sponsorships", "CustomerId_CustomerId", "dbo.Customers");
            DropForeignKey("dbo.Sponsorships", "AnimalId_AnimalId", "dbo.Animals");
            DropForeignKey("dbo.SocialCampaigns", "SocialMediaId_SocialMediaId", "dbo.SocialMedias");
            DropForeignKey("dbo.Scripts", "EventId_EventId", "dbo.Events");
            DropForeignKey("dbo.Relationships", "RelatedTo_CustomerId", "dbo.Customers");
            DropForeignKey("dbo.Relationships", "CustomerId_CustomerId", "dbo.Customers");
            DropForeignKey("dbo.RehomingLogs", "RehomingFrom_CustomerId", "dbo.Customers");
            DropForeignKey("dbo.RehomingLogs", "AnimalId_AnimalId", "dbo.Animals");
            DropForeignKey("dbo.Phobias", "StaffId_StaffId", "dbo.Staffs");
            DropForeignKey("dbo.Notifications", "StaffId_StaffId", "dbo.Staffs");
            DropForeignKey("dbo.Messages", "ToStaff_StaffId", "dbo.Staffs");
            DropForeignKey("dbo.Messages", "FromStaff_StaffId", "dbo.Staffs");
            DropForeignKey("dbo.Medicals", "AnimalId_AnimalId", "dbo.Animals");
            DropForeignKey("dbo.KeeperLogs", "StaffId_StaffId", "dbo.Staffs");
            DropForeignKey("dbo.KeeperLogs", "AnimalId_AnimalId", "dbo.Animals");
            DropForeignKey("dbo.Helplines", "StaffId_StaffId", "dbo.Staffs");
            DropForeignKey("dbo.Helplines", "RescueCentreId_RescueCentreId", "dbo.RescueCentres");
            DropForeignKey("dbo.Helplines", "AnimalId_AnimalId", "dbo.Animals");
            DropForeignKey("dbo.Feedings", "AnimalId_AnimalId", "dbo.Animals");
            DropForeignKey("dbo.EventMonths", "EventId_EventId", "dbo.Events");
            DropForeignKey("dbo.EventDays", "EventId_EventId", "dbo.Events");
            DropForeignKey("dbo.Donations", "CustomerId_CustomerId", "dbo.Customers");
            DropForeignKey("dbo.Contacts", "CustomerId_CustomerId", "dbo.Customers");
            DropForeignKey("dbo.Bookings", "EventId_EventId", "dbo.Events");
            DropForeignKey("dbo.Bookings", "CustomerId_CustomerId", "dbo.Customers");
            DropForeignKey("dbo.Customers", "CusAddressId_CustAddressId", "dbo.CustAddresses");
            DropForeignKey("dbo.Animals", "SpeciesId_SpeciesId", "dbo.Species");
            DropForeignKey("dbo.Animals", "EnclosureId_EnclosureId", "dbo.Enclosures");
            DropForeignKey("dbo.Accidents", "StaffId_StaffId", "dbo.Staffs");
            DropIndex("dbo.SubSpecies", new[] { "SpeciesId_SpeciesId" });
            DropIndex("dbo.Stocks", new[] { "WarehouseId_WarehouseId" });
            DropIndex("dbo.Stocks", new[] { "ProductId_ProductId" });
            DropIndex("dbo.StaffMedicals", new[] { "StaffId_StaffId" });
            DropIndex("dbo.StaffContacts", new[] { "StaffId_StaffId" });
            DropIndex("dbo.Sponsorships", new[] { "CustomerId_CustomerId" });
            DropIndex("dbo.Sponsorships", new[] { "AnimalId_AnimalId" });
            DropIndex("dbo.SocialCampaigns", new[] { "SocialMediaId_SocialMediaId" });
            DropIndex("dbo.Scripts", new[] { "EventId_EventId" });
            DropIndex("dbo.Relationships", new[] { "RelatedTo_CustomerId" });
            DropIndex("dbo.Relationships", new[] { "CustomerId_CustomerId" });
            DropIndex("dbo.RehomingLogs", new[] { "RehomingFrom_CustomerId" });
            DropIndex("dbo.RehomingLogs", new[] { "AnimalId_AnimalId" });
            DropIndex("dbo.Phobias", new[] { "StaffId_StaffId" });
            DropIndex("dbo.Notifications", new[] { "StaffId_StaffId" });
            DropIndex("dbo.Messages", new[] { "ToStaff_StaffId" });
            DropIndex("dbo.Messages", new[] { "FromStaff_StaffId" });
            DropIndex("dbo.Medicals", new[] { "AnimalId_AnimalId" });
            DropIndex("dbo.KeeperLogs", new[] { "StaffId_StaffId" });
            DropIndex("dbo.KeeperLogs", new[] { "AnimalId_AnimalId" });
            DropIndex("dbo.Helplines", new[] { "StaffId_StaffId" });
            DropIndex("dbo.Helplines", new[] { "RescueCentreId_RescueCentreId" });
            DropIndex("dbo.Helplines", new[] { "AnimalId_AnimalId" });
            DropIndex("dbo.Feedings", new[] { "AnimalId_AnimalId" });
            DropIndex("dbo.EventMonths", new[] { "EventId_EventId" });
            DropIndex("dbo.EventDays", new[] { "EventId_EventId" });
            DropIndex("dbo.Donations", new[] { "CustomerId_CustomerId" });
            DropIndex("dbo.Contacts", new[] { "CustomerId_CustomerId" });
            DropIndex("dbo.Customers", new[] { "CusAddressId_CustAddressId" });
            DropIndex("dbo.Bookings", new[] { "EventId_EventId" });
            DropIndex("dbo.Bookings", new[] { "CustomerId_CustomerId" });
            DropIndex("dbo.Animals", new[] { "SpeciesId_SpeciesId" });
            DropIndex("dbo.Animals", new[] { "EnclosureId_EnclosureId" });
            DropIndex("dbo.Accidents", new[] { "StaffId_StaffId" });
            DropTable("dbo.SubSpecies");
            DropTable("dbo.Warehouses");
            DropTable("dbo.Stocks");
            DropTable("dbo.StaffUsers");
            DropTable("dbo.StaffMedicals");
            DropTable("dbo.StaffContacts");
            DropTable("dbo.Sponsorships");
            DropTable("dbo.SocialMedias");
            DropTable("dbo.SocialCampaigns");
            DropTable("dbo.Scripts");
            DropTable("dbo.Relationships");
            DropTable("dbo.RehomingLogs");
            DropTable("dbo.Products");
            DropTable("dbo.Phobias");
            DropTable("dbo.PaymentSettings");
            DropTable("dbo.Notifications");
            DropTable("dbo.MobileSettings");
            DropTable("dbo.MobileEntries");
            DropTable("dbo.Messages");
            DropTable("dbo.Medicals");
            DropTable("dbo.Lookups");
            DropTable("dbo.KeeperLogs");
            DropTable("dbo.RescueCentres");
            DropTable("dbo.Helplines");
            DropTable("dbo.Grants");
            DropTable("dbo.Feedings");
            DropTable("dbo.EventMonths");
            DropTable("dbo.EventDays");
            DropTable("dbo.Donations");
            DropTable("dbo.Contacts");
            DropTable("dbo.Events");
            DropTable("dbo.CustAddresses");
            DropTable("dbo.Customers");
            DropTable("dbo.Bookings");
            DropTable("dbo.ApplicationSettings");
            DropTable("dbo.Species");
            DropTable("dbo.Enclosures");
            DropTable("dbo.Animals");
            DropTable("dbo.Staffs");
            DropTable("dbo.Accidents");
        }
    }
}
