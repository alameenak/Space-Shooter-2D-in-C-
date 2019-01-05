namespace gameinCsharp
{
    partial class SpellGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SpellGame));
            this.movebg = new System.Windows.Forms.Timer(this.components);
            this.player = new System.Windows.Forms.PictureBox();
            this.leftMove = new System.Windows.Forms.Timer(this.components);
            this.rightMove = new System.Windows.Forms.Timer(this.components);
            this.upMove = new System.Windows.Forms.Timer(this.components);
            this.downMove = new System.Windows.Forms.Timer(this.components);
            this.moveMunition = new System.Windows.Forms.Timer(this.components);
            this.moveEnemy = new System.Windows.Forms.Timer(this.components);
            this.enemyMunitionTimer = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.REPLAY = new System.Windows.Forms.Button();
            this.EXIT = new System.Windows.Forms.Button();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.levelLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            this.SuspendLayout();
            // 
            // movebg
            // 
            this.movebg.Enabled = true;
            this.movebg.Interval = 10;
            this.movebg.Tick += new System.EventHandler(this.movebg_Tick);
            // 
            // player
            // 
            this.player.BackColor = System.Drawing.Color.Transparent;
            this.player.Image = ((System.Drawing.Image)(resources.GetObject("player.Image")));
            this.player.Location = new System.Drawing.Point(239, 355);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(50, 50);
            this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.player.TabIndex = 0;
            this.player.TabStop = false;
            // 
            // leftMove
            // 
            this.leftMove.Interval = 5;
            this.leftMove.Tick += new System.EventHandler(this.leftMove_Tick);
            // 
            // rightMove
            // 
            this.rightMove.Interval = 5;
            this.rightMove.Tick += new System.EventHandler(this.rightMove_Tick);
            // 
            // upMove
            // 
            this.upMove.Interval = 5;
            this.upMove.Tick += new System.EventHandler(this.upMove_Tick);
            // 
            // downMove
            // 
            this.downMove.Interval = 5;
            this.downMove.Tick += new System.EventHandler(this.downMove_Tick);
            // 
            // moveMunition
            // 
            this.moveMunition.Enabled = true;
            this.moveMunition.Interval = 20;
            this.moveMunition.Tick += new System.EventHandler(this.moveMunition_Tick);
            // 
            // moveEnemy
            // 
            this.moveEnemy.Enabled = true;
            this.moveEnemy.Tick += new System.EventHandler(this.moveEnemy_Tick);
            // 
            // enemyMunitionTimer
            // 
            this.enemyMunitionTimer.Enabled = true;
            this.enemyMunitionTimer.Interval = 20;
            this.enemyMunitionTimer.Tick += new System.EventHandler(this.enemyMunitionTimer_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Swis721 BlkEx BT", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(193, 99);
            this.label1.MinimumSize = new System.Drawing.Size(75, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 45);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            this.label1.Visible = false;
            // 
            // REPLAY
            // 
            this.REPLAY.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.REPLAY.Location = new System.Drawing.Point(178, 163);
            this.REPLAY.Name = "REPLAY";
            this.REPLAY.Size = new System.Drawing.Size(209, 52);
            this.REPLAY.TabIndex = 2;
            this.REPLAY.Text = "REPLAY";
            this.REPLAY.UseVisualStyleBackColor = true;
            this.REPLAY.Visible = false;
            this.REPLAY.Click += new System.EventHandler(this.REPLAY_Click);
            // 
            // EXIT
            // 
            this.EXIT.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EXIT.Location = new System.Drawing.Point(178, 225);
            this.EXIT.Name = "EXIT";
            this.EXIT.Size = new System.Drawing.Size(209, 47);
            this.EXIT.TabIndex = 3;
            this.EXIT.Text = "EXIT";
            this.EXIT.UseVisualStyleBackColor = true;
            this.EXIT.Visible = false;
            this.EXIT.Click += new System.EventHandler(this.EXIT_Click);
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.scoreLabel.Location = new System.Drawing.Point(13, 13);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(64, 16);
            this.scoreLabel.TabIndex = 4;
            this.scoreLabel.Text = "SCORE:";
            // 
            // levelLabel
            // 
            this.levelLabel.AutoSize = true;
            this.levelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.levelLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.levelLabel.Location = new System.Drawing.Point(501, 14);
            this.levelLabel.Name = "levelLabel";
            this.levelLabel.Size = new System.Drawing.Size(66, 16);
            this.levelLabel.TabIndex = 5;
            this.levelLabel.Text = "LEVEL:0";
            // 
            // SpellGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.levelLabel);
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EXIT);
            this.Controls.Add(this.REPLAY);
            this.Controls.Add(this.player);
            this.MaximumSize = new System.Drawing.Size(600, 500);
            this.Name = "SpellGame";
            this.Text = "SpaceShooter2D";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SpellGame_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.SpellGame_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer movebg;
        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.Timer leftMove;
        private System.Windows.Forms.Timer rightMove;
        private System.Windows.Forms.Timer upMove;
        private System.Windows.Forms.Timer downMove;
        private System.Windows.Forms.Timer moveMunition;
        private System.Windows.Forms.Timer moveEnemy;
        private System.Windows.Forms.Timer enemyMunitionTimer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button REPLAY;
        private System.Windows.Forms.Button EXIT;
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.Label levelLabel;
    }
}

