using Contacts.Models;
using Contacts.ViewModels.Account;
using System.Linq;
using Contacts.Services;
using System.Web.Mvc;

namespace Contacts.Controllers
{
    public class AccountController : Controller
    {
        // LOG IN

        public ActionResult Login(string RedirectUrl)
        {
            return View(new AccountLoginVM
            {
                RedirectUrl = RedirectUrl
            });
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(AccountLoginVM model)
        {
            AuthenticationService.AuthenticateUser(model.Username, model.Password);

            if (AuthenticationService.IsLogged)
            {
                if (string.IsNullOrWhiteSpace(model.RedirectUrl))
                {
                    return RedirectToAction("Index", "Home");
                }

                return Redirect(model.RedirectUrl);
            }

            return View();
        }

        // LOG OUT

        public ActionResult Logout()
        {
            AuthenticationService.LogOut();
            return RedirectToAction("Login", "Account");
        }

        // REGISTER

        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Register(AccountRegisterVM model)
        {
            if (ModelState.IsValid)
            {
                //UserRepository userRepo = new UserRepository();
                UnitOfWork unitOfWork = new UnitOfWork();

                User user = new User()
                {
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    Password = model.Password
                };

                bool userDoesntExist = true;

                //User userUsername = userRepo.GetAll(us => us.Username == model.Username).FirstOrDefault();
                User userUsername = unitOfWork.UserRepository.GetAllUsers(us => us.Username == model.Username).FirstOrDefault();

                if (userUsername != null)
                {
                    ModelState.AddModelError("Username", "Username already exists");
                    userDoesntExist = false;
                }

                user.Username = model.Username;

                User userEmail = unitOfWork.UserRepository.GetAllUsers(us => us.Email == model.Email).FirstOrDefault();

                if (userEmail != null)
                {
                    ModelState.AddModelError("Email", "Email already exists");
                    userDoesntExist = false;
                }

                user.Email = model.Email;

                if (userDoesntExist)
                {
                    unitOfWork.UserRepository.InsertUser(user);

                    return RedirectToAction("Login");
                }
            }

            return View(model);
        }
    }
}