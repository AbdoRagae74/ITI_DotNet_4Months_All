using ITIMVC.Models;
using ITIMVC.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using System.Threading.Tasks;

namespace ITIMVC.Controllers
{
    public class AccountController : Controller
    {
        public UserManager<ApplicationUser> userManager { get; }
        public SignInManager<ApplicationUser> signInManager { get; }
        

        public AccountController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
            
        }


        //Register - login - logout
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegisterViewModel userFromReq)
        {

            if (ModelState.IsValid)
            {
                ApplicationUser exist = await userManager.FindByEmailAsync(userFromReq.Email);
                if (exist != null)
                {
                    ModelState.AddModelError("Email", "Email already registered");
                    return View("Register", userFromReq);
                }

                ApplicationUser user = new ApplicationUser()
                {
                    Email = userFromReq.Email,
                    UserName = userFromReq.Email,
                    PasswordHash = userFromReq.password,
                    Address = userFromReq.Address,
                    DisplayName = userFromReq.UserName
                    
                };

                IdentityResult res = await userManager.CreateAsync(user, userFromReq.password);
                if (res.Succeeded)
                {
                    IdentityResult role = await userManager.AddToRoleAsync(user, "admin");
                    List<Claim> claims = new List<Claim>();
                    claims.Add(new Claim("Displayname", userFromReq.UserName));
                    //await signInManager.SignInAsync(user, false);
                    await signInManager.SignInWithClaimsAsync(user, false,claims);
                    //Response.Cookies.Append("Displayname", userFromReq.UserName);
                    return RedirectToAction("Index", "Instructor");
                }
                foreach (var item in res.Errors)
                    ModelState.AddModelError("", item.Description);
            }
            return View("Register", userFromReq);

        }

        public async Task<IActionResult> Logout()
        {
            await signInManager.SignOutAsync();
            return RedirectToAction("Login");
        }

        public IActionResult Login()
        {
            if (!User.Identity.IsAuthenticated)
                return View();
            else return RedirectToAction("Index", "Instructor");
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> Login(LoginViewModel userFromReq)
        {
            if (ModelState.IsValid)
            {
                ApplicationUser userDB = await userManager.FindByEmailAsync(userFromReq.Email);
                if (userDB != null)
                {

                    bool ok = await userManager.CheckPasswordAsync(userDB, userFromReq.password);
                    if (ok)
                    {
                        List<Claim> claims = new List<Claim>();
                        claims.Add(new Claim("Displayname", userDB.DisplayName));
                        //Response.Cookies.Append("Displayname", userDB.DisplayName);
                        //await signInManager.SignInAsync(userDB, userFromReq.rememberMe);
                        await signInManager.SignInWithClaimsAsync(userDB, userFromReq.rememberMe,claims);
                        return RedirectToAction("Index", "Instructor");
                    }
                    ModelState.AddModelError("", "Invalid credentials");
                }

            }
                return View(userFromReq);
        }
    }
}

