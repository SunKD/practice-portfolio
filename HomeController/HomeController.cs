using System;
using Microsoft.AspNetCore.Mvc;

namespace portfolio.Controllers
{
    public class HomeController: Controller{
        [HttpGet]
        [Route("")]
        public IActionResult Index(){
            return View("Index");
        }

        [HttpGet]
        [Route("home/")]
        public IActionResult Home(){
            return View("Index");
        }

        [HttpGet]
        [Route("projects/")]
        public IActionResult Project(){
            return View("Project");
        }

        [HttpGet]
        [Route("contact/")]
        public IActionResult Contact(){
            return View("Contact");
        }
    }
}
