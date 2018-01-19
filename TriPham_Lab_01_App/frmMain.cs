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

        private City CityLondon, CityParis, CityPrague, CityStPetersburgs;

        #endregion

        #region Constructor

        /// <summary>
        /// Form constructor
        /// </summary>
        public frmMain()
        {
            InitCityInformation();
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.None;
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.ResizeRedraw, true);

            InitCityInformation();
        }

        #endregion

        #region Methods

        private void InitCityInformation()
        {
            // Init city name and position (top, left, right, bottom)
            CityLondon = new City(Common.CityName.London, 95, 525, 570, 115);
            CityParis = new City(Common.CityName.Paris, 63, 640, 685, 90);
            CityPrague = new City(Common.CityName.Prague, 56, 740, 800, 80);
            CityStPetersburgs = new City(Common.CityName.St_Petersbug, 180, 736, 780, 205);
        }

        /// <summary>
        /// Set Relative Location
        /// </summary>
        private void CityLocation()
        {
            lblLondon.SetRelativeLocation(this.Width, this.Height, CityLondon.Top, CityLondon.Left, CityLondon.Right, CityLondon.Bottom);
            lblParis.SetRelativeLocation(this.Width, this.Height, CityParis.Top, CityParis.Left, CityParis.Right, CityParis.Bottom);
            lblStPetersburg.SetRelativeLocation(this.Width, this.Height, CityStPetersburgs.Top, CityStPetersburgs.Left, CityStPetersburgs.Right, CityStPetersburgs.Bottom);
            lblPrague.SetRelativeLocation(this.Width, this.Height, CityPrague.Top, CityPrague.Left, CityPrague.Right, CityPrague.Bottom);
        }

        #endregion

        #region Events

        #region Form Events

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
            {
                txtCityInfo.Visible = false;
                // Trap WM_NCHITTEST
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
        /// Locate the position of cities in the image
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmMain_Load(object sender, EventArgs e)
        {
            InitCityInformation();
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

        #endregion

        #region Label Events
        /// <summary>
        /// lblLondon_Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lblLondon_Click(object sender, EventArgs e)
        {
            txtCityInfo.DisplayContent(CityLondon.Info, lblLondon);
        }

        /// <summary>
        /// lblParis_Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lblParis_Click(object sender, EventArgs e)
        {
            txtCityInfo.DisplayContent(CityParis.Info, lblParis);
        }

        /// <summary>
        /// lblStPetersburg_Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lblStPetersburg_Click(object sender, EventArgs e)
        {
            txtCityInfo.DisplayContent(CityStPetersburgs.Info, lblStPetersburg);
        }

        /// <summary>
        /// lblPrague_Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lblPrague_Click(object sender, EventArgs e)
        {
            txtCityInfo.DisplayContent(CityPrague.Info, lblPrague);
        }

        #endregion
        
        #endregion
    }
}
