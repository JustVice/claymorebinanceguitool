using System;
using System.Windows.Forms;

namespace ClaymoreUITool.UI
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }

        private void button_source_code_Click(object sender, EventArgs e)
        {
            OPEN_BROWSER_WITH_URL("https://github.com/justvice/claymorebinanceguitool");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OPEN_BROWSER_WITH_URL("http://just-vice.com");
        }

        public static void OPEN_BROWSER_WITH_URL(string url)
        {
            try
            {
                System.Diagnostics.Process.Start(url);
            }
            catch (Exception ex)
            {
                Console.WriteLine("OPEN BROWSER WITH URL ERROR\r\n" + ex);
            }
        }
    }
}
