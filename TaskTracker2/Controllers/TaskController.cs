using Microsoft.AspNetCore.Mvc;

namespace TaskTracker2.Controllers
{
    [ApiController]
    [Route("tasks")]
    public class TaskController : ControllerBase

    {   private static List<string> tasks = new List<string>();
        [HttpGet]
        public List<string> GetTasks()
        {
            return tasks;
        }

        [HttpGet ("add")]
        public List<string> Add(string task)
        {
            tasks.Add(task);
            return tasks;
        }

        [HttpPost]
        public void AddTask(string task)
        {
            tasks.Add(task);
        }
    }
}
