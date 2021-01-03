using System;
using DAWProject.Models.Base;
using DAWProject.Services.BaseService;
using Microsoft.AspNetCore.Mvc;

namespace DAWProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BaseController<TEntity> : ControllerBase where TEntity : BaseEntity
    {
        protected readonly BaseService<TEntity> Service;

        public BaseController(BaseService<TEntity> service)
        {
            Service = service;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(Service.FindAll());
        }
        
        [HttpGet("id")]
        public IActionResult GetById(Guid id)
        {
            return Ok(Service.FindById(id));
        }
        
        [HttpPost]
        public IActionResult Create(TEntity entity)
        {
            return Ok(Service.Create(entity));
        } 
        
        [HttpPut]
        public IActionResult Update(TEntity entity)
        {
            return Ok(Service.Update(entity));
        } 
        
        [HttpDelete("id")]
        public IActionResult Delete(Guid id)
        {
            Service.Delete(id);
            return Ok();
        } 
    }
}