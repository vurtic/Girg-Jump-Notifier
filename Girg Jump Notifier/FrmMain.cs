using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Girg_Jump_Notifier
{
    public partial class FrmMain : Form
    {

        private Connection _Connection;
        private Timer _shieldTimer;
        private Timer _nextTimer;
        private int _nextCounter;
        private bool _isTimerActive;
        private int _shieldCounter;
        private Rectangle _rect;
        private const int _padding = 6;
        private SolidBrush _nextColor;
        private SoundPlayer _beep;

        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            _Connection = new Connection(this.Handle);
            btnConnect.Select();
            picTimer.Paint += new PaintEventHandler(picTimerPaint);
            picTimer.Resize += new EventHandler(picTimerResize);
            picTimer.Visible = false;
            _nextTimer = new Timer();
            _nextTimer.Tick += new EventHandler(RedrawPie);
            _nextTimer.Interval = 100;
            _rect = calcRect();
            _nextColor = new SolidBrush(Color.Crimson);
            var assembly = System.Reflection.Assembly.GetExecutingAssembly();
            _beep = new SoundPlayer(assembly.GetManifestResourceStream("Girg_Jump_Notifier.beep.wav"));
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            _Connection.Connect();
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            _Connection.Disconnect();
        }

        private void chkTop_CheckedChanged(object sender, EventArgs e)
        {
            if(chkTop.Checked)
            {
                this.TopMost = true;
            }
            else
            {
                this.TopMost = false;
            }
        }

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == WinApi.WM_COPYDATA)
            {
                var cds = (WinApi.COPYDATASTRUCT)Marshal.PtrToStructure(m.LParam, typeof(WinApi.COPYDATASTRUCT));

                if (cds.cbData < 12)
                    return;

                var data = new byte[cds.cbData];
                Marshal.Copy(cds.lpData, data, 0, cds.cbData);

                var packet = new Packet(data, 0);

                HandlePacket(packet);

                return;
            }
            base.WndProc(ref m);
        }

        private void HandlePacket(Packet p)
        {
            if (p.Op == 0x6D62)     // UseMotion
            {
                var category = p.GetInt();
                var type = p.GetInt();
                var loop = p.GetByte();
                var zero = p.GetShort();
                if (category == 162 && type == 8)
                {
                    Jump();
                }
                else if (category == 161 && type == 0)
                {
                    Shield();
                }
            }
            /*
             * if needed, get girg entity id from EntityAppears
             * girg race: solo = 3073
             *            easy = 3004
             *            normal = 3005
             *            hard = 3006
             *            very hard = 3069
             * 
            else if (p.Op == 0x520C)     // EntityAppears
            {
                var entityId = p.GetLong();
                p.GetByte();
                p.GetString();
                p.GetString();
                p.GetString();
                var race = p.GetInt();
            }
            */
        }

        private void Jump()
        {
            lblJump.Text = "Mineral Hail";
            lblJump.BackColor = Color.YellowGreen;
            var jumpTimer = new Timer();
            jumpTimer.Interval = 10000;
            jumpTimer.Tick += new EventHandler(ResetJump);
            jumpTimer.Start();
            _nextCounter = 0;
            _nextTimer.Start();
            picTimer.Visible = false;
            _beep.Play();
        }

        private void ResetJump(object sender, EventArgs e)
        {
            ((Timer)sender).Stop();
            lblJump.Text = "";
            lblJump.BackColor = Color.Empty;
            picTimer.Visible = true;
        }

        private void Shield()
        {
            if (_isTimerActive)
            {
                _shieldTimer.Interval += 1000;
                _shieldCounter++;
                lblShield.Text = String.Format("{0} Shields", _shieldCounter);
            }
            else
            {
                _shieldTimer = new Timer();
                _shieldTimer.Interval = 4000;
                _shieldTimer.Tick += new EventHandler(ResetShield);
                _shieldTimer.Start();
                _isTimerActive = true;
                _shieldCounter = 1;
                lblShield.BackColor = Color.LightSkyBlue;
                lblShield.Text = "1 Shield";
            }
        }

        private void ResetShield(object sender, EventArgs e)
        {
            ((Timer)sender).Stop();
            _isTimerActive = false;
            lblShield.Text = "";
            lblShield.BackColor = Color.Empty;
        }

        private void RedrawPie(object sender, EventArgs e)
        {
            _nextCounter += 1;
            picTimer.Invalidate();
            if (_nextCounter >= 400)
            {
                _nextTimer.Stop();
            }
        }

        private void picTimerPaint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            var p = (float)((_nextCounter / 400.0) * 360.0);
            g.FillPie(_nextColor, _rect, -90f, p);
        }

        private void picTimerResize(object sender, EventArgs e)
        {
            _rect = calcRect();
        }

        private Rectangle calcRect()
        {
            var w = picTimer.Width - _padding * 2;
            var h = picTimer.Height - _padding * 2;
            if (w > h)
            {
                var p = (w - h) / 2;
                return new Rectangle(p, picTimer.Top + _padding, h, h);
            }
            else
            {
                var p = (h - w) / 2;
                return new Rectangle(picTimer.Left + _padding, p, w, w);
            }
        }

    }
}
