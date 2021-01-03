using System;
using System.Linq;
using DAWProject.Controllers.Dtos;
using DAWProject.Models.Base;
using DAWProject.Services.BaseService;
using Microsoft.AspNetCore.Mvc;

namespace DAWProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public abstract class BaseController<TEntity, TEntityDto> : ControllerBase 
        where TEntity : BaseEntity 
        where TEntityDto : BaseDto
    {
        protected readonly IBaseService<TEntity> Service;

        protected BaseController(IBaseService<TEntity> service)
        {
            Service = service;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(Service.FindAll().Select(MapToDto));
        }
        
        [HttpGet("id")]
        public IActionResult GetById(Guid id)
        {
            return Ok(MapToDto(Service.FindById(id)));
        }
        
        [HttpPost]
        public IActionResult Create(TEntityDto dto)
        {
            return Ok(Service.Create(MapToModel(dto)));
        } 
        
        [HttpPut]
        public IActionResult Update(TEntityDto dto)
        {
            return Ok(Service.Update(MapToModel(dto)));
        } 
        
        [HttpDelete("id")]
        public IActionResult Delete(Guid id)
        {
            Service.Delete(id);
            return Ok();
        }

        public abstract TEntity MapToModel(TEntityDto dto);
        public abstract TEntityDto MapToDto(TEntity model);
    }
}