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
        List<Button> taskBtns; // All buttons associated with a task loaded @ runtime
        List<CheckBox> taskCbs; // All checkboxes associated with a task loaded @ runtime
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


        // ----- Timed functions -----
        void MainForm_Load(object sender, EventArgs e) // On Awake
        {
            FillTasksList();
        }
        // ----- End of Timed functions -----


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
            
            // Checkbox
            int cSize = 25; // Size of checkboxes

            // Offset
            int offset = 30; // Width & x of buttons to allow space for checkbox


            /* Disables & hides all task buttons & checkboxes if already created
             * This would apply when creating new tasks or deleting a task
            // This way duplicate tasks are not shown */
            if (taskBtns != null)
            {
                for (int i = 0; i < taskBtns.Count; i++)
                {
                    Controls.Remove(taskBtns[i]);
                    Controls.Remove(taskCbs[i]);
                    taskBtns[i].Enabled = false;
                    taskBtns[i].Visible = false;
                    taskCbs[i].Enabled = false;
                    taskCbs[i].Visible = false;
                }
                taskBtns.Clear();
                taskCbs.Clear();
            }
            else 
            { 
                taskBtns = new List<Button>();
                taskCbs = new List<CheckBox>();
            }

            FileIO.LoadTasks();

            foreach (var task in FileIO.tasks)
            {
                // Button
                Button b = new Button
                {
                    Name = "ButtonTask" + task.title,
                    Text = task.title.ToString(),

                    // Cosmetic
                    BackColor = TasksPanel.BackColor,
                    FlatStyle = ButtonCreate.FlatStyle,

                    // Transform
                    Size = new Size(width - offset, height),
                    Location = new Point(loc[0] + offset, loc[1])
                };

                b.Click += delegate
                {
                    ShowTaskInfo(task.index);
                };
                Controls.Add(b);
                taskBtns.Add(b);

                // Checkbox
                CheckBox c = new CheckBox
                {
                    Name = "CBTask" + task.title,
                    Size = new Size(cSize, cSize),
                    Location = new Point(loc[0], loc[1])
                };
                // Initial checked state based on completion in Task object
                c.Checked = task.isFinished;

                c.CheckedChanged += delegate
                {
                    task.isFinished = c.Checked;
                    task.timeFinished = DateTime.Now.ToShortDateString();
                    ShowTaskInfo(task.index);
                    FileIO.SaveTask(task);
                };
                Controls.Add(c);
                taskCbs.Add(c);

                // Increment location y by the height
                loc[1] += height;
            }
        }

        /// <summary>
        /// <para>Shows task information for the task @ index</para>
        /// <c>
        /// <para>Parameters</para>
        /// <para>index: Index of task to show the information of</para>
        /// </c>
        /// </summary>
        void ShowTaskInfo(int index)
        {
            currentTask = index;

            // --- Description ---
            OutputTextbox.Text =
                FileIO.tasks[index].description + "\n\n";

            // --- Due date ---
            // Show true due date if it is NOT -1
            // Otherwise show "No due date"
            if (FileIO.tasks[index].dueDate != "-1")
                OutputTextbox.Text += "Due date: " + FileIO.tasks[index].dueDate;
            else OutputTextbox.Text += "Due date: None";

            OutputTextbox.Text += "\n\n";

            // --- Completion state ---
            if (FileIO.tasks[index].isFinished)
                OutputTextbox.Text += "Task Finished on " + FileIO.tasks[index].timeFinished;
            else OutputTextbox.Text += "Task Incomplete";
        }
    }
}