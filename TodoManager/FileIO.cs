using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace TodoManager
{
    // Created by Dustin Weber
    /// <summary>
    /// Handles file I/O functions.
    /// All UI references (i.e. button clicks) to call these functions are handled via
    /// their respective class.
    /// </summary>
    public static class FileIO
    {
        // Variables
        public static List<Task> tasks; // List of all tasks read from files


        /// <summary>
        /// <para>Saves file to the Tasks directory</para>
        /// <c>
        /// <para>Parameters</para>
        /// <para>title: Name of task (also used for file name)</para>
        /// <para>description: The description of the task</para>
        /// </c>
        /// </summary>
        public static void SaveTask(string title, string description)
        {
            CheckDirExists();
            // Create new stream in the directory where this was started from
            // To-do: Try doing this using Json.Serialize
            StreamWriter w = new StreamWriter(Application.StartupPath + "\\Tasks\\" + title + ".json");
            w.WriteLine("[\n\t{");
            w.WriteLine("\t\t\"title\": " + "\"" + title + "\",");
            w.WriteLine("\t\t\"description\": " + "\"" + description +"\"");
            w.WriteLine("\t}\n]");
            w.Close();
            // To-do: Change instead to only add the new file in this instance?
            // Else iterating across all tasks unnecessarily
            LoadTasks(); // Load all tasks again to update
        }

        /// <summary>
        /// <para>Loads <b>all</b> task files from Tasks directory</para>
        /// </summary>
        public static void LoadTasks()
        {
            CheckDirExists();

            // Variables
            string dir = Application.StartupPath + "Tasks";
            DirectoryInfo d = new DirectoryInfo(dir);
            List<FileInfo> files = d.GetFiles("*").ToList();

            if (tasks == null) tasks = new List<Task>();
            else tasks.Clear(); // Clear list if being re-loaded

            foreach (FileInfo file in files)
            {
                // To-do: Try to optimize this, very inefficient.
                List<Task> newTask;
                using StreamReader r = new StreamReader(file.FullName);
                string json = r.ReadToEnd();
                newTask = JsonConvert.DeserializeObject<List<Task>>(json);

                // Set task index for reference later when deleting or modifying
                newTask[0].index = tasks.Count();

                tasks.Add(newTask[0]);
                r.Close();
            }
        }

        /// <summary>
        /// <para>Deletes file from Tasks sub-directory if found.
        /// Otherwise alerts the user via MessageBox that the file was not found
        /// OR if the user presses Delete when no task is selected.</para>
        /// <para>Returns <c>true</c> if the task is successfully deleted.
        /// Returns false otherwise.</para>
        /// <c>
        /// <para>Parameters</para>
        /// <para>i: Index of task to delete</para>
        /// </c>
        /// </summary>
        public static bool DeleteTask(int i)
        {
            CheckDirExists();

            if (i == -1) // No task specified, alert user
            {
                string text = "You must select a task to delete.";
                string caption = "No Task Selected"; // Header of the message box
                MessageBox.Show(text, caption);
            }
            else // Task specified
            {
                // Variables
                string title = tasks[i].title;
                string path = Application.StartupPath + "\\Tasks\\" + title + ".json";

                if (File.Exists(path))
                {
                    File.Delete(path);
                    LoadTasks();
                    return true;
                }
                else // Task file does not exist, alert user
                {
                    string text = "The task you are trying to delete can not be found.";
                    string caption = "Task Does Not Exist";
                    MessageBox.Show(text, caption);
                }
            }

            return false;
        }

        /// <summary>
        /// <para>Checks if the "Tasks" directory exists, 
        /// creates the directory if it does not.
        /// This function should be called at the start of every other File IO function.</para>
        /// </summary>
        static void CheckDirExists()
        {
            if (!Directory.Exists(Application.StartupPath + "\\Tasks\\"))
                Directory.CreateDirectory(Application.StartupPath + "\\Tasks\\");
        }
    }
}
