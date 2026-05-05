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

        [HttpPost ("add")]
        public List<string> AddTask(string task)
        {
            tasks.Add(task);
            return tasks;
        }
    }
}
