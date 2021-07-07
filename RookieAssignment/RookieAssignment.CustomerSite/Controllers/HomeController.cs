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
        private readonly IMenuItemCommentService _menuItemCommentService;

        public HomeController(ILogger<HomeController> logger, ICategoryService categoryService, 
               IMenuItemService menuItemService, IMenuItemCommentService menuItemCommentService)
        {
            _logger = logger;
            this._categoryService = categoryService;
            this._menuItemService = menuItemService;
            this._menuItemCommentService = menuItemCommentService;
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

        public async Task<IActionResult> Detail(int id)
        {
            //var menuItem = await _menuItemService.GetAsync(Constant.menuItemAPIPath, id);
            //return View(menuItem);

            DetailViewModel detailVM = new DetailViewModel()
            {
                menuItem = await _menuItemService.GetAsync(Constant.menuItemAPIPath, id),
                listMenuItemComments = await _menuItemCommentService.GetAllAsyncByParentId(Constant.menuItemCommentAPIPath, id)
            };

            return View(detailVM);
        }

        [HttpPost]
        public async Task<IActionResult> AddComment(int menuItemId, int rating, string articleComment)
        {
            MenuItemCommentDTO menuItemComment = new MenuItemCommentDTO()
            {
                MenuItemId = menuItemId,
                Rating = rating,
                PublishedDate = DateTime.Now.Date,
                Comment = articleComment
            };
            bool result = await _menuItemCommentService.CreateAsync(Constant.menuItemCommentAPIPath, menuItemComment);
            if(result)
            {
                return RedirectToAction(nameof(Index));
            }

            return View();
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
