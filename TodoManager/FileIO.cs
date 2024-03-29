﻿using Newtonsoft.Json;
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


        // Save
        /// <summary> Saves file to the Tasks directory </summary>
        /// <param name="task">Name of task (also used for file name)</param>
        /// <returns>True if successfully saved</returns>
        public static bool SaveTask(Task task)
        {
            if (!string.IsNullOrEmpty(task.Title) && !ContainsIllegalChars(task.Title))
            {
                CheckDirExists();
                // Create new stream in the directory where this was started from
                StreamWriter w = new StreamWriter(Application.StartupPath + "\\Tasks\\" + task.Title + ".json");
                string json = JsonConvert.SerializeObject(task);
                w.Write("[" + json + "]"); // Must add [] because of how tasks implemented
                w.Close();
                // To-do: Change instead to only add the new file in this instance?
                // Else iterating across all tasks unnecessarily
                LoadTasks(); // Load all tasks again to update
                return true;
            }
            return false;
        }

        // Load
        /// <summary> Loads all task files from Tasks directory </summary>
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
        /// Deletes file from Tasks sub-directory if found.
        /// Otherwise alerts the user via MessageBox that the file was not found
        /// OR if the user presses Delete when no task is selected.
        /// </summary>
        /// <param name="i">Index of task to delete</param>
        /// <returns>True if the task was successfully deleted</returns>
        public static bool DeleteTask(int i)
        {
            CheckDirExists();

            if (i < 0) // No task specified, alert user
            {
                string text = "You must select a task to delete.";
                string caption = "No Task Selected"; // Header of the message box
                MessageBox.Show(text, caption);
            }
            else // Task specified
            {
                // Variables
                string title = tasks[i].Title;
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
        /// Checks if Tasks directory exists, creates the directory if it does not.
        /// This function should be called at the start of every other File IO function.
        /// </summary>
        static void CheckDirExists()
        {
            if (!Directory.Exists(Application.StartupPath + "\\Tasks\\"))
                Directory.CreateDirectory(Application.StartupPath + "\\Tasks\\");
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
