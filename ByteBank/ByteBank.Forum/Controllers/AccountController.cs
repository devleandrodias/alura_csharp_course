using ByteBank.Forum.Models;
using ByteBank.Forum.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;

namespace ByteBank.Forum.Controllers
{
    public class AccountController : Controller
    {
        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(AccountRegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                var dbContext = new IdentityDbContext();

                var user = new IdentityUser
                {
                    Email = model.Email,
                    UserName = model.UserName
                };

                dbContext.Users.Add(user);

                dbContext.SaveChanges();

                return RedirectToAction("Index", "Home");
            }

            return View(model);
        }
    }
}
