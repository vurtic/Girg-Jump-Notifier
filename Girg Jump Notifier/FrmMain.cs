using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
        private bool _isTimerActive;
        private int _shieldCounter;

        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            _Connection = new Connection(this.Handle);
            btnConnect.Select();
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
            if(p.Op == 0xA41E)     // SharpMind
            {
                var entityId = p.GetLong();
                p.GetByte();
                p.GetByte();
                // if the next element is an int, sharp mind from girg
                // otherwise a regular sharp mind will be short then int
                if(p.NextIs(PacketElementType.Int))
                {
                    var girgAction = p.GetInt();
                    if (girgAction == 1)
                    {
                        // girg jump
                        Jump();
                    }
                }
            }
            else if (p.Op == 0x6D62)     // UseMotion
            {
                var category = p.GetInt();
                var type = p.GetInt();
                var loop = p.GetByte();
                var zero = p.GetShort();
                if (category == 161 && type == 0)
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
             * jump can also be identified by UseMotion
             * category == 162
             * type == 8
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
            else if (p.Op == 0x6D62)    // UseMotion
            {
                var category = p.GetInt();
                var type = p.GetInt();
                var loop = p.GetByte();
                var zero = p.GetShort();
                if (category == 162 && type == 8)
                {
                    // girg jump
                }
            }
            */
        }

        private void Jump()
        {
            lblJump.Text = "Girgashiy Hail";
            lblJump.BackColor = Color.YellowGreen;
            var jumpTimer = new Timer();
            jumpTimer.Interval = 10000;
            jumpTimer.Tick += new EventHandler(ResetJump);
            jumpTimer.Start();
        }

        private void ResetJump(object sender, EventArgs e)
        {
            ((Timer)sender).Stop();
            lblJump.Text = "";
            lblJump.BackColor = Color.White;
        }

        private void Shield()
        {
            if (_isTimerActive)
            {
                _shieldTimer.Interval += 1000;
                _shieldCounter++;
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
            }
            lblShield.Text = String.Format("{0} Shields", _shieldCounter);
        }

        private void ResetShield(object sender, EventArgs e)
        {
            ((Timer)sender).Stop();
            _isTimerActive = false;
            lblShield.Text = "";
            lblShield.BackColor = Color.White;
        }

    }
}
