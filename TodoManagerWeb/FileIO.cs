using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace TodoManagerWeb
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


        /// <summary> Saves file to the Tasks directory </summary>
        /// <param name="task">Name of task (also used for file name)</param>
        /// <returns>True if the task saves successfully</returns>
        public static bool SaveTask(Task task)
        {
            if (!string.IsNullOrEmpty(task.Title) && !ContainsIllegalChars(task.Title))
            {
                CheckDirExists();
                // Create new stream in the directory where this was started from
                StreamWriter w = new StreamWriter(".\\Tasks\\" + task.Title + ".json");
                string json = JsonConvert.SerializeObject(task);
                w.Write("[" + json + "]"); // Must add [] because of how tasks implemented
                w.Close();
                LoadTasks(); // Load all tasks again to update
                return true;
            }
            return false;
        }

        /// <summary> Loads all task files from Tasks directory </summary>
        public static void LoadTasks()
        {
            CheckDirExists();

            // Variables
            string dir = ".\\Tasks";
            DirectoryInfo d = new DirectoryInfo(dir);
            List<FileInfo> files = d.GetFiles("*").ToList();

            if (tasks == null) tasks = new List<Task>();
            else tasks.Clear(); // Clear list if being re-loaded

            foreach (FileInfo file in files)
            {
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

        /// <summary> Deletes file from Tasks sub-directory if found </summary>
        /// <param name="i">Index of task to delete</param>
        /// <returns>True if the task was successfully deleted</returns>
        public static bool DeleteTask(int i)
        {
            CheckDirExists();

            if (i < 0) // No task specified, alert user
            {
                System.Console.WriteLine("Can not delete a negative task");
            }
            else // Task specified
            {
                // Variables
                string title = tasks[i].Title;
                // To-do: Path may not work, test
                string path = ".\\Tasks\\" + title + ".json";

                if (File.Exists(path))
                {
                    File.Delete(path);
                    LoadTasks();
                    return true;
                }
                else // Task file does not exist, alert user
                {
                    System.Console.WriteLine("File at index " + i 
                        + " could not be deleted as it can not be found");
                }
            }

            return false;
        }

        /// <summary>
        /// Checks if Tasks directory exists, creates the directory if it does not.
        /// This function should be called at the start of every other File IO function.
        /// </summary>
        static void CheckDirExists()
        {
            if (!Directory.Exists(".\\Tasks\\")) 
                Directory.CreateDirectory(".\\Tasks\\");
        }


        /// <summary> Checks specified string for illegal characters for use in a file name </summary>
        /// <param name="s">String to check for illegal characters</param>
        /// <returns>True if string contains illegal characters</returns>
        static bool ContainsIllegalChars(string s)
        {
            char[] illegalChars =
                { '\\', '/', ':', '"', '<', '>', '|' };
            // Check if file name starts with $
            if (s.StartsWith('$')) return true;
            // Checks against array of illegal characters
            for (int i = 0; i < illegalChars.Length; i++)
                if (s.Contains(illegalChars[i])) return true;
            return false;
        }
    }
}
