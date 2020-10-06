using System;
using System.Windows.Forms;

namespace TodoManager
{
    public partial class Form_CreateTask : Form
    {
        public Form_CreateTask()
        {
            InitializeComponent();
        }
        // Variables
        FileIO io = new FileIO();
        MainForm main;

        /// <summary>
        /// <para>Called whenever this Form is being shown</para>
        /// <c>
        /// <para>Parameters</para>
        /// <para>main = Main form where this form is being opened from.</para>
        /// </c>
        /// </summary>
        public void OnShow(MainForm main) => this.main = main;

        void ButtonCreateTask_Click(object sender, EventArgs e)
        {
            io.SaveFile(TextboxName.Text, TextboxDescription.Text);
            main.FillTasksList();
            Close();
        }

        void ButtonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
