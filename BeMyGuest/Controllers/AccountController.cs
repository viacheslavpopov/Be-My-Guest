using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using BeMyGuest.Models;
using System;
using System.Threading.Tasks;
using BeMyGuest.ViewModels;

namespace BeMyGuest.Controllers
{
    public class AccountController : Controller
    {
        private readonly BeMyGuestContext _db;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;

        public AccountController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager, BeMyGuestContext db)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _db = db;
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> Register(RegisterViewModel model)
        {
            if(model.Password != model.ConfirmPassword)
            {
                ViewBag.Error = "Confirm that your passwords match";
                return View();
            }
            else
            {
                try
                {
                    var user = new ApplicationUser { UserName = model.Email, Email = model.Email };
                    IdentityResult result = await _userManager.CreateAsync(user, model.Password);
                    if(result.Succeeded)
                    {
                        return RedirectToAction("Index");
                    }
                    else
                    {
                        ViewBag.Error = result;
                        return View();
                    }
                }
                catch(Exception result)
                {
                    ViewBag.Error = result.Message;
                    return View();
                }
            }
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> Login(LoginViewModel model)
        {
            Microsoft.AspNetCore.Identity.SignInResult result = await _signInManager.PasswordSignInAsync(model.Email, model.Password, isPersistent: true, lockoutOnFailure: false);
            if(result.Succeeded)
            {
                return RedirectToAction("Index");
            }
            else
            {
                ViewBag.Error = result;
                return View();
            }
        }

        [HttpPost]
        public async Task<ActionResult> LogOff()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index");
        }

    }
}