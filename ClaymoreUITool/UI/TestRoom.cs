using ClaymoreUITool.Logic;
using System;
using System.Windows.Forms;

namespace ClaymoreUITool.UI
{
    public partial class TestRoom : Form
    {
        public TestRoom()
        {
            InitializeComponent();
        }

        private void button_json_create_Click(object sender, EventArgs e)
        {
            UserConfig userConfig = new UserConfig()
            {
                miningAccountName = "test1",
                workerGroupName = "test2",
                gpuUsage = "test3",
            };
            JSONHandler j = new JSONHandler();
            j.saveUserConfig(userConfig);
        }

        private void button_read_file_Click(object sender, EventArgs e)
        {
            JSONHandler j = new JSONHandler();
            j.readUserConfig();
        }
    }
}
