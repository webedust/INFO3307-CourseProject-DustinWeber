using System;
using System.DirectoryServices.ActiveDirectory;
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

        /// <summary>
        /// <para>Called whenever this Form is being shown</para>
        /// <c>
        /// <para>Parameters</para>
        /// <para>main: Main form where this form is being opened from.</para>
        /// <para>task: Index of task being modified. Set null if creating new task</para>
        /// </c>
        /// </summary>
        public void OnShow(MainForm main, int index) 
        { 
            this.main = main;
            // Checks if "task" parameter is greater than "default" value of -1
            if (index > -1)
            {
                modifying = true;
                modifyTaskIndex = index;

                TB_Name.Text = FileIO.tasks[index].title;
                TB_Description.Text = FileIO.tasks[index].description;
                // To-do: Must also add due date, completion state here when added
            }
            else modifying = false;
        }

        void ButtonCreateTask_Click(object sender, EventArgs e)
        {
            // Delete task then re-save if modifying
            if (modifying) FileIO.DeleteTask(modifyTaskIndex);
            // To-do: Change due date from -1 to an actual date when it is implemented
            Task newTask = new Task(TB_Name.Text, TB_Description.Text, -1);
            FileIO.SaveTask(newTask);
            main.FillTasksList();
            Close();
        }

        void ButtonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
