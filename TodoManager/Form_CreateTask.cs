using System;
using System.Windows.Forms;

namespace TodoManager
{
    // Created by Dustin Weber
    /// <summary>
    /// Create Task form opened when the user clicks "Create Task" on the main form (Form 1)
    /// Handles button presses and Task file creation/modification.
    /// </summary>
    public partial class Form_CreateTask : Form
    {
        // Variables
        bool modifying; // True when modifying an existing task
        int modifyTaskIndex; // Index of task being modified
        MainForm main;
        

        public Form_CreateTask()
        {
            InitializeComponent();
        }

        /// <summary> Called whenever this Form is being shown </summary>
        /// <param name="main">Main form where this form is being opened from.</param>
        /// <param name="index">Index of task being modified. Set null if creating new task</param>
        public void OnShow(MainForm main, int index) 
        { 
            this.main = main;

            // Add event listener to Due Date checkbox
            CB_DueDate.CheckedChanged += delegate
            {
                // Hide due date calendar when checked since checkbox is for "No due date"
                if (CB_DueDate.Checked)
                {
                    CalendarDueDate.Visible = false;
                    CalendarDueDate.Enabled = false;
                }
                else
                {
                    CalendarDueDate.Enabled = true;
                    CalendarDueDate.Visible = true;
                }
            };

            // Checks if "task" parameter is greater than "default" value of -1
            // Assume a task is being modified if so
            if (index > -1)
            {
                modifying = true;
                modifyTaskIndex = index;

                ButtonCreateTask.Text = "Modify Task";

                TB_Name.Text = FileIO.tasks[index].title;
                TB_Description.Text = FileIO.tasks[index].description;
                // Set due date ONLY if it exists on the task being modified
                if (FileIO.tasks[index].dueDate != "-1")
                    CalendarDueDate.SetDate(DateTime.Parse(FileIO.tasks[index].dueDate));
                // Else check the "No due date" (CB_DueDate) checkbox
                else CB_DueDate.Checked = true;
                // To-do: Must also completion state here when added
            }
            else modifying = false;
        }

        void ButtonCreateTask_Click(object sender, EventArgs e)
        {
            // Delete task then re-save if modifying
            if (modifying) FileIO.DeleteTask(modifyTaskIndex);
            string date;
            // Due date is specified
            if (!CB_DueDate.Checked)
                date = CalendarDueDate.SelectionRange.Start.ToShortDateString();
            // No due date specified
            else date = "-1";
            Task newTask = new Task(TB_Name.Text, TB_Description.Text, date);
            
            if (FileIO.SaveTask(newTask)) // File saved successfully
            {
                main.FillTasksList();
                Close();
            }
            else // Illegal chars in task (file) name, alert user and do not save
            {
                MessageBox.Show("Task name can't contain any of the following characters:\n" +
                    "\\ / : ? \" < > | and can't be empty",
                    "Invalid Task Name");
            }
        }

        void ButtonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
