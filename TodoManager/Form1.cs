using System;
using System.IO;
using System.Windows.Forms;

namespace TodoManager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void ButtonSave_Click(object sender, EventArgs e)
        {
            // Check if directory exists, create if it does NOT exist
            if (!Directory.Exists(Application.StartupPath + "\\Tasks\\"))
            {
                Directory.CreateDirectory(Application.StartupPath + "\\Tasks\\");
            }
            // Create new stream in the directory where this was started from
            StreamWriter stream = new StreamWriter(Application.StartupPath + "\\Tasks\\" + "TestTask.txt");
            stream.WriteLine("Label could go here: " + Textbox.Text);
            stream.Close();
        }

        void ButtonLoad_Click(object sender, EventArgs e)
        {
            string dir = Application.StartupPath + "Tasks";
            string path = dir + "\\TestTask.txt";
            // Ensure file exists
            if (File.Exists(path))
            {
                StreamReader stream = new StreamReader(path);
                OutputTextbox.Text = stream.ReadToEnd();
                stream.Close();
            }
            else // File does not exist
            {
                OutputTextbox.Text = "File " + path + " does not exist.";
            }
        }
    }
}
