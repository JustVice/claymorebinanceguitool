namespace ClaymoreUITool.UI
{
    partial class TestRoom
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
            this.button_json_create = new System.Windows.Forms.Button();
            this.button_read_file = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_json_create
            // 
            this.button_json_create.Location = new System.Drawing.Point(24, 29);
            this.button_json_create.Name = "button_json_create";
            this.button_json_create.Size = new System.Drawing.Size(128, 23);
            this.button_json_create.TabIndex = 0;
            this.button_json_create.Text = "JSON - Create file";
            this.button_json_create.UseVisualStyleBackColor = true;
            this.button_json_create.Click += new System.EventHandler(this.button_json_create_Click);
            // 
            // button_read_file
            // 
            this.button_read_file.Location = new System.Drawing.Point(24, 83);
            this.button_read_file.Name = "button_read_file";
            this.button_read_file.Size = new System.Drawing.Size(128, 23);
            this.button_read_file.TabIndex = 1;
            this.button_read_file.Text = "JSON - Read file";
            this.button_read_file.UseVisualStyleBackColor = true;
            this.button_read_file.Click += new System.EventHandler(this.button_read_file_Click);
            // 
            // TestRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 440);
            this.Controls.Add(this.button_read_file);
            this.Controls.Add(this.button_json_create);
            this.Name = "TestRoom";
            this.Text = "TestRoom";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_json_create;
        private System.Windows.Forms.Button button_read_file;
    }
}