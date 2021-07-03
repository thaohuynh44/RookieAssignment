using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RookieAssignment.Backend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RookieAssignment.Shared;
using RookieAssignment.Shared.DTOs;
using RookieAssignment.Backend.Data;
using Microsoft.EntityFrameworkCore;

namespace RookieAssignment.Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ApplicationDbContext _db;
        private readonly IMapper _mapper;

        public CategoryController(ApplicationDbContext db, IMapper mapper)
        {
            this._db = db;
            this._mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllCategories()
        {
            var objList = await _db.Category.ToListAsync();
            var objDTO = new List<CategoryDTO>();
            foreach (var obj in objList)
            {
                objDTO.Add(_mapper.Map<CategoryDTO>(obj));
            }
            return Ok(objDTO);
        }

        [HttpGet("{categoryId}")]
        public IActionResult GetCategory(int categoryId)
        {
            var obj = _db.Category.FirstOrDefault(c => c.Id == categoryId);
            if (obj == null)
            {
                return NotFound();
            }
            var objDTO = _mapper.Map<CategoryDTO>(obj);
            return Ok(objDTO);
        }

        [HttpPost]
        public async Task<IActionResult> CreateCategoty([FromBody] CategoryDTO category)
        {
            if (category == null)
            {
                return BadRequest(ModelState);
            }
            if (_db.Category.Any(c => c.Name.ToLower().Trim() == category.Name.ToLower().Trim()))
            {
                ModelState.AddModelError("", "Category Exits!");
                return StatusCode(404, ModelState);
            }
            var categoryObj = _mapper.Map<Category>(category);
            _db.Category.Add(categoryObj);
            await _db.SaveChangesAsync();

            return CreatedAtAction(nameof(GetCategory), new { categoryId = categoryObj.Id }, categoryObj);
        }

        [HttpPut("{categoryId}")]
        public async Task<IActionResult> UpdateCategory(int categoryId, [FromBody] CategoryDTO categoryDTO)
        {
            if (categoryDTO == null || categoryId != categoryDTO.Id)
            {
                return BadRequest(ModelState);
            }

            var categoryObj = _mapper.Map<Category>(categoryDTO);
            _db.Category.Update(categoryObj);
            await _db.SaveChangesAsync();

            return NoContent();
        }

        [HttpDelete("{categoryId}")]
        public async Task<IActionResult> DeleteCategory(int categoryId)
        {
            bool exits = _db.Category.Any(c => c.Id == categoryId);
            if (!exits)
            {
                return NotFound();
            }

            var categoryObj = await _db.Category.FindAsync(categoryId);
            _db.Category.Remove(categoryObj);
            await _db.SaveChangesAsync();

            return NoContent();
        }
    }
}
