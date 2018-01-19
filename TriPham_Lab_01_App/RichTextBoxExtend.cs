using System;
using System.Drawing;
using System.Windows.Forms;

namespace TriPham_Lab_01_App
{
    public static class RichTextBoxExtend
    {
        public static void DisplayContent(this RichTextBox self, string cityInfo, Label label)
        {
            //using (Graphics g = CreateGraphics())
            //{
            //    owned.Height = (int)g.MeasureString(owned.Text, owned.Font, owned.Width).Height + 10;
            //}

            self.Clear();
            self.AppendText(cityInfo);
            self.Top = label.Bottom + 5;
            self.Left = label.Left + label.Width - self.Width;
            self.Visible = true;

            //Graphics g = CreateGraphics();

            //using (Graphics g = CreateGraphics())
            //{
            //    self.Height = (int)g.MeasureString(self.Text, self.Font, self.Width).Height + 20;
            //}
        }

        // Make the RichTextBox fit its contents.
        public static void rchContents_ContentsResized(this RichTextBox self, object sender, ContentsResizedEventArgs e)
        {
            const int margin = 5;
            RichTextBox rch = sender as RichTextBox;
            rch.ClientSize = new Size(
            e.NewRectangle.Width + margin,
            e.NewRectangle.Height + margin);
        }
    }
}
