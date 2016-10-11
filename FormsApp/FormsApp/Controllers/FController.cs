using FormsApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FormsApp.Controllers
{
    public class FController : Controller
    {
        // R: registry
        public ActionResult R()
        {
            return View();
        }

        [HttpPost]
        public ActionResult R(FormItem model)
        {
            model.RegisterDate = DateTime.Now;

            using (FormCon con = new FormCon())
            {
                con.FormItem.Add(model);
                con.SaveChanges();
            }

            TempData["AlertMessage"] = "Kaydınız Alınmıştır!";
            return View();
        }

        // L: List
        public ActionResult L()
        {
            List<FormItem> list = new List<FormItem>();

            using (FormCon con = new FormCon())
            {
                list = con.FormItem.ToList();
            }
            return View(list);
        }
    }
}