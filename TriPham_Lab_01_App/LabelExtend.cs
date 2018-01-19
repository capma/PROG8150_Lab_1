using System;
using System.Windows.Forms;

namespace TriPham_Lab_01_App
{
    public static class LabelExtend
    {
        public static void SetRelativeLocation(this Label owned, int formWidth, int formHeight, int top, int left, int right, int bottom)
        {
            double lableTop, lableLeft, lableRight, lableBottom;

            lableTop = Math.Round(formHeight * (top / 567.0), MidpointRounding.AwayFromZero);
            lableLeft = Math.Round(formWidth * (left / 930.0), MidpointRounding.AwayFromZero);
            lableRight = Math.Round(formWidth * (right / 930.0), MidpointRounding.AwayFromZero);
            lableBottom = Math.Round(formHeight * (bottom / 567.0), MidpointRounding.AwayFromZero);

            owned.Top = Convert.ToInt32(lableTop);
            owned.Left = Convert.ToInt32(lableLeft);
            owned.Width = Convert.ToInt32(lableRight) - Convert.ToInt32(lableLeft);
            owned.Height = Convert.ToInt32(lableBottom) - Convert.ToInt32(lableTop);
        }
    }
}
