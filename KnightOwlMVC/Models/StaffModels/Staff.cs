using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using KnightOwlMVC.Models.CustomerModels;

namespace KnightOwlMVC.Models.StaffModels
{
    public class Staff
    {
        public int StaffId { get; set; }

        public string Forename { get; set; }

        public string Surname { get; set; }

        public virtual StaffContact StaffContactId { get; set; }

        public string Type {get; set;}

        public bool Placement { get; set; }

        public string EduInst { get; set; }

        public string EduContact { get; set; }

        public DateTime Started { get; set; }

        public DateTime Ended { get; set; }

        public string Status { get; set; }

        public bool DrivingLicence { get; set; }

        public bool HealthSaftey { get; set; }

        public bool Tetnus { get; set; }

        public string DoctorsName { get; set; }

        public string DoctorContact { get; set; }

        public string NextOfKin { get; set; }

        public string NextOfKinContact { get; set; }

        public bool FirstAid { get; set; }

        public DateTime FirstAidExp { get; set; }

        public bool FireWarden { get; set; }

        public DateTime FireWardenExp { get; set; }
    }
}