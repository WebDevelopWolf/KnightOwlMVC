using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using KnightOwlMVC.Models;
using KnightOwlMVC.Models.EventsModels;

namespace KnightOwlMVC.ViewModels
{

    public class DashboardViewModel
    {
        public int ZooKeepCount { get; set; }

        public int BopCount { get; set; }

        public int OtherCount { get; set; }

        public DashboardViewModel() 
        {
            KnightOwlContext db = new KnightOwlContext();

            //Get Zoo Keeper Event Count
            var zooKeeperEvents = db.Bookings.Where(m => (m.EventId.Type == "ZK") && (m.Date == DateTime.Today));
            ZooKeepCount = zooKeeperEvents.Count();

            //Get Bird of Prey Event Count
            var bopEvents = db.Bookings.Where(m => (m.EventId.Type == "BOP") && (m.Date == DateTime.Today));
            BopCount = bopEvents.Count();

            //Get Bird of Prey Event Count
            var otherEvents = db.Bookings.Where(m => (m.EventId.Type == "OE") && (m.Date == DateTime.Today));
            OtherCount = otherEvents.Count();

        }
        
    }
}