﻿namespace Pong_Game
{
    partial class Player0
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
            player = new PictureBox();
            computer = new PictureBox();
            ball = new PictureBox();
            Gametimer = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)player).BeginInit();
            ((System.ComponentModel.ISupportInitialize)computer).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ball).BeginInit();
            SuspendLayout();
            // 
            // player
            // 
            player.Image = Properties.Resources.player;
            player.Location = new Point(12, 126);
            player.Name = "player";
            player.Size = new Size(30, 120);
            player.SizeMode = PictureBoxSizeMode.StretchImage;
            player.TabIndex = 0;
            player.TabStop = false;
            // 
            // computer
            // 
            computer.Image = Properties.Resources.computer;
            computer.Location = new Point(758, 126);
            computer.Name = "computer";
            computer.Size = new Size(30, 120);
            computer.SizeMode = PictureBoxSizeMode.StretchImage;
            computer.TabIndex = 1;
            computer.TabStop = false;
            // 
            // ball
            // 
            ball.Image = Properties.Resources.ball;
            ball.Location = new Point(385, 165);
            ball.Name = "ball";
            ball.Size = new Size(30, 30);
            ball.SizeMode = PictureBoxSizeMode.StretchImage;
            ball.TabIndex = 2;
            ball.TabStop = false;
            // 
            // Gametimer
            // 
            Gametimer.Enabled = true;
            Gametimer.Interval = 20;
            Gametimer.Tick += GametimerEvent;
            // 
            // Player0
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(800, 450);
            Controls.Add(ball);
            Controls.Add(computer);
            Controls.Add(player);
            Name = "Player0";
            Text = "Player : 0 // Computer : 0";
            KeyDown += KeyIsDown;
            KeyUp += KeyIsUp;
            ((System.ComponentModel.ISupportInitialize)player).EndInit();
            ((System.ComponentModel.ISupportInitialize)computer).EndInit();
            ((System.ComponentModel.ISupportInitialize)ball).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox player;
        private PictureBox computer;
        private PictureBox ball;
        private System.Windows.Forms.Timer Gametimer;
    }
}
