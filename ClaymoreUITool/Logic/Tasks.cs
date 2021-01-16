using System.Windows.Forms;

namespace ClaymoreUITool.Logic
{
    public class Tasks
    {
        public static void MESSAGEBOX(string message_content,
            string title,
            MessageBoxButtons mbButtons,
            MessageBoxIcon mbIcon)
        {
            MessageBox.Show(message_content, title, mbButtons, mbIcon);
        }
    }
}
