using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FormsApp.Models
{
    public class ViewModel
    {
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Tender { get; set; }
        public DateTime RegisterDate { get; set; }
        public virtual int first { get; set; }
        public virtual int second { get; set; }
        public virtual int top { get; set; }
    }
}