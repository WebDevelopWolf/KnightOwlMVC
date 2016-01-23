using System;

namespace KnightOwlMVC.Models.AnimalModels
{
    public class KeeperLog
    {
        public int KeeperLogId { get; set; }

        public DateTime IncidentDateTime { get; set; }

        public string Notes { get; set; }

        public virtual AnimalModels.Animal AnimalId { get; set; }

        public virtual Staff StaffId { get; set; }
    }
}