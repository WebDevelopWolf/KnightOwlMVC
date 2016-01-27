using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace KnightOwlMVC.Models.StaffModels
{
    public class ToDo
    {
        public int ToDoId { get; set; }

        public string Priority { get; set; }

        [Required(ErrorMessage = "To-do must have a body")]
        public string Text { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime Date { get; set; }

        public bool Complete { get; set; }

        public Staff StaffId { get; set; }
    }
}