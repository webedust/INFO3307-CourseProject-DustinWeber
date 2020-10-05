using System.IO;
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
        /// <summary>
        ///  Saves file to the Tasks sub-directory
        /// </summary>
        public void SaveFile(string text)
        {
            // Check if directory exists, create if it does NOT exist
            if (!Directory.Exists(Application.StartupPath + "\\Tasks\\"))
            {
                Directory.CreateDirectory(Application.StartupPath + "\\Tasks\\");
            }
            // Create new stream in the directory where this was started from
            StreamWriter stream = new StreamWriter(Application.StartupPath + "\\Tasks\\" + "TestTask.txt");
            stream.WriteLine("Label could go here: " + text);
            stream.Close();
        }

        /// <summary>
        /// <para>Loads file from Tasks sub-directory.</para>
        /// <c>
        /// <para>Parameters</para>
        /// <para>output = The textbox to output file contents to.</para>
        /// </c>
        /// </summary>
        public void LoadFile(RichTextBox output)
        {
            string dir = Application.StartupPath + "Tasks";
            string path = dir + "\\TestTask.txt";
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
        }
    }
}
