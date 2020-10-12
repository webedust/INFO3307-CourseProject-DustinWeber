namespace TodoManager
{
    // Created by Dustin Weber
    /// <summary>
    /// Task object
    /// </summary>
    public class Task
    {
        public string title;
        public string description;
        public int dueDate;
        public bool isFinished;
        public int timeFinished;

        // Used when referencing this specific task in the FileIO Tasks list
        // It is set in LoadTasks()
        public int index;
    }
}
