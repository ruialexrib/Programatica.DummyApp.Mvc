using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Programatica.DummyApp.Data.Models;
using Programatica.DummyApp.Mvc.Models;
using Programatica.Framework.Services;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Programatica.DummyApp.Mvc.Controllers
{
    public class UsersController : Controller
    {
        private readonly IService<User> _userService;

        public UsersController(IService<User> userService)
        {
            _userService = userService;
        }


        public IActionResult Index()
        {
            var users = _userService.Get().ToList();
            
            return View(users);
        }


        public IActionResult Details(int id)
        {
            User user = _userService.Inspect(id);
            if (user == null)
            {
                return NotFound();
            }
            return View(user);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(User user)
        {
            if (ModelState.IsValid)
            {
                _userService.Create(user);
                return RedirectToAction("Index");
            }
            return View(user);
        }

        public ActionResult Edit(int id)
        {
            User user = _userService.Inspect(id);

            if (user == null)
            {
                return NotFound();
            }
            return View(user);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(User user)
        {
            if (ModelState.IsValid)
            {
                _userService.Modify(user);
                return RedirectToAction("Index");
            }
            return View(user);
        }

        public ActionResult Delete(int id)
        {
            User user = _userService.Get(id);
            if (user == null)
            {
                return NotFound();
            }
            return View(user);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            User user = _userService.Get(id);
            _userService.Delete(user.Id);
            return RedirectToAction("Index");
        }

    }
}
