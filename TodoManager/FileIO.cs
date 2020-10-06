using Newtonsoft.Json;
using System.Collections;
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
        List<Task> tasks; // List of all tasks read from files


        /// <summary>
        ///  Returns files in Tasks directory
        /// </summary>
        public List<Task> GetTasks() { return tasks; }

        /// <summary>
        /// Sets <c>files</c> equal to the # of files in the Tasks directory
        /// </summary>
        public void UpdateFileCount() 
        { 
            Directory.EnumerateFiles(Application.StartupPath + "Tasks").Count(); 
        }

        /// <summary>
        /// <para>Saves file to the Tasks directory</para>
        /// <c>
        /// <para>Parameters</para>
        /// <para>title = The name of the task (also used for file name)</para>
        /// <para>description = The description of the task</para>
        /// </c>
        /// </summary>
        public void SaveFile(string title, string description)
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
            UpdateFileCount();
        }

        /// <summary>
        /// <para>Loads file from Tasks sub-directory</para>
        /// <c>
        /// <para>Parameters</para>
        /// <para>file = The name of the file to load</para>
        /// <para>output = The textbox to output file contents to</para>
        /// </c>
        /// </summary>
        public void LoadFile(string file, RichTextBox output)
        {
            string dir = Application.StartupPath + "Tasks";
            string path = dir + "\\" + file + ".json";
            // Ensure file exists
            if (File.Exists(path))
            {
                StreamReader stream = new StreamReader(path);
                if (output != null) { output.Text = stream.ReadToEnd(); }
                stream.Close();
            }
            else // File does not exist
            {
                if (output != null) { output.Text = "File " + path + " does not exist."; }
            }

            using (StreamReader r = new StreamReader(path))
            {
                string json = r.ReadToEnd();
                tasks = JsonConvert.DeserializeObject<List<Task>>(json);
                output.Text = tasks[0].title.ToString();
            }
        }
    }
}
