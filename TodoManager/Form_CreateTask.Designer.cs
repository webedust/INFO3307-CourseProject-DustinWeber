namespace TodoManager
{
    partial class Form_CreateTask
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_CreateTask));
            this.LabelName = new System.Windows.Forms.Label();
            this.LabelDescription = new System.Windows.Forms.Label();
            this.LabelDueDate = new System.Windows.Forms.Label();
            this.ButtonCreateTask = new System.Windows.Forms.Button();
            this.ButtonCancel = new System.Windows.Forms.Button();
            this.TB_Name = new System.Windows.Forms.RichTextBox();
            this.TB_Description = new System.Windows.Forms.RichTextBox();
            this.CalendarDueDate = new System.Windows.Forms.MonthCalendar();
            this.CB_DueDate = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // LabelName
            // 
            this.LabelName.AutoSize = true;
            this.LabelName.Font = new System.Drawing.Font("Liberation Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LabelName.ForeColor = System.Drawing.SystemColors.Control;
            this.LabelName.Location = new System.Drawing.Point(12, 9);
            this.LabelName.Name = "LabelName";
            this.LabelName.Size = new System.Drawing.Size(101, 21);
            this.LabelName.TabIndex = 0;
            this.LabelName.Text = "Task name";
            // 
            // LabelDescription
            // 
            this.LabelDescription.AutoSize = true;
            this.LabelDescription.Font = new System.Drawing.Font("Liberation Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LabelDescription.ForeColor = System.Drawing.SystemColors.Control;
            this.LabelDescription.Location = new System.Drawing.Point(12, 46);
            this.LabelDescription.Name = "LabelDescription";
            this.LabelDescription.Size = new System.Drawing.Size(106, 21);
            this.LabelDescription.TabIndex = 0;
            this.LabelDescription.Text = "Description";
            // 
            // LabelDueDate
            // 
            this.LabelDueDate.AutoSize = true;
            this.LabelDueDate.Font = new System.Drawing.Font("Liberation Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LabelDueDate.ForeColor = System.Drawing.SystemColors.Control;
            this.LabelDueDate.Location = new System.Drawing.Point(12, 152);
            this.LabelDueDate.Name = "LabelDueDate";
            this.LabelDueDate.Size = new System.Drawing.Size(87, 21);
            this.LabelDueDate.TabIndex = 0;
            this.LabelDueDate.Text = "Due date";
            // 
            // ButtonCreateTask
            // 
            this.ButtonCreateTask.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.ButtonCreateTask.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonCreateTask.Font = new System.Drawing.Font("Liberation Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonCreateTask.ForeColor = System.Drawing.Color.White;
            this.ButtonCreateTask.Location = new System.Drawing.Point(14, 388);
            this.ButtonCreateTask.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.ButtonCreateTask.Name = "ButtonCreateTask";
            this.ButtonCreateTask.Size = new System.Drawing.Size(246, 49);
            this.ButtonCreateTask.TabIndex = 0;
            this.ButtonCreateTask.Text = "Create task";
            this.ButtonCreateTask.UseVisualStyleBackColor = false;
            this.ButtonCreateTask.Click += new System.EventHandler(this.ButtonCreateTask_Click);
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.ButtonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonCancel.Font = new System.Drawing.Font("Liberation Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonCancel.ForeColor = System.Drawing.Color.White;
            this.ButtonCancel.Location = new System.Drawing.Point(540, 388);
            this.ButtonCancel.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.Size = new System.Drawing.Size(246, 49);
            this.ButtonCancel.TabIndex = 0;
            this.ButtonCancel.Text = "Cancel";
            this.ButtonCancel.UseVisualStyleBackColor = false;
            this.ButtonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // TB_Name
            // 
            this.TB_Name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.TB_Name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TB_Name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TB_Name.Font = new System.Drawing.Font("Liberation Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TB_Name.ForeColor = System.Drawing.Color.White;
            this.TB_Name.Location = new System.Drawing.Point(150, 9);
            this.TB_Name.Margin = new System.Windows.Forms.Padding(10);
            this.TB_Name.MaxLength = 50;
            this.TB_Name.Name = "TB_Name";
            this.TB_Name.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.TB_Name.Size = new System.Drawing.Size(636, 31);
            this.TB_Name.TabIndex = 2;
            this.TB_Name.Text = "";
            // 
            // TB_Description
            // 
            this.TB_Description.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.TB_Description.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TB_Description.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TB_Description.Font = new System.Drawing.Font("Liberation Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TB_Description.ForeColor = System.Drawing.Color.White;
            this.TB_Description.Location = new System.Drawing.Point(150, 51);
            this.TB_Description.Margin = new System.Windows.Forms.Padding(10);
            this.TB_Description.MaxLength = 300;
            this.TB_Description.Name = "TB_Description";
            this.TB_Description.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.TB_Description.Size = new System.Drawing.Size(636, 82);
            this.TB_Description.TabIndex = 2;
            this.TB_Description.Text = "";
            // 
            // CalendarDueDate
            // 
            this.CalendarDueDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.CalendarDueDate.Font = new System.Drawing.Font("Liberation Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CalendarDueDate.ForeColor = System.Drawing.SystemColors.Control;
            this.CalendarDueDate.Location = new System.Drawing.Point(150, 189);
            this.CalendarDueDate.MaxSelectionCount = 1;
            this.CalendarDueDate.MinDate = new System.DateTime(2000, 12, 25, 23, 59, 59, 0);
            this.CalendarDueDate.Name = "CalendarDueDate";
            this.CalendarDueDate.TabIndex = 3;
            // 
            // CB_DueDate
            // 
            this.CB_DueDate.AutoSize = true;
            this.CB_DueDate.Font = new System.Drawing.Font("Liberation Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CB_DueDate.ForeColor = System.Drawing.SystemColors.Control;
            this.CB_DueDate.Location = new System.Drawing.Point(150, 152);
            this.CB_DueDate.Name = "CB_DueDate";
            this.CB_DueDate.Size = new System.Drawing.Size(132, 25);
            this.CB_DueDate.TabIndex = 0;
            this.CB_DueDate.Text = "No due date";
            this.CB_DueDate.UseVisualStyleBackColor = true;
            // 
            // Form_CreateTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.CancelButton = this.ButtonCancel;
            this.ClientSize = new System.Drawing.Size(800, 449);
            this.Controls.Add(this.CB_DueDate);
            this.Controls.Add(this.CalendarDueDate);
            this.Controls.Add(this.TB_Description);
            this.Controls.Add(this.TB_Name);
            this.Controls.Add(this.ButtonCancel);
            this.Controls.Add(this.ButtonCreateTask);
            this.Controls.Add(this.LabelDueDate);
            this.Controls.Add(this.LabelDescription);
            this.Controls.Add(this.LabelName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_CreateTask";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create Task";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelName;
        private System.Windows.Forms.Label LabelDescription;
        private System.Windows.Forms.Label LabelDueDate;
        private System.Windows.Forms.Button ButtonCreateTask;
        private System.Windows.Forms.Button ButtonCancel;
        private System.Windows.Forms.RichTextBox TB_Name;
        private System.Windows.Forms.RichTextBox TB_Description;
        private System.Windows.Forms.MonthCalendar CalendarDueDate;
        private System.Windows.Forms.CheckBox CB_DueDate;
    }
}