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
            this.ButtonCreate = new System.Windows.Forms.Button();
            this.Textbox = new System.Windows.Forms.RichTextBox();
            this.OutputTextbox = new System.Windows.Forms.RichTextBox();
            this.ButtonLoad = new System.Windows.Forms.Button();
            this.ButtonUpdate = new System.Windows.Forms.Button();
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
            // Textbox
            // 
            this.Textbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.Textbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Textbox.ForeColor = System.Drawing.Color.White;
            this.Textbox.Location = new System.Drawing.Point(13, 13);
            this.Textbox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Textbox.Name = "Textbox";
            this.Textbox.ReadOnly = true;
            this.Textbox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.Textbox.Size = new System.Drawing.Size(444, 547);
            this.Textbox.TabIndex = 1;
            this.Textbox.Text = "";
            // 
            // OutputTextbox
            // 
            this.OutputTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.OutputTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.OutputTextbox.ForeColor = System.Drawing.Color.White;
            this.OutputTextbox.Location = new System.Drawing.Point(468, 13);
            this.OutputTextbox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.OutputTextbox.Name = "OutputTextbox";
            this.OutputTextbox.ReadOnly = true;
            this.OutputTextbox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.OutputTextbox.Size = new System.Drawing.Size(775, 604);
            this.OutputTextbox.TabIndex = 2;
            this.OutputTextbox.Text = "";
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(1257, 630);
            this.Controls.Add(this.ButtonUpdate);
            this.Controls.Add(this.ButtonLoad);
            this.Controls.Add(this.OutputTextbox);
            this.Controls.Add(this.Textbox);
            this.Controls.Add(this.ButtonCreate);
            this.Font = new System.Drawing.Font("Liberation Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "MainForm";
            this.Text = "ToDoManager";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ButtonCreate;
        private System.Windows.Forms.RichTextBox Textbox;
        private System.Windows.Forms.RichTextBox OutputTextbox;
        private System.Windows.Forms.Button ButtonLoad;
        private System.Windows.Forms.Button ButtonUpdate;
    }
}

