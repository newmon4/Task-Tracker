using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace TaskTracker2.Controllers
{
    [ApiController]
    [Route("tasks")]
    public class TaskController : ControllerBase {


        //private static List<string> tasks = new List<string>();
        public class TaskItem
        {
            public int Id { get; set; }
            public string Name { get; set; }
        }
        private static int nextId = 1;

        private static List<TaskItem> tasks = new List<TaskItem>();

        [HttpGet]
        public List<TaskItem> GetTasks()
        {
            return tasks;
        }

        [HttpPost()]
        public TaskItem AddTask(TaskItem task)
        {

            task.Id = nextId++;
            tasks.Add(task);
            return task;
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteTask(int id)
        {
            var task = tasks.FirstOrDefault(t => t.Id == id);
            if (task != null)
            {
                tasks.Remove(task);
                return Ok();
            }
            else return NotFound();
        }

        [HttpPut("{id}")]
        public IActionResult EditTask(int id, TaskItem taskData)
        {
            var task = tasks.Find(t => t.Id == id);
            if (task != null)
            {
                task.Name = taskData.Name;
                return Ok();
            }
            else return BadRequest();
        }
    }
}
    