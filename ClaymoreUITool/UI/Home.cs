
using ClaymoreUITool.Logic;
using System;
using System.Windows.Forms;

namespace ClaymoreUITool.UI
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            loadData();
        }

        private void loadData()
        {
            try
            {
                JSONHandler j = new JSONHandler();
                UserConfig userConfig = j.readUserConfig();
                textBox_mining_account_name.Text = userConfig.miningAccountName;
                textBox_worker_group_name.Text = userConfig.workerGroupName;
                textBox_gpu_usage.Text = userConfig.gpuUsage;
            }
            catch (Exception) { }
        }

        private void button_execute_Click(object sender, EventArgs e)
        {
            if (checkRequiredParameters())
            {
                UserConfig userConfig = new UserConfig()
                {
                    miningAccountName = textBox_mining_account_name.Text,
                    workerGroupName = textBox_worker_group_name.Text,
                    gpuUsage = textBox_gpu_usage.Text
                };
                JSONHandler j = new JSONHandler();
                j.saveUserConfig(userConfig);
                CMD.runClaymore(
                    textBox_mining_account_name.Text
                    , textBox_worker_group_name.Text
                    , textBox_gpu_usage.Text);
                Application.Exit();
            }
        }

        private bool checkRequiredParameters()
        {
            return !String.IsNullOrEmpty(textBox_mining_account_name.Text) &&
                !String.IsNullOrEmpty(textBox_worker_group_name.Text);
        }

        private void button_about_Click(object sender, EventArgs e)
        {
            var About = new About();
            About.Show();
        }
    }
}
