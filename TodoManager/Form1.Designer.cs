namespace TodoManager
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.ButtonCreate = new System.Windows.Forms.Button();
            this.OutputTextbox = new System.Windows.Forms.RichTextBox();
            this.ButtonLoad = new System.Windows.Forms.Button();
            this.ButtonUpdate = new System.Windows.Forms.Button();
            this.TasksPanel = new System.Windows.Forms.Panel();
            this.Label_TasksName = new System.Windows.Forms.Label();
            this.Label_Info = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ButtonCreate
            // 
            this.ButtonCreate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.ButtonCreate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonCreate.Font = new System.Drawing.Font("Liberation Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonCreate.ForeColor = System.Drawing.Color.White;
            this.ButtonCreate.Location = new System.Drawing.Point(13, 568);
            this.ButtonCreate.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.ButtonCreate.Name = "ButtonCreate";
            this.ButtonCreate.Size = new System.Drawing.Size(246, 49);
            this.ButtonCreate.TabIndex = 0;
            this.ButtonCreate.Text = "Create task";
            this.ButtonCreate.UseVisualStyleBackColor = false;
            this.ButtonCreate.Click += new System.EventHandler(this.ButtonCreate_Click);
            // 
            // OutputTextbox
            // 
            this.OutputTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.OutputTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.OutputTextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.OutputTextbox.ForeColor = System.Drawing.Color.White;
            this.OutputTextbox.Location = new System.Drawing.Point(468, 33);
            this.OutputTextbox.Margin = new System.Windows.Forms.Padding(10);
            this.OutputTextbox.Name = "OutputTextbox";
            this.OutputTextbox.ReadOnly = true;
            this.OutputTextbox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.OutputTextbox.Size = new System.Drawing.Size(775, 584);
            this.OutputTextbox.TabIndex = 2;
            this.OutputTextbox.Text = "Click on a task to the left to see its information.";
            // 
            // ButtonLoad
            // 
            this.ButtonLoad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.ButtonLoad.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonLoad.ForeColor = System.Drawing.Color.White;
            this.ButtonLoad.Location = new System.Drawing.Point(269, 568);
            this.ButtonLoad.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.ButtonLoad.Name = "ButtonLoad";
            this.ButtonLoad.Size = new System.Drawing.Size(188, 49);
            this.ButtonLoad.TabIndex = 0;
            this.ButtonLoad.Text = "Delete task";
            this.ButtonLoad.UseVisualStyleBackColor = false;
            this.ButtonLoad.Click += new System.EventHandler(this.ButtonDelete_Click);
            // 
            // ButtonUpdate
            // 
            this.ButtonUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.ButtonUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonUpdate.ForeColor = System.Drawing.Color.White;
            this.ButtonUpdate.Location = new System.Drawing.Point(1009, 568);
            this.ButtonUpdate.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.ButtonUpdate.Name = "ButtonUpdate";
            this.ButtonUpdate.Size = new System.Drawing.Size(234, 49);
            this.ButtonUpdate.TabIndex = 0;
            this.ButtonUpdate.Text = "Update task information";
            this.ButtonUpdate.UseVisualStyleBackColor = false;
            this.ButtonUpdate.Click += new System.EventHandler(this.ButtonUpdate_Click);
            // 
            // TasksPanel
            // 
            this.TasksPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.TasksPanel.Enabled = false;
            this.TasksPanel.Location = new System.Drawing.Point(13, 33);
            this.TasksPanel.Name = "TasksPanel";
            this.TasksPanel.Size = new System.Drawing.Size(444, 527);
            this.TasksPanel.TabIndex = 3;
            this.TasksPanel.Visible = false;
            // 
            // Label_TasksName
            // 
            this.Label_TasksName.AutoSize = true;
            this.Label_TasksName.Location = new System.Drawing.Point(13, 9);
            this.Label_TasksName.Name = "Label_TasksName";
            this.Label_TasksName.Size = new System.Drawing.Size(59, 21);
            this.Label_TasksName.TabIndex = 4;
            this.Label_TasksName.Text = "Tasks";
            // 
            // Label_Info
            // 
            this.Label_Info.AutoSize = true;
            this.Label_Info.Location = new System.Drawing.Point(468, 9);
            this.Label_Info.Name = "Label_Info";
            this.Label_Info.Size = new System.Drawing.Size(105, 21);
            this.Label_Info.TabIndex = 4;
            this.Label_Info.Text = "Information";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(1257, 630);
            this.Controls.Add(this.Label_Info);
            this.Controls.Add(this.Label_TasksName);
            this.Controls.Add(this.TasksPanel);
            this.Controls.Add(this.ButtonUpdate);
            this.Controls.Add(this.ButtonLoad);
            this.Controls.Add(this.OutputTextbox);
            this.Controls.Add(this.ButtonCreate);
            this.Font = new System.Drawing.Font("Liberation Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "MainForm";
            this.Text = "ToDoManager";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonCreate;
        private System.Windows.Forms.RichTextBox OutputTextbox;
        private System.Windows.Forms.Button ButtonLoad;
        private System.Windows.Forms.Button ButtonUpdate;
        private System.Windows.Forms.Panel TasksPanel;
        private System.Windows.Forms.Label Label_TasksName;
        private System.Windows.Forms.Label Label_Info;
    }
}

