namespace ValentinesDay
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            Ground = new PictureBox();
            Mario = new PictureBox();
            Obstacle1 = new PictureBox();
            Obstacle2 = new PictureBox();
            Heart = new PictureBox();
            HeartBroken = new PictureBox();
            GameTimer = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)Ground).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Mario).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Obstacle1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Obstacle2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Heart).BeginInit();
            ((System.ComponentModel.ISupportInitialize)HeartBroken).BeginInit();
            SuspendLayout();
            // 
            // Ground
            // 
            Ground.Dock = DockStyle.Bottom;
            Ground.Image = Properties.Resources.ground;
            Ground.Location = new Point(3, 696);
            Ground.Name = "Ground";
            Ground.Size = new Size(1216, 50);
            Ground.SizeMode = PictureBoxSizeMode.StretchImage;
            Ground.TabIndex = 0;
            Ground.TabStop = false;
            // 
            // Mario
            // 
            Mario.BackColor = SystemColors.Control;
            Mario.Image = Properties.Resources.mario_run;
            Mario.Location = new Point(13, 653);
            Mario.Name = "Mario";
            Mario.Size = new Size(44, 60);
            Mario.SizeMode = PictureBoxSizeMode.StretchImage;
            Mario.TabIndex = 1;
            Mario.TabStop = false;
            // 
            // Obstacle1
            // 
            Obstacle1.Image = Properties.Resources.obstacle_1;
            Obstacle1.Location = new Point(740, 667);
            Obstacle1.Name = "Obstacle1";
            Obstacle1.Size = new Size(23, 46);
            Obstacle1.SizeMode = PictureBoxSizeMode.AutoSize;
            Obstacle1.TabIndex = 2;
            Obstacle1.TabStop = false;
            Obstacle1.Tag = "obstacle";
            // 
            // Obstacle2
            // 
            Obstacle2.Image = Properties.Resources.obstacle_2;
            Obstacle2.Location = new Point(1056, 663);
            Obstacle2.Name = "Obstacle2";
            Obstacle2.Size = new Size(50, 50);
            Obstacle2.SizeMode = PictureBoxSizeMode.StretchImage;
            Obstacle2.TabIndex = 3;
            Obstacle2.TabStop = false;
            Obstacle2.Tag = "obstacle";
            // 
            // Heart
            // 
            Heart.BackColor = Color.Transparent;
            Heart.Image = Properties.Resources.heart_resized;
            Heart.Location = new Point(867, 634);
            Heart.Name = "Heart";
            Heart.Size = new Size(32, 33);
            Heart.SizeMode = PictureBoxSizeMode.AutoSize;
            Heart.TabIndex = 4;
            Heart.TabStop = false;
            Heart.Tag = "obstacle";
            // 
            // HeartBroken
            // 
            HeartBroken.Image = Properties.Resources.broken_heart_resized;
            HeartBroken.Location = new Point(1173, 677);
            HeartBroken.Name = "HeartBroken";
            HeartBroken.Size = new Size(32, 33);
            HeartBroken.SizeMode = PictureBoxSizeMode.AutoSize;
            HeartBroken.TabIndex = 5;
            HeartBroken.TabStop = false;
            HeartBroken.Tag = "obstacle";
            // 
            // GameTimer
            // 
            GameTimer.Tick += GameTimer_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1222, 748);
            Controls.Add(HeartBroken);
            Controls.Add(Heart);
            Controls.Add(Mario);
            Controls.Add(Obstacle2);
            Controls.Add(Obstacle1);
            Controls.Add(Ground);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Padding = new Padding(3, 51, 3, 2);
            Text = "ValentinesGame💘";
            KeyDown += Form1_KeyDown;
            KeyUp += Form1_KeyUp;
            ((System.ComponentModel.ISupportInitialize)Ground).EndInit();
            ((System.ComponentModel.ISupportInitialize)Mario).EndInit();
            ((System.ComponentModel.ISupportInitialize)Obstacle1).EndInit();
            ((System.ComponentModel.ISupportInitialize)Obstacle2).EndInit();
            ((System.ComponentModel.ISupportInitialize)Heart).EndInit();
            ((System.ComponentModel.ISupportInitialize)HeartBroken).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox Ground;
        private PictureBox Mario;
        private PictureBox Obstacle1;
        private PictureBox Obstacle2;
        private PictureBox Heart;
        private PictureBox HeartBroken;
        private System.Windows.Forms.Timer GameTimer;
    }
}
