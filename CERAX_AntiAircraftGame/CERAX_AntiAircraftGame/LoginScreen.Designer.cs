namespace CERAX_AntiAircraftGame
{
    partial class LoginScreen
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timerPBar = new System.Windows.Forms.Timer(this.components);
            this.PBar = new Bunifu.Framework.UI.BunifuProgressBar();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(406, 222);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "CERA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SteelBlue;
            this.label2.Location = new System.Drawing.Point(488, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 73);
            this.label2.TabIndex = 1;
            this.label2.Text = "X";
            // 
            // timerPBar
            // 
            this.timerPBar.Enabled = true;
            this.timerPBar.Interval = 10;
            this.timerPBar.Tick += new System.EventHandler(this.timerPBar_Tick);
            // 
            // PBar
            // 
            this.PBar.BackColor = System.Drawing.Color.Silver;
            this.PBar.BorderRadius = 5;
            this.PBar.Location = new System.Drawing.Point(164, 310);
            this.PBar.MaximumValue = 100;
            this.PBar.Name = "PBar";
            this.PBar.ProgressColor = System.Drawing.Color.SteelBlue;
            this.PBar.Size = new System.Drawing.Size(671, 5);
            this.PBar.TabIndex = 3;
            this.PBar.Value = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe Script", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(442, 265);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 30);
            this.label4.TabIndex = 4;
            this.label4.Text = "Home Studio";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(547, 222);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 33);
            this.label5.TabIndex = 5;
            this.label5.Text = "LAN";
            // 
            // LoginScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.PBar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Name = "LoginScreen";
            this.Size = new System.Drawing.Size(1000, 600);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timerPBar;
        private Bunifu.Framework.UI.BunifuProgressBar PBar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}
