namespace ClaymoreUITool.UI
{
    partial class Home
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
            this.textBox_mining_account_name = new System.Windows.Forms.TextBox();
            this.label_title = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_worker_group_name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_gpu_usage = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button_execute = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.button_about = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_mining_account_name
            // 
            this.textBox_mining_account_name.Location = new System.Drawing.Point(41, 91);
            this.textBox_mining_account_name.Name = "textBox_mining_account_name";
            this.textBox_mining_account_name.Size = new System.Drawing.Size(507, 20);
            this.textBox_mining_account_name.TabIndex = 0;
            // 
            // label_title
            // 
            this.label_title.AutoSize = true;
            this.label_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.25F);
            this.label_title.Location = new System.Drawing.Point(31, 13);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(517, 38);
            this.label_title.TabIndex = 1;
            this.label_title.Text = "Claymore - Binance Pool GUI Tool";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mining account name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Worker group name";
            // 
            // textBox_worker_group_name
            // 
            this.textBox_worker_group_name.Location = new System.Drawing.Point(41, 161);
            this.textBox_worker_group_name.Name = "textBox_worker_group_name";
            this.textBox_worker_group_name.Size = new System.Drawing.Size(507, 20);
            this.textBox_worker_group_name.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(511, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "_________________________________________________________________________________" +
    "___";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 239);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "GPU usage expressed in %";
            // 
            // textBox_gpu_usage
            // 
            this.textBox_gpu_usage.Location = new System.Drawing.Point(38, 308);
            this.textBox_gpu_usage.Name = "textBox_gpu_usage";
            this.textBox_gpu_usage.Size = new System.Drawing.Size(478, 20);
            this.textBox_gpu_usage.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 267);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(165, 26);
            this.label5.TabIndex = 8;
            this.label5.Text = "Example: 80 to use 80% of GPU\r\nLeave blank to use 100% of GPU";
            // 
            // button_execute
            // 
            this.button_execute.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.button_execute.Location = new System.Drawing.Point(42, 353);
            this.button_execute.Name = "button_execute";
            this.button_execute.Size = new System.Drawing.Size(197, 31);
            this.button_execute.TabIndex = 9;
            this.button_execute.Text = "Execute Claymore";
            this.button_execute.UseVisualStyleBackColor = true;
            this.button_execute.Click += new System.EventHandler(this.button_execute_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(522, 311);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(15, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "%";
            // 
            // button_about
            // 
            this.button_about.Location = new System.Drawing.Point(476, 360);
            this.button_about.Name = "button_about";
            this.button_about.Size = new System.Drawing.Size(75, 23);
            this.button_about.TabIndex = 11;
            this.button_about.Text = "About";
            this.button_about.UseVisualStyleBackColor = true;
            this.button_about.Click += new System.EventHandler(this.button_about_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 403);
            this.Controls.Add(this.button_about);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button_execute);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_gpu_usage);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_worker_group_name);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_title);
            this.Controls.Add(this.textBox_mining_account_name);
            this.Name = "Home";
            this.Text = "Home";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_mining_account_name;
        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_worker_group_name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_gpu_usage;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button_execute;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button_about;
    }
}