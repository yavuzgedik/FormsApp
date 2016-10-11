using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FormsApp.Models
{
    public class FormItem
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Tender { get; set; }
        public DateTime RegisterDate { get; set; }
    }
}