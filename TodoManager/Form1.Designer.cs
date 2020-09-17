namespace TodoManager
{
    partial class Form1
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
            this.ButtonSave.Location = new System.Drawing.Point(582, 193);
            this.ButtonSave.Name = "ButtonSave";
            this.ButtonSave.Size = new System.Drawing.Size(60, 35);
            this.ButtonSave.TabIndex = 0;
            this.ButtonSave.Text = "Save file";
            this.ButtonSave.UseVisualStyleBackColor = true;
            this.ButtonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // Textbox
            // 
            this.Textbox.Location = new System.Drawing.Point(296, 77);
            this.Textbox.Name = "Textbox";
            this.Textbox.Size = new System.Drawing.Size(174, 72);
            this.Textbox.TabIndex = 1;
            this.Textbox.Text = "";
            // 
            // OutputTextbox
            // 
            this.OutputTextbox.Location = new System.Drawing.Point(582, 253);
            this.OutputTextbox.Name = "OutputTextbox";
            this.OutputTextbox.Size = new System.Drawing.Size(201, 178);
            this.OutputTextbox.TabIndex = 2;
            this.OutputTextbox.Text = "";
            // 
            // ButtonLoad
            // 
            this.ButtonLoad.Location = new System.Drawing.Point(667, 193);
            this.ButtonLoad.Name = "ButtonLoad";
            this.ButtonLoad.Size = new System.Drawing.Size(60, 35);
            this.ButtonLoad.TabIndex = 0;
            this.ButtonLoad.Text = "Load file";
            this.ButtonLoad.UseVisualStyleBackColor = true;
            this.ButtonLoad.Click += new System.EventHandler(this.ButtonLoad_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ButtonLoad);
            this.Controls.Add(this.OutputTextbox);
            this.Controls.Add(this.Textbox);
            this.Controls.Add(this.ButtonSave);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ButtonSave;
        private System.Windows.Forms.RichTextBox Textbox;
        private System.Windows.Forms.RichTextBox OutputTextbox;
        private System.Windows.Forms.Button ButtonLoad;
    }
}

