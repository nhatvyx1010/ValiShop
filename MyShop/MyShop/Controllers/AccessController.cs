using Microsoft.AspNetCore.Mvc;
using MyShop.Models;
namespace MyShop.Controllers
{
    public class AccessController : Controller
    {
        MyShopContext db = new MyShopContext();
        [HttpGet]
        public IActionResult Login()
        {
            if (HttpContext.Session.GetString("UserName") == null)
            {
                return View();
            }
            return RedirectToAction("Index", "Home");
        }
        [HttpPost]
        public IActionResult Login(TUser user)
        {
            if (HttpContext.Session.GetString("UserName")==null) 
            { 
                var u=db.TUsers.Where(x=>x.Username.Equals(user.Username) && x.Password.Equals(user.Password)).FirstOrDefault();
                if (u!=null)
                {
                    HttpContext.Session.SetString("UserName", u.Username.ToString());
                    return RedirectToAction("Index", "Home");
                }
            }
            return View();
        }
    }
}
