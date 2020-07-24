using System;
using Microsoft.AspNetCore.Mvc;
using OTProje.ToDo.Business.Interfaces;

namespace OTProje.ToDo.Web.Controllers
{
    [ApiController]
    [Route("api/{controller}")]
    public class ToDoController : ControllerBase
    {
        private readonly IToDoService _toDoService;

        public ToDoController(IToDoService toDoService)
        {
            _toDoService = toDoService;
        } // GET To Dos // localhost:5001/api/to do

        [HttpGet]
        public ActionResult GetToDos()
        {
            try
            {
                var todoList = _toDoService.GetAll();
                return Ok(todoList);
            }
            catch (Exception e)
            {
                return BadRequest();
            }
        }

        // POST To Do
        // localhost:5001/api/to do
        
        [HttpPost]
        public ActionResult CreateToDo(Entities.Concrete.ToDo entity)
        {
            try
            {
                _toDoService.Create(entity);
                return Ok();
            }
            catch (Exception)
            {
                return BadRequest(entity);
            }
        } 
        
        // PUT To Do
        [HttpPut]
        public ActionResult UpdateToDo(int id, Entities.Concrete.ToDo entity)
        {
            if (id != entity.Id) return BadRequest();
            var toDo = _toDoService.GetById(id);
            if (toDo == null) return NotFound();
            toDo.Name = entity.Name;
            return NoContent();
        }
    }
}