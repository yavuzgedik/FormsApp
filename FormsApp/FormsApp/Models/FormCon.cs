namespace FormsApp.Models
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class FormCon : DbContext
    {
        public FormCon()
            : base("name=FormCon")
        {
        }
        public virtual DbSet<FormItem> FormItem { get; set; }
    }
}