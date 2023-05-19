﻿using DesignPatterns.ObserverPattern.DAL;
using DesignPatterns.ObserverPattern.Models;
using DesignPatterns.ObserverPattern.ObserverPattern;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace DesignPatterns.ObserverPattern.Controllers
{
    public class DefaultController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly ObserverObject _observerObject;

        public DefaultController(UserManager<AppUser> userManager, ObserverObject observerObject)
        {
            _userManager = userManager;
            _observerObject = observerObject;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(RegisterViewModel model)
        {
            var appUser = new AppUser
            {
                Name = model.Name,
                Surname = model.Surname,
                Email = model.Email,
                UserName = model.Username
            };
            var result = await _userManager.CreateAsync(appUser,model.Password);

            if (result.Succeeded)
            {
                _observerObject.NotifyObserver(appUser);
            }

            return View();
        }
    }
}
