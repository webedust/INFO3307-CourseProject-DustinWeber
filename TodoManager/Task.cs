namespace TodoManager
{
    // Created by Dustin Weber
    /// <summary>
    /// Task object
    /// </summary>
    public class Task
    {
        // Variables
        // Sorted in order of how they are saved in file
        public string title;
        public string description;
        public string dueDate;
        public bool isFinished;
        public string timeFinished;

        // Used when referencing this specific task in the FileIO Tasks list
        // It is set in LoadTasks()
        public int index;


        // Constructors
        public Task() {} // Default
        public Task(string title, string description, string dueDate) // Parameters
        {
            this.title = title;
            this.description = description;
            this.dueDate = dueDate;
        }
    }
}
