using System.Web.Mvc;

namespace MVCTutorial.Controllers
{
    public class HelloWorldController : Controller
    {
        

        // 
        // GET: /HelloWorld/ 

        public ViewResult Index()
        {
            return View();
        }

        // 
        // GET: /HelloWorld/Welcome/ 

        public ActionResult Welcome(string name, int numTimes = 1)
        {
            ViewBag.Message = "Hello " + name;
            ViewBag.NumTimes = numTimes;

            return View();
        }
    }
}