namespace Remote_control_AUV
{
    partial class Mission_Control
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mission_Control));
            this.Fwd = new System.Windows.Forms.Button();
            this.Left = new System.Windows.Forms.Button();
            this.Stop = new System.Windows.Forms.Button();
            this.Right = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.High = new System.Windows.Forms.Button();
            this.Low = new System.Windows.Forms.Button();
            this.Throttle = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Fwd
            // 
            this.Fwd.Location = new System.Drawing.Point(535, 137);
            this.Fwd.Name = "Fwd";
            this.Fwd.Size = new System.Drawing.Size(63, 60);
            this.Fwd.TabIndex = 0;
            this.Fwd.Text = "Fwd";
            this.Fwd.UseVisualStyleBackColor = true;
            this.Fwd.Click += new System.EventHandler(this.Fwd_Click);
            // 
            // Left
            // 
            this.Left.Location = new System.Drawing.Point(466, 206);
            this.Left.Name = "Left";
            this.Left.Size = new System.Drawing.Size(63, 60);
            this.Left.TabIndex = 1;
            this.Left.Text = "Left";
            this.Left.UseVisualStyleBackColor = true;
            this.Left.Click += new System.EventHandler(this.Left_Click);
            // 
            // Stop
            // 
            this.Stop.Location = new System.Drawing.Point(535, 206);
            this.Stop.Name = "Stop";
            this.Stop.Size = new System.Drawing.Size(63, 60);
            this.Stop.TabIndex = 2;
            this.Stop.Text = "Stop";
            this.Stop.UseVisualStyleBackColor = true;
            this.Stop.Click += new System.EventHandler(this.Stop_Click);
            // 
            // Right
            // 
            this.Right.Location = new System.Drawing.Point(604, 206);
            this.Right.Name = "Right";
            this.Right.Size = new System.Drawing.Size(63, 60);
            this.Right.TabIndex = 3;
            this.Right.Text = "Right";
            this.Right.UseVisualStyleBackColor = true;
            this.Right.Click += new System.EventHandler(this.Right_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(695, 141);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(63, 60);
            this.button4.TabIndex = 4;
            this.button4.Text = "Dive";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // High
            // 
            this.High.Location = new System.Drawing.Point(360, 141);
            this.High.Name = "High";
            this.High.Size = new System.Drawing.Size(63, 60);
            this.High.TabIndex = 5;
            this.High.Text = "High";
            this.High.UseVisualStyleBackColor = true;
            this.High.Click += new System.EventHandler(this.High_Click);
            // 
            // Low
            // 
            this.Low.Location = new System.Drawing.Point(360, 207);
            this.Low.Name = "Low";
            this.Low.Size = new System.Drawing.Size(63, 60);
            this.Low.TabIndex = 6;
            this.Low.Text = "Low";
            this.Low.UseVisualStyleBackColor = true;
            this.Low.Click += new System.EventHandler(this.Low_Click);
            // 
            // Throttle
            // 
            this.Throttle.AutoSize = true;
            this.Throttle.Font = new System.Drawing.Font("Trebuchet MS", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Throttle.Location = new System.Drawing.Point(355, 107);
            this.Throttle.Name = "Throttle";
            this.Throttle.Size = new System.Drawing.Size(87, 26);
            this.Throttle.TabIndex = 7;
            this.Throttle.Text = "Throttle";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(466, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(306, 119);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(349, 297);
            this.panel1.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(138, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 26);
            this.label1.TabIndex = 10;
            this.label1.Text = "Video_Input";
            // 
            // Mission_Control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(830, 298);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Throttle);
            this.Controls.Add(this.Low);
            this.Controls.Add(this.High);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.Right);
            this.Controls.Add(this.Stop);
            this.Controls.Add(this.Left);
            this.Controls.Add(this.Fwd);
            this.Name = "Mission_Control";
            this.Text = "Mission Control";
            this.Load += new System.EventHandler(this.Mission_Control_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Mission_Control_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Fwd;
        private System.Windows.Forms.Button Left;
        private System.Windows.Forms.Button Stop;
        private System.Windows.Forms.Button Right;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button High;
        private System.Windows.Forms.Button Low;
        private System.Windows.Forms.Label Throttle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}

