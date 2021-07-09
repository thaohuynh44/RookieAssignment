using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RookieAssignment.Backend.Data;
using RookieAssignment.Backend.Models;
using RookieAssignment.Shared.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static IdentityServer4.IdentityServerConstants;

namespace RookieAssignment.Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(LocalApi.PolicyName)]
    public class MenuItemController : ControllerBase
    {
        private readonly ApplicationDbContext _db;
        private readonly IMapper _mapper;

        public MenuItemController(ApplicationDbContext db, IMapper mapper)
        {
            this._db = db;
            this._mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllMenuItems()
        {
            var objList = await _db.MenuItem.Include(m => m.Category)
                                            .OrderBy(m => m.Name).ToListAsync();
            var objDTO = new List<MenuItemDTO>();
            foreach(var item in objList)
            {
                objDTO.Add(_mapper.Map<MenuItemDTO>(item));
            }
            return Ok(objDTO);
        }

        [HttpGet("{menuItemId}")]
        public async Task<IActionResult> GetMenuItem(int menuItemId)
        {
            var obj = await _db.MenuItem.FirstOrDefaultAsync(m => m.Id == menuItemId);
            if (obj == null)
            {
                return NotFound();
            }
            var objDTO = _mapper.Map<MenuItemDTO>(obj);
            return Ok(objDTO);
        }

        [HttpPost]
        public async Task<IActionResult> CreateMenuItem([FromBody] MenuItemDTO menuItem)
        {
            if (menuItem == null)
            {
                return BadRequest(ModelState);
            }

            if(_db.MenuItem.Any(m => m.Name.ToLower().Trim() == menuItem.Name.ToLower().Trim()))
            {
                ModelState.AddModelError("", "MenuItem Exits!");
                return StatusCode(404, ModelState);
            }

            var menuItemObj = _mapper.Map<MenuItem>(menuItem);
            _db.MenuItem.Add(menuItemObj);
            await _db.SaveChangesAsync();

            return CreatedAtAction(nameof(GetMenuItem), new { menuItemId = menuItemObj.Id }, menuItemObj);
        }

        [HttpPut("{menuItemId}")]
        public async Task<IActionResult> UpdateMenuItem(int menuItemId, [FromBody] MenuItemDTO menuItemDTO)
        {
            if (menuItemDTO == null || menuItemId != menuItemDTO.Id)
            {
                return BadRequest(ModelState);
            }

            var menuItemObj = _mapper.Map<MenuItem>(menuItemDTO);
            _db.MenuItem.Update(menuItemObj);
            await _db.SaveChangesAsync();

            return NoContent();
        }

        [HttpDelete("{menuItemId}")]
        public async Task<IActionResult> DeleteMenuItem(int menuItemId)
        {
            bool exits = _db.MenuItem.Any(c => c.Id == menuItemId);
            if (!exits)
            {
                return NotFound();
            }

            var menuItemObj = await _db.MenuItem.FindAsync(menuItemId);
            _db.MenuItem.Remove(menuItemObj);
            await _db.SaveChangesAsync();

            return NoContent();
        }

    }
}
