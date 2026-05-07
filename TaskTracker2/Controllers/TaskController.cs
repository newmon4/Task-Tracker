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

        [HttpPost ("add")]
        public TaskItem AddTask(TaskItem task)
        {

            task.Id = nextId++;
            tasks.Add(task);
            return task;
        }
    }
}
    