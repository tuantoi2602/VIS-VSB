using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {
        DataTable dt;
        DAL _mdal = new DAL();
        private DBEntity db = new DBEntity();
        public ActionResult Add(shoe mo)
        {

            if (Session["cart"] == null)
            {
                List<shoe> li = new List<shoe>();

                li.Add(mo);
                Session["cart"] = li;
            }
            else
            {
                List<shoe> li = (List<shoe>)Session["cart"];
                li.Add(mo);
                Session["cart"] = li;
            }
            return RedirectToAction("Index", "Home");


        }
        public ActionResult Remove(shoe mob)
        {
            List<shoe> li = (List<shoe>)Session["cart"];
            li.RemoveAll(x => x.shoe_id == mob.shoe_id);
            Session["cart"] = li;
            return RedirectToAction("MyOrder", "Home");

        }

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult SearchShoe(string option, string search)
        {

            if (option == "Name")
            {
                
                return View(db.shoes.Where(x => x.name.Contains(search)).ToList());
            }
            else
            {
                return View(db.shoes.Where(x => x.brand.name == search || search == null).ToList());
            }
        }
        public ActionResult MyOrder()
        {
            return View((List<shoe>)Session["cart"]);

        }
        public ActionResult CheckOut()
        {
            return View();

        }
        public ActionResult Successful()
        {
            return View();

        }

    }
}