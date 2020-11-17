namespace TodoManagerWeb
{
    // Created by Dustin Weber
    /// <summary> Task object </summary>
    public class Task
    {
        // Variables
        // Sorted in order of how they are saved in file
        public string Title { get; set; }
        public string Description { get; set; }
        public string DueDate { get; set; }
        public bool IsFinished { get; set; }
        public string TimeFinished { get; set; }

        // Used when referencing this specific task in the FileIO Tasks list
        // It is set in LoadTasks()
        public int index;


        // Constructors
        public Task() { } // Default
        public Task(string title, string description, string dueDate) // Parameters
        {
            Title = title;
            Description = description;
            DueDate = dueDate;
        }
    }
}
