using System;
using System.Windows.Forms;

namespace TodoManager
{
    public partial class MainForm : Form
    {
        FileIO fileIO = new FileIO();
        public MainForm()
        {
            InitializeComponent();
        }

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
            fileIO.LoadFile(OutputTextbox);
        }

        /// <summary>
        ///  Opens <c>Form_CreateTask</c>
        /// </summary>
        void OpenCreateTask()
        {
            Form_CreateTask form_createTask = new Form_CreateTask();
            form_createTask.Show();
        }
    }
}
