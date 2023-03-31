using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ToDoList_ToDoAPI.Data;
using ToDoList_ToDoAPI.Models.Dto;

namespace ToDoList_ToDoAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ToDoController : ControllerBase
    {
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult<IEnumerable<ToDoDTO>> GetToDos()
        {
            return Ok(ToDoStore.toDoList);
        }
        [HttpGet("{id:int}", Name ="GetToDo")] //must specify that this Get should be receiving an Id parameter
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<ToDoDTO> GetToDo(int id)
        {
            if (id == 0)
            {
                return BadRequest();
            }

            var toDo = ToDoStore.toDoList.FirstOrDefault(u=>u.Id == id);
            if (toDo == null)
            {
                return NotFound();
            }
            return Ok(toDo);
        }
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<ToDoDTO> CreateToDo([FromBody]ToDoDTO toDoDTO)
        {
            if(toDoDTO == null)
            {
                return BadRequest(toDoDTO);
            }
            if(toDoDTO.Id > 0) 
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
            toDoDTO.Id = ToDoStore.toDoList.OrderByDescending(u=>u.Id).FirstOrDefault().Id + 1;
            return CreatedAtRoute("GetToDo", new { id = toDoDTO.Id }, toDoDTO);
        }
    }
}
