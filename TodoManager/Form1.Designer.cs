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
            this.ButtonSave = new System.Windows.Forms.Button();
            this.Textbox = new System.Windows.Forms.RichTextBox();
            this.OutputTextbox = new System.Windows.Forms.RichTextBox();
            this.ButtonLoad = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ButtonSave
            // 
            this.ButtonSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.ButtonSave.ForeColor = System.Drawing.Color.White;
            this.ButtonSave.Location = new System.Drawing.Point(572, 193);
            this.ButtonSave.Name = "ButtonSave";
            this.ButtonSave.Size = new System.Drawing.Size(70, 35);
            this.ButtonSave.TabIndex = 0;
            this.ButtonSave.Text = "Save task";
            this.ButtonSave.UseVisualStyleBackColor = false;
            this.ButtonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // Textbox
            // 
            this.Textbox.BackColor = System.Drawing.Color.DimGray;
            this.Textbox.ForeColor = System.Drawing.Color.White;
            this.Textbox.Location = new System.Drawing.Point(12, 12);
            this.Textbox.Name = "Textbox";
            this.Textbox.Size = new System.Drawing.Size(280, 72);
            this.Textbox.TabIndex = 1;
            this.Textbox.Text = "";
            // 
            // OutputTextbox
            // 
            this.OutputTextbox.BackColor = System.Drawing.Color.DimGray;
            this.OutputTextbox.ForeColor = System.Drawing.Color.White;
            this.OutputTextbox.Location = new System.Drawing.Point(12, 108);
            this.OutputTextbox.Name = "OutputTextbox";
            this.OutputTextbox.Size = new System.Drawing.Size(280, 310);
            this.OutputTextbox.TabIndex = 2;
            this.OutputTextbox.Text = "";
            // 
            // ButtonLoad
            // 
            this.ButtonLoad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.ButtonLoad.ForeColor = System.Drawing.Color.White;
            this.ButtonLoad.Location = new System.Drawing.Point(667, 193);
            this.ButtonLoad.Name = "ButtonLoad";
            this.ButtonLoad.Size = new System.Drawing.Size(70, 35);
            this.ButtonLoad.TabIndex = 0;
            this.ButtonLoad.Text = "Load task";
            this.ButtonLoad.UseVisualStyleBackColor = false;
            this.ButtonLoad.Click += new System.EventHandler(this.ButtonLoad_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ButtonLoad);
            this.Controls.Add(this.OutputTextbox);
            this.Controls.Add(this.Textbox);
            this.Controls.Add(this.ButtonSave);
            this.Name = "MainForm";
            this.Text = "ToDoManager";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ButtonSave;
        private System.Windows.Forms.RichTextBox Textbox;
        private System.Windows.Forms.RichTextBox OutputTextbox;
        private System.Windows.Forms.Button ButtonLoad;
    }
}

