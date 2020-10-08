using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace TodoManager
{
    // Created by Dustin Weber
    /// <summary>
    ///  Handles file I/O functions.
    ///  All UI references (i.e. button clicks) to call these functions are handled via
    ///  their respective Form class.
    /// </summary>
    public class FileIO
    {
        // Variables
        public List<Task> tasks; // List of all tasks read from files


        /// <summary>
        /// <para>Saves file to the Tasks directory</para>
        /// <c>
        /// <para>Parameters</para>
        /// <para>title = The name of the task (also used for file name)</para>
        /// <para>description = The description of the task</para>
        /// </c>
        /// </summary>
        public void SaveTask(string title, string description)
        {
            // Check if directory exists, create if it does NOT exist
            if (!Directory.Exists(Application.StartupPath + "\\Tasks\\"))
            {
                Directory.CreateDirectory(Application.StartupPath + "\\Tasks\\");
            }
            // Create new stream in the directory where this was started from
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
        /// <para>Loads file from Tasks sub-directory</para>
        /// <c>
        /// <para>Parameters</para>
        /// <para>file = The name of the file to load</para>
        /// <para>output = The textbox to output file contents to</para>
        /// </c>
        /// </summary>
        public void LoadTasks()
        {
            string dir = Application.StartupPath + "Tasks";
            DirectoryInfo d = new DirectoryInfo(dir);
            List<FileInfo> files = d.GetFiles("*").ToList();

            if (tasks == null) tasks = new List<Task>();
            else tasks.Clear();

            foreach (FileInfo file in files)
            {
                // To-do: Try to optimize this, very inefficient.
                List<Task> newTask;
                using StreamReader r = new StreamReader(file.FullName);
                string json = r.ReadToEnd();
                newTask = JsonConvert.DeserializeObject<List<Task>>(json);
                tasks.Add(newTask[0]);
                r.Close();
            }
        }

        /// <summary>
        /// <para>Deletes file from Tasks sub-directory</para>
        /// <c>
        /// <para>Parameters</para>
        /// <para>filename = The name of the file to delete</para>
        /// </c>
        /// </summary>
        public void DeleteTask(string filename)
        {

        }
    }
}
