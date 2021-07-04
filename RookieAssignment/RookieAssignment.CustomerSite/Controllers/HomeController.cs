using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RookieAssignment.CustomerSite.Models;
using RookieAssignment.CustomerSite.Service;
using RookieAssignment.CustomerSite.Service.IService;
using RookieAssignment.Shared.DTOs;
using RookieAssignment.Shared.ViewModels;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace RookieAssignment.CustomerSite.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ICategoryService _categoryService;
        private readonly IMenuItemService _menuItemService;

        public HomeController(ILogger<HomeController> logger, ICategoryService categoryService, IMenuItemService menuItemService)
        {
            _logger = logger;
            this._categoryService = categoryService;
            this._menuItemService = menuItemService;
        }

        public async Task<IActionResult> Index()
        {
            IndexViewModel indexVm = new IndexViewModel()
            {
                MenuItem = await _menuItemService.GetAllAsync(Constant.menuItemAPIPath),
                Category = await _categoryService.GetAllAsync(Constant.categoryAPIPath)
            };
            return View(indexVm);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
