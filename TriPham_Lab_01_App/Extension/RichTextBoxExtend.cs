using System.Windows.Forms;

namespace TriPham_Lab_01_App
{
    public static class RichTextBoxExtend
    {
        /// <summary>
        /// DisplayContent
        /// </summary>
        /// <param name="self"></param>
        /// <param name="cityInfo"></param>
        /// <param name="label"></param>
        public static void DisplayContent(this RichTextBox self, string cityInfo, Label label)
        {
            self.Clear();
            self.AppendText(cityInfo);
            self.Top = label.Bottom;
            self.Left = label.Left + label.Width - self.Width;
            self.Visible = true;
        }

    }
}
