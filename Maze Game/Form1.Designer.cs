namespace Maze_Game
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.game = new System.Windows.Forms.Button();
            this.controls = new System.Windows.Forms.Button();
            this.credits = new System.Windows.Forms.Button();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-5, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(406, 282);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // game
            // 
            this.game.Location = new System.Drawing.Point(261, 41);
            this.game.Name = "game";
            this.game.Size = new System.Drawing.Size(117, 35);
            this.game.TabIndex = 2;
            this.game.Text = "New Game";
            this.game.UseVisualStyleBackColor = true;
            this.game.Click += new System.EventHandler(this.game_Click);
            // 
            // controls
            // 
            this.controls.Location = new System.Drawing.Point(261, 103);
            this.controls.Name = "controls";
            this.controls.Size = new System.Drawing.Size(117, 35);
            this.controls.TabIndex = 3;
            this.controls.Text = "Controls";
            this.controls.UseVisualStyleBackColor = true;
            this.controls.Click += new System.EventHandler(this.controls_Click);
            // 
            // credits
            // 
            this.credits.Location = new System.Drawing.Point(261, 165);
            this.credits.Name = "credits";
            this.credits.Size = new System.Drawing.Size(117, 35);
            this.credits.TabIndex = 4;
            this.credits.Text = "Credits";
            this.credits.UseVisualStyleBackColor = true;
            this.credits.Click += new System.EventHandler(this.credits_Click);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 277);
            this.Controls.Add(this.credits);
            this.Controls.Add(this.controls);
            this.Controls.Add(this.game);
            this.Controls.Add(this.pictureBox1);
            this.MaximumSize = new System.Drawing.Size(413, 316);
            this.MinimumSize = new System.Drawing.Size(413, 316);
            this.Name = "Form1";
            this.Text = "Maze Game";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button game;
        private System.Windows.Forms.Button controls;
        private System.Windows.Forms.Button credits;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
    }
}

