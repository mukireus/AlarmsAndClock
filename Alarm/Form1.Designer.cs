namespace Alarm
{
    partial class Form_Clock
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
            this.lblClock = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.circularProgressBar = new CircularProgressBar.CircularProgressBar();
            this.lblSecond = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblClock
            // 
            this.lblClock.AutoSize = true;
            this.lblClock.Font = new System.Drawing.Font("Microsoft Tai Le", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblClock.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblClock.Location = new System.Drawing.Point(219, 245);
            this.lblClock.Name = "lblClock";
            this.lblClock.Size = new System.Drawing.Size(189, 75);
            this.lblClock.TabIndex = 0;
            this.lblClock.Text = "11:11";
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // circularProgressBar
            // 
            this.circularProgressBar.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.circularProgressBar.AnimationSpeed = 1000;
            this.circularProgressBar.BackColor = System.Drawing.Color.Transparent;
            this.circularProgressBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold);
            this.circularProgressBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.circularProgressBar.InnerColor = System.Drawing.Color.Transparent;
            this.circularProgressBar.InnerMargin = 2;
            this.circularProgressBar.InnerWidth = -1;
            this.circularProgressBar.Location = new System.Drawing.Point(152, 128);
            this.circularProgressBar.MarqueeAnimationSpeed = 2000;
            this.circularProgressBar.Maximum = 60;
            this.circularProgressBar.Name = "circularProgressBar";
            this.circularProgressBar.OuterColor = System.Drawing.Color.Gray;
            this.circularProgressBar.OuterMargin = -25;
            this.circularProgressBar.OuterWidth = 26;
            this.circularProgressBar.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(219)))), ((int)(((byte)(235)))));
            this.circularProgressBar.ProgressWidth = 10;
            this.circularProgressBar.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.circularProgressBar.Size = new System.Drawing.Size(320, 320);
            this.circularProgressBar.StartAngle = 270;
            this.circularProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.circularProgressBar.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circularProgressBar.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.circularProgressBar.SubscriptText = ".23";
            this.circularProgressBar.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circularProgressBar.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.circularProgressBar.SuperscriptText = "°C";
            this.circularProgressBar.TabIndex = 1;
            this.circularProgressBar.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.circularProgressBar.Value = 60;
            // 
            // lblSecond
            // 
            this.lblSecond.AutoSize = true;
            this.lblSecond.Font = new System.Drawing.Font("Microsoft Tai Le", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSecond.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblSecond.Location = new System.Drawing.Point(297, 177);
            this.lblSecond.Name = "lblSecond";
            this.lblSecond.Size = new System.Drawing.Size(31, 23);
            this.lblSecond.TabIndex = 2;
            this.lblSecond.Text = "11";
            // 
            // Form_Clock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(23)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(624, 560);
            this.Controls.Add(this.lblSecond);
            this.Controls.Add(this.lblClock);
            this.Controls.Add(this.circularProgressBar);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form_Clock";
            this.ShowIcon = false;
            this.Text = "Alarms and Clock";
            this.Load += new System.EventHandler(this.Form_Clock_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblClock;
        private System.Windows.Forms.Timer timer;
        private CircularProgressBar.CircularProgressBar circularProgressBar;
        private System.Windows.Forms.Label lblSecond;
    }
}

