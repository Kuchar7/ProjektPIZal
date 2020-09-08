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
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            List<TeaVM> teasList;
            using (var db = new DAL())
            {
                teasList = db.Teas.ToArray().Select(x => new TeaVM(x)).ToList();
            }


            return View(teasList);
        }

        [HttpGet]
        public ActionResult Details(int? id)
        {
            TeaVM model;
            using (DAL db = new DAL())
            {
                TeaDTO teaDTO = db.Teas.Find(id);
                if (teaDTO == null)
                {
                    return Content("Strona pusta!");
                }
                else
                {
                    model = new TeaVM(teaDTO);
                }              
            }
            return View(model);
        }
    }
}