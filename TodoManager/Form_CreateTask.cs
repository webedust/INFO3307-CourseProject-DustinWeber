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
            // To-do: Can't modify a task currently
            // Checks if "task" parameter is greater than "default" value of -1
            if (index > -1)
            {
                TB_Name.Text = FileIO.tasks[index].title;
                TB_Description.Text = FileIO.tasks[index].description;
                // To-do: Must also add due date, completion state here when added
            }
        }

        void ButtonCreateTask_Click(object sender, EventArgs e)
        {
            FileIO.SaveTask(TB_Name.Text, TB_Description.Text);
            main.FillTasksList();
            Close();
        }

        void ButtonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
