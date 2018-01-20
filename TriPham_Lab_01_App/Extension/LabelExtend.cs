using System;
using System.Windows.Forms;

namespace TriPham_Lab_01_App
{
    public static class LabelExtend
    {
        /// <summary>
        /// Set relative location for each city position in the background
        /// </summary>
        /// <param name="self"></param>
        /// <param name="formWidth"></param>
        /// <param name="formHeight"></param>
        /// <param name="top"></param>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <param name="bottom"></param>
        public static void SetRelativeLocation(this Label self, int formWidth, int formHeight, int top, int left, int right, int bottom)
        {
            double lableTop, lableLeft, lableRight, lableBottom;

            lableTop = Math.Round(formHeight * (top / 567.0), MidpointRounding.AwayFromZero);
            lableLeft = Math.Round(formWidth * (left / 930.0), MidpointRounding.AwayFromZero);
            lableRight = Math.Round(formWidth * (right / 930.0), MidpointRounding.AwayFromZero);
            lableBottom = Math.Round(formHeight * (bottom / 567.0), MidpointRounding.AwayFromZero);

            self.Top = Convert.ToInt32(lableTop);
            self.Left = Convert.ToInt32(lableLeft);
            self.Width = Convert.ToInt32(lableRight) - Convert.ToInt32(lableLeft);
            self.Height = Convert.ToInt32(lableBottom) - Convert.ToInt32(lableTop);
        }

    }
}
