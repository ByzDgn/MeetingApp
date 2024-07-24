
using Microsoft.AspNetCore.Mvc;
using MeetingApp.Models;

namespace MeetingApp.Controllers
{
     public class MeetingController : Controller

     {

    [HttpGet]
    public IActionResult Apply()
    {
        return View();
    }


     [HttpPost]
      public IActionResult Apply(UserInfo Model)
    {
       if(ModelState.IsValid){

             Repository.CreateUser(Model);
             ViewBag.UserCount = Repository.Users.Where(info=> info.WillAttend == true).Count();
             return View("Thanks", Model);
        } else{
            return View(Model);
        }

    }
        [HttpGet]
            public IActionResult List()
    {
        
        return View(Repository.Users);
    }


    public IActionResult Details(int id)
    {
        return View(Repository.GetById(id));
    }



     }
}
