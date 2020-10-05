using System;
using System.IO;
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

        void ButtonSave_Click(object sender, EventArgs e)
        {
            fileIO.SaveFile(Textbox.Text);
        }

        void ButtonLoad_Click(object sender, EventArgs e)
        {
            fileIO.LoadFile(OutputTextbox);
        }
    }
}
