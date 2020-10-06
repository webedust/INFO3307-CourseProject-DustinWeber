using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace TodoManager
{
    public partial class MainForm : Form
    {
        public MainForm() { InitializeComponent(); }
        // Variables
        FileIO io = new FileIO();
        MainForm main;

        void ButtonCreate_Click(object sender, EventArgs e)
        {
            OpenCreateTask();
        }

        void ButtonDelete_Click(object sender, EventArgs e)
        {

        }

        void ButtonUpdate_Click(object sender, EventArgs e)
        {
            OpenCreateTask();
        }

        void MainForm_Load(object sender, EventArgs e)
        {
            io.UpdateFileCount();
            FillTasksList();
        }

        /// <summary>
        ///  Opens <c>Form_CreateTask</c>
        /// </summary>
        void OpenCreateTask()
        {
            Form_CreateTask form_createTask = new Form_CreateTask();
            main = (MainForm)Application.OpenForms[0];
            form_createTask.Show();
            form_createTask.OnShow(main);
        }

        /// <summary>
        ///  Fills the tasks list with Tasks from file
        /// </summary>
        public void FillTasksList()
        {
            // Variables
            List<Task> tasks = io.GetTasks();
            int[] loc = new int[2]; // Location the buttons will be created at
                loc[0] = TasksPanel.Location.X; // x, should not change
                loc[1] = TasksPanel.Location.Y; // y, increment by button height
            int width = TasksPanel.Width;   // Width of each task button
            int height = 30; // Height of each task button

            foreach (var t in tasks)
            {
                Button b = new Button();
                b.Name = "ButtonTask" + t.title;
                b.Text = t.title.ToString();

                // Cosmetic
                b.BackColor = TasksPanel.BackColor;
                b.FlatStyle = ButtonCreate.FlatStyle;

                // Transform
                b.Size = new Size(width, height);
                b.Location = new Point(loc[0], loc[1]);

                b.Click += delegate
                {
                    OutputTextbox.Text = t.description;
                };
                Controls.Add(b);

                // Increment location y by the height
                loc[1] += height;
            }
        }
    }
}
