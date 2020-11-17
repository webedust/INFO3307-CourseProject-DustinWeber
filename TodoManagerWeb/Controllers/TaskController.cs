using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace TodoManagerWeb.Controllers
{
    [Route("[controller]")]
    [ApiController]
    // Created by Dustin Weber
    /// <summary> Web controller for the Task object </summary>
    public class TaskController : ControllerBase
    {
        // GET /task    REST: Read
        [HttpGet]
        public IEnumerable<Task> GetAllTasks()
        {
            FileIO.LoadTasks();
            return FileIO.tasks;
        }

        // GET task/<id>
        /// <summary> Get task with specified index i from list of tasks </summary>
        /// <param name="i">Index of task to get</param>
        /// <returns>Task specified at index i</returns>
        [HttpGet("{i}")]
        public Task GetTask(int i)
        {
            return FileIO.tasks[i];
        }

        // POST /task    REST: Create
        /// <summary> Create new task </summary>
        /// <param name="title">Title of the task</param>
        /// <param name="description">Description of the task</param>
        /// <param name="dueDate">Date task is due. Formatted as DD-Mon-YY</param>
        [HttpPost]
        public void PostTask(string title, string description, string dueDate)
        {
            Task task = new Task(title, description, dueDate);
            FileIO.SaveTask(task);
        }

        // PUT task/<id>    REST: Update
        [HttpPut("{i}")]
        /// <summary> Delete old task of same index and create new "updated" task </summary>
        /// <param name="i">Index of task</param>
        /// <param name="title">Title of the task</param>
        /// <param name="description">Description of the task</param>
        /// <param name="dueDate">Date task is due formatted as DD-Mon-YY</param>
        public void PutTask(int i, string title, string description, string dueDate)
        {
            // Delete old task under same index
            FileIO.DeleteTask(i);
            // Replace with new task
            PostTask(title, description, dueDate);
        }

        // DELETE task/<id>    REST: Delete
        [HttpDelete("{i}")]
        /// <summary> Delete task at index i </summary>
        /// <param name="i">Index of task to delete</param>
        public void Delete(int i) => FileIO.DeleteTask(i);
    }
}
