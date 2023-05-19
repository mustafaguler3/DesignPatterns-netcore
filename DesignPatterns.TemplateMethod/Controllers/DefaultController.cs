using DesignPatterns.TemplateMethod.TemplatePattern;
using Microsoft.AspNetCore.Mvc;

namespace DesignPatterns.TemplateMethod.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult BasicPlanIndex()
        {
            NetflixPlans netflixPlans = new BasicPlan();
            ViewBag.v1 = netflixPlans.PlanType("Basic Plan");
            ViewBag.v2 = netflixPlans.CountPerson(1);
            ViewBag.v3 = netflixPlans.Price(59.99);
            ViewBag.v4 = netflixPlans.Content("Movie");
            ViewBag.v5 = netflixPlans.Resolution("480px");

            return View();
        }

        public IActionResult StandardPlanIndex()
        {
            NetflixPlans netflixPlans = new BasicPlan();
            ViewBag.v1 = netflixPlans.PlanType("Standart Plan");
            ViewBag.v2 = netflixPlans.CountPerson(2);
            ViewBag.v3 = netflixPlans.Price(89.99);
            ViewBag.v4 = netflixPlans.Content("Movie-Animation-Horror");
            ViewBag.v5 = netflixPlans.Resolution("780px");

            return View();
        }

        public IActionResult UltraPlanIndex()
        {
            NetflixPlans netflixPlans = new BasicPlan();
            ViewBag.v1 = netflixPlans.PlanType("Ultra Plan");
            ViewBag.v2 = netflixPlans.CountPerson(4);
            ViewBag.v3 = netflixPlans.Price(139.99);
            ViewBag.v4 = netflixPlans.Content("All-Movie");
            ViewBag.v5 = netflixPlans.Resolution("1080px");

            return View();
        }
    }
}
