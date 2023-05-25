﻿namespace CERAX_AntiAircraftGame
{
    partial class GameScreen
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pGameSettings = new System.Windows.Forms.Panel();
            this.btnMark = new System.Windows.Forms.Button();
            this.lblHighScore = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.lblScore = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.pCastleArea = new System.Windows.Forms.Panel();
            this.pGameArea = new System.Windows.Forms.Panel();
            this.pGameSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // pGameSettings
            // 
            this.pGameSettings.Controls.Add(this.btnMark);
            this.pGameSettings.Controls.Add(this.lblHighScore);
            this.pGameSettings.Controls.Add(this.label2);
            this.pGameSettings.Controls.Add(this.btnExit);
            this.pGameSettings.Controls.Add(this.btnStart);
            this.pGameSettings.Controls.Add(this.lblScore);
            this.pGameSettings.Controls.Add(this.label3);
            this.pGameSettings.Controls.Add(this.bunifuSeparator1);
            this.pGameSettings.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pGameSettings.Location = new System.Drawing.Point(0, 558);
            this.pGameSettings.Name = "pGameSettings";
            this.pGameSettings.Size = new System.Drawing.Size(1000, 42);
            this.pGameSettings.TabIndex = 0;
            // 
            // btnMark
            // 
            this.btnMark.Cursor = System.Windows.Forms.Cursors.No;
            this.btnMark.FlatAppearance.BorderSize = 0;
            this.btnMark.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnMark.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnMark.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMark.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMark.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnMark.Location = new System.Drawing.Point(421, 9);
            this.btnMark.Name = "btnMark";
            this.btnMark.Size = new System.Drawing.Size(159, 32);
            this.btnMark.TabIndex = 7;
            this.btnMark.Text = "X";
            this.btnMark.UseVisualStyleBackColor = true;
            // 
            // lblHighScore
            // 
            this.lblHighScore.AutoSize = true;
            this.lblHighScore.BackColor = System.Drawing.Color.Transparent;
            this.lblHighScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHighScore.Location = new System.Drawing.Point(689, 10);
            this.lblHighScore.Name = "lblHighScore";
            this.lblHighScore.Size = new System.Drawing.Size(24, 25);
            this.lblHighScore.TabIndex = 6;
            this.lblHighScore.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(606, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "High";
            // 
            // btnExit
            // 
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(919, 10);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(81, 32);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnStart
            // 
            this.btnStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStart.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnStart.FlatAppearance.BorderSize = 0;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(0, 10);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(109, 32);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.BackColor = System.Drawing.Color.Transparent;
            this.lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.Location = new System.Drawing.Point(362, 11);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(24, 25);
            this.lblScore.TabIndex = 4;
            this.lblScore.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(274, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Score";
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(130)))), ((int)(((byte)(180)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(0, 0);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(1000, 10);
            this.bunifuSeparator1.TabIndex = 0;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // pCastleArea
            // 
            this.pCastleArea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(5)))));
            this.pCastleArea.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pCastleArea.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pCastleArea.Location = new System.Drawing.Point(0, 508);
            this.pCastleArea.Name = "pCastleArea";
            this.pCastleArea.Size = new System.Drawing.Size(1000, 50);
            this.pCastleArea.TabIndex = 2;
            // 
            // pGameArea
            // 
            this.pGameArea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(9)))));
            this.pGameArea.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pGameArea.Cursor = System.Windows.Forms.Cursors.No;
            this.pGameArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pGameArea.Location = new System.Drawing.Point(0, 0);
            this.pGameArea.Name = "pGameArea";
            this.pGameArea.Size = new System.Drawing.Size(1000, 508);
            this.pGameArea.TabIndex = 3;
            this.pGameArea.Click += new System.EventHandler(this.pGameArea_Click);
            // 
            // GameScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.pGameArea);
            this.Controls.Add(this.pCastleArea);
            this.Controls.Add(this.pGameSettings);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Name = "GameScreen";
            this.Size = new System.Drawing.Size(1000, 600);
            this.pGameSettings.ResumeLayout(false);
            this.pGameSettings.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pGameSettings;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private System.Windows.Forms.Label lblHighScore;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pCastleArea;
        private System.Windows.Forms.Panel pGameArea;
        private System.Windows.Forms.Button btnMark;
    }
}
