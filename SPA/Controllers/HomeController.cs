using Microsoft.AspNetCore.Mvc;
using SPA.Models;

namespace SPA.Controllers
{
    public class HomeController:Controller
    {
        ReservationRepository repos = ReservationRepository.Current;

        public IActionResult Index() 
        {
            return View(repos.GetAll());
        }

        public ActionResult Add(Reserve item) 
        {
            if (ModelState.IsValid)
            {
                repos.Add(item);
                return RedirectToAction("Index");
            }
            else return View("Index");
            
        }
    }
}
