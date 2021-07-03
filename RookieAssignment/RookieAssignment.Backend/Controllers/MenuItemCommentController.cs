﻿using AutoMapper;
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

namespace RookieAssignment.Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MenuItemCommentController : ControllerBase
    {
        private readonly ApplicationDbContext _db;
        private readonly IMapper _mapper;

        public MenuItemCommentController(ApplicationDbContext db, IMapper mapper)
        {
            this._db = db;
            this._mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllMenuItemComments()
        {
            var objList = await _db.MenuItemComment.ToListAsync();
            var objDTO = new List<MenuItemCommentDTO>();
            foreach (var obj in objList)
            {
                objDTO.Add(_mapper.Map<MenuItemCommentDTO>(obj));
            }
            return Ok(objDTO);
        }

        [HttpGet("{menuItemCommentId}")]
        public async Task<IActionResult> GetMenuItemComment(int menuItemCommentId)
        {
            var obj = await _db.MenuItemComment.FirstOrDefaultAsync(m => m.Id == menuItemCommentId);
            if (obj == null)
            {
                return NotFound();
            }
            var objDTO = _mapper.Map<MenuItemCommentDTO>(obj);
            return Ok(objDTO);
        }

        [HttpPost]
        public async Task<IActionResult> CreateMenuItemComment([FromBody] MenuItemCommentDTO menuItemComment)
        {
            if (menuItemComment == null)
            {
                return BadRequest(ModelState);
            }

            var menuItemCommentObj = _mapper.Map<MenuItemComment>(menuItemComment);
            _db.MenuItemComment.Add(menuItemCommentObj);
            await _db.SaveChangesAsync();

            return CreatedAtAction(nameof(GetMenuItemComment), new { menuItemCommentId = menuItemCommentObj.Id }, menuItemCommentObj);
        }

        [HttpPut("{menuItemCommentId}")]
        public async Task<IActionResult> UpdateMenuItemComment(int menuItemCommentId, [FromBody] MenuItemCommentDTO menuItemCommentDTO)
        {
            if (menuItemCommentDTO == null || menuItemCommentId != menuItemCommentDTO.Id)
            {
                return BadRequest(ModelState);
            }

            var menuItemCommentObj = _mapper.Map<MenuItemComment>(menuItemCommentDTO);
            _db.MenuItemComment.Update(menuItemCommentObj);
            await _db.SaveChangesAsync();

            return NoContent();
        }

        [HttpDelete("{menuItemCommentId}")]
        public async Task<IActionResult> DeleteMenuItemComment(int menuItemCommentId)
        {
            bool exits = _db.MenuItemComment.Any(c => c.Id == menuItemCommentId);
            if (!exits)
            {
                return NotFound();
            }

            var menuItemCommentObj = await _db.MenuItemComment.FindAsync(menuItemCommentId);
            _db.MenuItemComment.Remove(menuItemCommentObj);
            await _db.SaveChangesAsync();

            return NoContent();
        }
    }
}
