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
            this.lblJump = new System.Windows.Forms.Label();
            this.lblShield = new System.Windows.Forms.Label();
            this.pnlControls = new System.Windows.Forms.Panel();
            this.pnlControlsWrapper = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.sptLabels)).BeginInit();
            this.sptLabels.Panel1.SuspendLayout();
            this.sptLabels.Panel2.SuspendLayout();
            this.sptLabels.SuspendLayout();
            this.pnlControls.SuspendLayout();
            this.pnlControlsWrapper.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(0, 0);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(90, 23);
            this.btnConnect.TabIndex = 1;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Location = new System.Drawing.Point(96, 0);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(90, 23);
            this.btnDisconnect.TabIndex = 2;
            this.btnDisconnect.Text = "Disconnect";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(67, 4);
            // 
            // chkTop
            // 
            this.chkTop.AutoSize = true;
            this.chkTop.Location = new System.Drawing.Point(192, 2);
            this.chkTop.Name = "chkTop";
            this.chkTop.Size = new System.Drawing.Size(78, 21);
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
            this.sptLabels.Location = new System.Drawing.Point(12, 41);
            this.sptLabels.Name = "sptLabels";
            this.sptLabels.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // sptLabels.Panel1
            // 
            this.sptLabels.Panel1.Controls.Add(this.lblJump);
            // 
            // sptLabels.Panel2
            // 
            this.sptLabels.Panel2.Controls.Add(this.lblShield);
            this.sptLabels.Size = new System.Drawing.Size(282, 124);
            this.sptLabels.SplitterDistance = 59;
            this.sptLabels.TabIndex = 4;
            // 
            // lblJump
            // 
            this.lblJump.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblJump.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblJump.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJump.Location = new System.Drawing.Point(3, 0);
            this.lblJump.Name = "lblJump";
            this.lblJump.Size = new System.Drawing.Size(276, 59);
            this.lblJump.TabIndex = 0;
            this.lblJump.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblShield
            // 
            this.lblShield.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblShield.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblShield.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShield.Location = new System.Drawing.Point(3, 0);
            this.lblShield.Name = "lblShield";
            this.lblShield.Size = new System.Drawing.Size(276, 61);
            this.lblShield.TabIndex = 1;
            this.lblShield.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlControls
            // 
            this.pnlControls.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlControls.Controls.Add(this.chkTop);
            this.pnlControls.Controls.Add(this.btnDisconnect);
            this.pnlControls.Controls.Add(this.btnConnect);
            this.pnlControls.Location = new System.Drawing.Point(6, 0);
            this.pnlControls.Name = "pnlControls";
            this.pnlControls.Size = new System.Drawing.Size(270, 23);
            this.pnlControls.TabIndex = 8;
            // 
            // pnlControlsWrapper
            // 
            this.pnlControlsWrapper.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlControlsWrapper.Controls.Add(this.pnlControls);
            this.pnlControlsWrapper.Location = new System.Drawing.Point(12, 12);
            this.pnlControlsWrapper.Name = "pnlControlsWrapper";
            this.pnlControlsWrapper.Size = new System.Drawing.Size(282, 23);
            this.pnlControlsWrapper.TabIndex = 9;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 179);
            this.Controls.Add(this.pnlControlsWrapper);
            this.Controls.Add(this.sptLabels);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMain";
            this.Text = "Girgashiy Hail Notifier";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.sptLabels.Panel1.ResumeLayout(false);
            this.sptLabels.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sptLabels)).EndInit();
            this.sptLabels.ResumeLayout(false);
            this.pnlControls.ResumeLayout(false);
            this.pnlControls.PerformLayout();
            this.pnlControlsWrapper.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.CheckBox chkTop;
        private System.Windows.Forms.SplitContainer sptLabels;
        private System.Windows.Forms.Panel pnlControls;
        private System.Windows.Forms.Panel pnlControlsWrapper;
        private System.Windows.Forms.Label lblJump;
        private System.Windows.Forms.Label lblShield;
    }
}

