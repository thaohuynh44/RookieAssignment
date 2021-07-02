using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RookieAssignment.Backend.Models;
using RookieAssignment.Backend.Models.DTOs;
using RookieAssignment.Backend.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RookieAssignment.Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryRepository _categoryRepo;
        private readonly IMapper _mapper;

        public CategoryController(ICategoryRepository categoryRepo, IMapper mapper)
        {
            this._categoryRepo = categoryRepo;
            this._mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetAllCategories()
        {
            var objList = _categoryRepo.GetAllCategories();
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
            var obj = _categoryRepo.GetCategory(categoryId);
            if (obj == null)
            {
                return NotFound();
            }
            var objDTO = _mapper.Map<CategoryDTO>(obj);
            return Ok(objDTO);
        }

        [HttpPost]
        public IActionResult CreateCategoty([FromBody] CategoryDTO category)
        {
            if (category == null)
            {
                return BadRequest(ModelState);
            }
            if(_categoryRepo.IsCategoryExits(category.Name))
            {
                ModelState.AddModelError("", "Category Exits!");
                return StatusCode(404, ModelState);
            }
            var categoryObj = _mapper.Map<Category>(category);
            if (!_categoryRepo.CreateCategory(categoryObj))
            {
                ModelState.AddModelError("", $"Something went wrong when saving the record {categoryObj.Name}");
                return StatusCode(500, ModelState);
            }
            return CreatedAtAction(nameof(GetCategory), new { categoryId = categoryObj.Id }, categoryObj);
        }
    }
}
