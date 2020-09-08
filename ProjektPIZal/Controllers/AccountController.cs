using ProjektPIZal.Models;
using ProjektPIZal.Models.Model;
using ProjektPIZal.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace ProjektPIZal.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Index()
        {
            return RedirectToAction("Login");
        }
        public ActionResult Login()
        {
            string userEmailAddress = User.Identity.Name;
            if (!string.IsNullOrEmpty(userEmailAddress))
                return RedirectToAction("Index", "Home");
            return View();
        }
        // POST: Account/Login
        [HttpPost]
        public ActionResult Login(UserLoginVM userLoginVM)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            using (var db = new DAL())
            {
                if (db.Users.Any(x => x.EmailAddress.Equals(userLoginVM.EmailAddress)
                && x.Password.Equals(userLoginVM.Password)))
                {
                    FormsAuthentication.SetAuthCookie(userLoginVM.EmailAddress, userLoginVM.RememberMe);
                    TempData["SM"] = "Witaj!";
                    return Redirect(FormsAuthentication.GetRedirectUrl(userLoginVM.EmailAddress, userLoginVM.RememberMe));
                }
                else
                {
                    ModelState.AddModelError("", "Nieprawidłowy adres E-mail lub hasło");
                    return View();
                }

            }

        }
        // GET: Account/Logout
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Login");
        }

        public ActionResult UserNavPartial()
        {
            string emailAddress = User.Identity.Name;
            UserNavPartialVM userNavPartialVM;
            using (var db = new DAL())
            {
                UserDTO userDTO = db.Users.FirstOrDefault(x => x.EmailAddress == emailAddress);
                userNavPartialVM = new UserNavPartialVM()
                {
                    UserId = userDTO.UserID,
                    FirstName = userDTO.FirstName,
                    LastName = userDTO.LastName
                };
            }
            return PartialView(userNavPartialVM);
        }
    }
}