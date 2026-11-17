using Microsoft.AspNetCore;
using TodoAPI.Models;
using TodoAPI.Data;


using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Diagnostics;

namespace TodoAPI.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class TodosController: ControllerBase 
    {
        private readonly AppDbContext _context;
        public TodosController(AppDbContext context) 
        {
            _context = context;
        
        }
        [HttpGet] public List<TodoItem> GetALL()
        {
            return _context.TodoItems.ToList();
        }
        [HttpGet("{id}")]
        public ActionResult<TodoItem> GetById(int id) 
        {
            TodoItem todoItem = _context.TodoItems.FirstOrDefault(t => t.Id == id);
            if (todoItem== null)
            {
                return NotFound();
            }
            return todoItem;
        
        }
        [HttpPost]
        public ActionResult<TodoItem> Create(TodoItem newTodoItem)
        {
            if (string.IsNullOrWhiteSpace(newTodoItem.Title))
            {
                return BadRequest("Görev adı boş olamaz");


            }
            _context.TodoItems.Add(newTodoItem);
            _context.SaveChanges();
            return CreatedAtAction(nameof(GetById), new { id = newTodoItem.Id }, newTodoItem);






        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id) 
        {
            TodoItem todoItem = _context.TodoItems.FirstOrDefault(t => t.Id == id);
            if (todoItem==null)
            {
                return NotFound();
            }
            _context.TodoItems.Remove(todoItem);
            _context.SaveChanges();
            return NoContent();

        
        }
        [HttpPut("{id}")]
        public IActionResult Delete(int id,TodoItem updateTodoItem)
        {
            TodoItem todoItem = _context.TodoItems.FirstOrDefault(t => t.Id == id);
            if (todoItem == null)
            {
                return NotFound();
            }
            todoItem.IsDone = updateTodoItem.IsDone;
            todoItem.Title = updateTodoItem.Title;

            _context.SaveChanges();
            return NoContent();


        }






    }



}






