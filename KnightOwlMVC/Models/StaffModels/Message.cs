using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace KnightOwlMVC.Models.StaffModels
{
    public class Message
    {
        [ScaffoldColumn(false)]
        public int MessageId { get; set; }

        [DisplayName("To")]
        [Required(ErrorMessage = "Select a member of staff")]
        public virtual Staff ToStaff { get; set; }

        [DisplayName("From")]
        public virtual Staff FromStaff { get; set; }

        [Required(ErrorMessage = "Enter a Subject")]
        public string Subject { get; set; }

        public string Body { get; set; }

        public DateTime Date { get; set; }

        public bool Read { get; set; }

        public bool Important { get; set; }

        public bool Draft { get; set; }

        public bool Trash { get; set; }
    }
}