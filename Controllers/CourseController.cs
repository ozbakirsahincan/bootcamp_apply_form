using BootcampForm.Models;
using Microsoft.AspNetCore.Mvc;

namespace BootcampForm.Controllers;

public class CourseController : Controller
{
    public IActionResult Index()
    {
        var model = Repository.Applications;
        return View(model);
    }

    public IActionResult Apply()
    {
        return View();
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Apply([FromForm] Candidate model)
    {
        if (Repository.Applications.Any(i => i.Email.Equals(model.Email)))
        {
            ModelState.AddModelError("", "You have already application. ");
        }

        if (ModelState.IsValid)
        {
            Repository.Add(model);
            return View("feedback", model);
        }

        return View();
    }
}