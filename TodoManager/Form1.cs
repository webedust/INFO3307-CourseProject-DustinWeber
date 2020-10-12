using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace TodoManager
{
    // Created by Dustin Weber
    /// <summary>
    /// Main form the user sees when launching the program.
    /// Handles button presses and opening other forms in the program.
    /// </summary>
    public partial class MainForm : Form
    {
        // Variables
        List<Button> taskBtns; // All buttons associated with a task loaded at runtime
        int currentTask = -1; // Title of the currently selected task


        public MainForm() { InitializeComponent(); }

        void ButtonCreate_Click(object sender, EventArgs e)
        {
            // Open "Create Task" form w. -1 task parameter since new task is being created
            OpenCreateTask(-1);
        }

        /// <summary>
        /// Tries to delete currently selected task.
        /// If the task successfully deletes then the task list view is refreshed.
        /// </summary>
        void ButtonDelete_Click(object sender, EventArgs e)
        {
            if (FileIO.DeleteTask(currentTask)) FillTasksList();
        }

        void ButtonUpdate_Click(object sender, EventArgs e)
        {
            OpenCreateTask(currentTask);
        }

        void MainForm_Load(object sender, EventArgs e)
        {
            FillTasksList();
        }

        /// <summary>
        /// <para>Opens <c>Form_CreateTask</c></para>
        /// <c>
        /// <para>Parameters</para>
        /// <para>index: Index of task to modify, set -1 if new task is being created</para>
        /// </c>
        /// </summary>
        void OpenCreateTask(int index)
        {
            Form_CreateTask form_createTask = new Form_CreateTask();
            MainForm main = (MainForm)Application.OpenForms[0];

            form_createTask.Show();
            form_createTask.OnShow(main, index);
        }

        /// <summary>
        /// Fills the tasks list UI with Tasks from FileIO Tasks list
        /// </summary>
        public void FillTasksList()
        {
            // Variables
            int[] loc = new int[2]; // Location the buttons will be created at
            loc[0] = TasksPanel.Location.X; // x, should not change
            loc[1] = TasksPanel.Location.Y; // y, increment by button height
            int width = TasksPanel.Width;   // Width of each task button
            int height = 30; // Height of each task button

            // Disables & hides all task buttons if they have already been created
            // This would apply when creating a new tasks or deleting a task
            // This way duplicate tasks are not shown
            if (taskBtns != null)
            {
                for (int i = 0; i < taskBtns.Count; i++)
                {
                    Controls.Remove(taskBtns[i]);
                    taskBtns[i].Enabled = false;
                    taskBtns[i].Visible = false;
                }
                taskBtns.Clear();
            }
            else taskBtns = new List<Button>();

            FileIO.LoadTasks();

            foreach (var task in FileIO.tasks)
            {
                Button b = new Button();
                b.Name = "ButtonTask" + task.title;
                b.Text = task.title.ToString();

                // Cosmetic
                b.BackColor = TasksPanel.BackColor;
                b.FlatStyle = ButtonCreate.FlatStyle;

                // Transform
                b.Size = new Size(width, height);
                b.Location = new Point(loc[0], loc[1]);

                b.Click += delegate
                {
                    currentTask = task.index;
                    OutputTextbox.Text = task.description;
                };
                Controls.Add(b);

                // Increment location y by the height
                loc[1] += height;
                taskBtns.Add(b);
            }
        }
    }
}
