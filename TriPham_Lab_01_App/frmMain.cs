using System;
using System.Drawing;
using System.Windows.Forms;

namespace TriPham_Lab_01_App
{
    public partial class frmMain : Form
    {
        #region Properties

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private const int cGrip = 16;      // Grip size
        private const int cCaption = 32;   // Caption bar height;

        #endregion

        #region Constructor

        /// <summary>
        /// Form constructor
        /// </summary>
        public frmMain()
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.None;
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.ResizeRedraw, true);
        }

        #endregion

        #region Events
        
        /// <summary>
        /// Able to resize form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmMain_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);

            }
        }

        /// <summary>
        /// Close form when user presses Escape key
        /// </summary>
        /// <param name="keyData"></param>
        /// <returns></returns>
        protected override bool ProcessDialogKey(Keys keyData)
        {
            if (Form.ModifierKeys == Keys.None && keyData == Keys.Escape)
            {
                this.Close();
                return true;
            }
            return base.ProcessDialogKey(keyData);
        }
        
        /// <summary>
        /// Override resize form
        /// </summary>
        /// <param name="m"></param>
        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x84)
            {  // Trap WM_NCHITTEST
                Point pos = new Point(m.LParam.ToInt32());
                pos = this.PointToClient(pos);
                if (pos.Y < cCaption)
                {
                    m.Result = (IntPtr)2;  // HTCAPTION
                    return;
                }
                if (pos.X >= this.ClientSize.Width - cGrip && pos.Y >= this.ClientSize.Height - cGrip)
                {
                    m.Result = (IntPtr)17; // HTBOTTOMRIGHT
                    return;
                }
            }
            base.WndProc(ref m);
        }

        /// <summary>
        /// Display Paris' info when hovering mouse
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lblParis_MouseHover(object sender, EventArgs e)
        {
            lblParis.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            City cityParis = new City(Common.CityName.Paris);
            txtCityInfo.DisplayContent(cityParis.info, lblParis);
        }

        /// <summary>
        /// Disappear Paris' info when leaving mouse out of Paris
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lblParis_MouseLeave(object sender, EventArgs e)
        {
            lblParis.BorderStyle = System.Windows.Forms.BorderStyle.None;
            txtCityInfo.Visible = false;
        }

        /// <summary>
        /// Display London' info when hovering mouse
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lblLondon_MouseHover(object sender, EventArgs e)
        {
            lblLondon.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            City cityLondon = new City(Common.CityName.London);
            txtCityInfo.DisplayContent(cityLondon.info, lblLondon);
        }

        /// <summary>
        /// Disappear London' info when leaving mouse
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lblLondon_MouseLeave(object sender, EventArgs e)
        {
            lblLondon.BorderStyle = System.Windows.Forms.BorderStyle.None;
            txtCityInfo.Visible = false;
        }

        /// <summary>
        /// Display StPetersburg' info when hovering mouse
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lblStPetersburg_MouseHover(object sender, EventArgs e)
        {
            lblStPetersburg.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            City cityStPetersburg = new City(Common.CityName.St_Petersbug);
            txtCityInfo.DisplayContent(cityStPetersburg.info, lblStPetersburg);
        }

        /// <summary>
        /// Disappear StPetersburg' info when leaving mouse
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lblStPetersburg_MouseLeave(object sender, EventArgs e)
        {
            lblStPetersburg.BorderStyle = System.Windows.Forms.BorderStyle.None;
            txtCityInfo.Visible = false;
        }

        /// <summary>
        /// Display Prague' info when hovering mouse
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lblPrague_MouseHover(object sender, EventArgs e)
        {
            lblPrague.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            City cityPrague = new City(Common.CityName.Prague);
            txtCityInfo.DisplayContent(cityPrague.info, lblPrague);
        }

        /// <summary>
        /// Disappear Prague' info when leaving mouse
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lblPrague_MouseLeave(object sender, EventArgs e)
        {
            lblPrague.BorderStyle = System.Windows.Forms.BorderStyle.None;
            txtCityInfo.Visible = false;
        }

        /// <summary>
        /// Set Relative Location
        /// </summary>
        private void CityLocation()
        {
            lblLondon.SetRelativeLocation(this.Width, this.Height, 95, 525, 570, 115);
            lblParis.SetRelativeLocation(this.Width, this.Height, 63, 640, 685, 90);
            lblStPetersburg.SetRelativeLocation(this.Width, this.Height, 56, 740, 800, 80);
            lblPrague.SetRelativeLocation(this.Width, this.Height, 180, 736, 780, 205);
        }

        /// <summary>
        /// Locate the position of cities in the image
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmMain_Load(object sender, EventArgs e)
        {
            CityLocation();
        }

        /// <summary>
        /// Move city labels along when resizing the form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmMain_Resize(object sender, EventArgs e)
        {
            CityLocation();
        }


        private void txtCityInfo_ContentsResized(object sender, ContentsResizedEventArgs e)
        {
            //var richTextBox = (RichTextBox)sender;
            //richTextBox.Width = e.NewRectangle.Width;
            //richTextBox.Height = e.NewRectangle.Height;
        }
        #endregion

    }
}
