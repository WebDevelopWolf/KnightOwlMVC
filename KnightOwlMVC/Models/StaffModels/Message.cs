using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KnightOwlMVC.Models.StaffModels
{
    public class Message
    {
        public int MessageId { get; set; }

        public virtual Staff ToStaff { get; set; }

        public virtual Staff FromStaff { get; set; }

        public string Subject { get; set; }

        public string Body { get; set; }

        public DateTime Date { get; set; }

        public bool Read { get; set; }

        public bool Important { get; set; }

        public bool Draft { get; set; }

        public bool Trash { get; set; }
    }
}