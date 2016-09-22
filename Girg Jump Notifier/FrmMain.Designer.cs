namespace Girg_Jump_Notifier
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.chkTop = new System.Windows.Forms.CheckBox();
            this.sptLabels = new System.Windows.Forms.SplitContainer();
            this.picTimer = new System.Windows.Forms.PictureBox();
            this.lblJump = new System.Windows.Forms.Label();
            this.lblShield = new System.Windows.Forms.Label();
            this.pnlControlsWrapper = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.sptLabels)).BeginInit();
            this.sptLabels.Panel1.SuspendLayout();
            this.sptLabels.Panel2.SuspendLayout();
            this.sptLabels.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTimer)).BeginInit();
            this.pnlControlsWrapper.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(3, 1);
            this.btnConnect.Margin = new System.Windows.Forms.Padding(2);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(70, 19);
            this.btnConnect.TabIndex = 1;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Location = new System.Drawing.Point(81, 1);
            this.btnDisconnect.Margin = new System.Windows.Forms.Padding(2);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(70, 19);
            this.btnDisconnect.TabIndex = 2;
            this.btnDisconnect.Text = "Disconnect";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // chkTop
            // 
            this.chkTop.AutoSize = true;
            this.chkTop.Location = new System.Drawing.Point(161, 3);
            this.chkTop.Margin = new System.Windows.Forms.Padding(2);
            this.chkTop.Name = "chkTop";
            this.chkTop.Size = new System.Drawing.Size(62, 17);
            this.chkTop.TabIndex = 3;
            this.chkTop.Text = "On Top";
            this.chkTop.UseVisualStyleBackColor = true;
            this.chkTop.CheckedChanged += new System.EventHandler(this.chkTop_CheckedChanged);
            // 
            // sptLabels
            // 
            this.sptLabels.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sptLabels.Location = new System.Drawing.Point(9, 31);
            this.sptLabels.Margin = new System.Windows.Forms.Padding(2);
            this.sptLabels.Name = "sptLabels";
            this.sptLabels.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // sptLabels.Panel1
            // 
            this.sptLabels.Panel1.Controls.Add(this.picTimer);
            this.sptLabels.Panel1.Controls.Add(this.lblJump);
            // 
            // sptLabels.Panel2
            // 
            this.sptLabels.Panel2.Controls.Add(this.lblShield);
            this.sptLabels.Size = new System.Drawing.Size(231, 101);
            this.sptLabels.SplitterDistance = 48;
            this.sptLabels.SplitterWidth = 3;
            this.sptLabels.TabIndex = 4;
            // 
            // picTimer
            // 
            this.picTimer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picTimer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picTimer.Location = new System.Drawing.Point(0, 0);
            this.picTimer.Name = "picTimer";
            this.picTimer.Size = new System.Drawing.Size(231, 48);
            this.picTimer.TabIndex = 10;
            this.picTimer.TabStop = false;
            // 
            // lblJump
            // 
            this.lblJump.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblJump.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblJump.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJump.Location = new System.Drawing.Point(0, 0);
            this.lblJump.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblJump.Name = "lblJump";
            this.lblJump.Size = new System.Drawing.Size(231, 48);
            this.lblJump.TabIndex = 0;
            this.lblJump.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblShield
            // 
            this.lblShield.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblShield.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblShield.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShield.Location = new System.Drawing.Point(0, 0);
            this.lblShield.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblShield.Name = "lblShield";
            this.lblShield.Size = new System.Drawing.Size(231, 50);
            this.lblShield.TabIndex = 1;
            this.lblShield.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlControlsWrapper
            // 
            this.pnlControlsWrapper.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pnlControlsWrapper.Controls.Add(this.chkTop);
            this.pnlControlsWrapper.Controls.Add(this.btnConnect);
            this.pnlControlsWrapper.Controls.Add(this.btnDisconnect);
            this.pnlControlsWrapper.Location = new System.Drawing.Point(9, 6);
            this.pnlControlsWrapper.Margin = new System.Windows.Forms.Padding(2);
            this.pnlControlsWrapper.Name = "pnlControlsWrapper";
            this.pnlControlsWrapper.Size = new System.Drawing.Size(231, 19);
            this.pnlControlsWrapper.TabIndex = 9;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(250, 145);
            this.Controls.Add(this.pnlControlsWrapper);
            this.Controls.Add(this.sptLabels);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMain";
            this.Text = "Girgashiy Hail Notifier";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.sptLabels.Panel1.ResumeLayout(false);
            this.sptLabels.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sptLabels)).EndInit();
            this.sptLabels.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picTimer)).EndInit();
            this.pnlControlsWrapper.ResumeLayout(false);
            this.pnlControlsWrapper.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.CheckBox chkTop;
        private System.Windows.Forms.SplitContainer sptLabels;
        private System.Windows.Forms.Panel pnlControlsWrapper;
        private System.Windows.Forms.Label lblJump;
        private System.Windows.Forms.Label lblShield;
        private System.Windows.Forms.PictureBox picTimer;
    }
}

