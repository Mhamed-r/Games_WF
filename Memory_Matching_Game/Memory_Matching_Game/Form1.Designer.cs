namespace Memory_Matching_Game
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            PL_Game = new Panel();
            label1 = new Label();
            Lb_Score = new Label();
            imageList1 = new ImageList(components);
            SuspendLayout();
            // 
            // PL_Game
            // 
            PL_Game.Location = new Point(61, 32);
            PL_Game.Name = "PL_Game";
            PL_Game.Size = new Size(400, 400);
            PL_Game.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(322, 464);
            label1.Name = "label1";
            label1.Size = new Size(93, 32);
            label1.TabIndex = 1;
            label1.Text = "Score";
            // 
            // Lb_Score
            // 
            Lb_Score.BackColor = SystemColors.ActiveCaptionText;
            Lb_Score.BorderStyle = BorderStyle.Fixed3D;
            Lb_Score.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Lb_Score.ForeColor = SystemColors.MenuHighlight;
            Lb_Score.Location = new Point(417, 463);
            Lb_Score.Name = "Lb_Score";
            Lb_Score.Size = new Size(114, 32);
            Lb_Score.TabIndex = 2;
            Lb_Score.Text = "0";
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "pngegg (1).png");
            imageList1.Images.SetKeyName(1, "pngegg.png");
            imageList1.Images.SetKeyName(2, "pngegg (2).png");
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(543, 522);
            Controls.Add(Lb_Score);
            Controls.Add(label1);
            Controls.Add(PL_Game);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel PL_Game;
        private Label label1;
        private Label Lb_Score;
        private ImageList imageList1;
    }
}
