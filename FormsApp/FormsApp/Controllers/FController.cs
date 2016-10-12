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
        public ActionResult R(ViewModel model)
        {
            if(model.first + model.second == model.top)
            {
                using (FormCon con = new FormCon())
                {
                    FormItem item = new FormItem();
                    item.Name = model.Name;
                    item.Phone = model.Phone;
                    item.RegisterDate = DateTime.Now;
                    item.Tender = model.Tender;
                    con.FormItem.Add(item);
                    con.SaveChanges();
                }

                TempData["AlertMessage"] = "Kayıt Alındı!";
            }
            else
            {
                TempData["AlertMessage"] = "Toplama Yanlış!";

            }
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