using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using UdemyCarBook.Dtos.ServiceDtos;
using UdemyCarBook.Dtos.TestimonialDtos;

namespace UdemyCarBook.WebUI.Controllers
{
    public class ServiceController : Controller
    {
      

        public async Task<IActionResult> Index()
        {
          
            return View();
           
        }
    }
}
