using ProjektPIZal.Models;
using ProjektPIZal.Models.Model;
using ProjektPIZal.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjektPIZal.Controllers
{
    public class CartController : Controller
    {
        // GET: Cart
        public ActionResult Index(int? id)
        {
            CartVM model;
            using (DAL db = new DAL())
            {
                CartDTO cartDTO = db.Carts.Find(id);
                if (cartDTO == null)
                {
                    return Content("Strona pusta!");
                }
                else
                {
                    model = new CartVM(cartDTO);
                }

                return View();
            }
        }
    }
}
