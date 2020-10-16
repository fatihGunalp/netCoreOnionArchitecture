using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Onion.Domain;
using Onion.Service;

namespace Onion.MVC.Controllers
{
    public class UserController : Controller
    {
        IAppUserService _appuserService;

        public UserController(IAppUserService appuserService)
        {
            _appuserService = appuserService;
        }

        // GET: Users
        public async Task<IActionResult> Index()
        {
            return View(await _appuserService.GetAllUsers());
        }
        
        // GET: Users/Create
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(AppUser user)
        {
            if (ModelState.IsValid)
            {
                await _appuserService.AddUser(user);

                return RedirectToAction(nameof(Index));
            }
            return View(user);
        }
    }
}
