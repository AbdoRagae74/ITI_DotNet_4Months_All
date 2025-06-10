using ITIMVC.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace ITIMVC.Controllers
{
    public class RoleController : Controller
    {
        public RoleController(RoleManager<IdentityRole> rm)
        {
            roleManager = rm;
        }

        public RoleManager<IdentityRole> roleManager { get; }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(RoleViewModel roleFromReq)
        {

            if (ModelState.IsValid) 
            {
                IdentityRole role = new IdentityRole() {
                    Name = roleFromReq.RoleName,
                };
                IdentityResult res  = await roleManager.CreateAsync(role);
                if (res.Succeeded) { 
                
                    return RedirectToAction("Home","Index");
                }
                foreach (var item in res.Errors)
                    ModelState.AddModelError("", item.Description);
            
            }
            return View("Create",roleFromReq);
        }
    }
}
