using DesignPattern.BusinessLayer.Abstract;
using DesignPattern.EntityLayer.Concrete;
using DesignPatterns.UnitOfWorkPattern.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace DesignPatterns.UnitOfWorkPattern.Controllers
{
    public class DefaultController : Controller
    {
        private readonly ICustomerService customerService;

        public DefaultController(ICustomerService customerService)
        {
            this.customerService = customerService;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(CustomerViewModel model)
        {
            var value1 = customerService.GetById(model.SenderId);
            var value2 = customerService.GetById(model.ReceiverId);
            value1.Balance -= model.Amount;
            value2.Balance += model.Amount;
            List<Customer> modifiedCustomer = new List<Customer>
            {
                value1, value2
            };

            customerService.MultiUpdate(modifiedCustomer);

            return View();
        }
    }
}
