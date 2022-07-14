
namespace yoketoruvs22
{
    partial class よけとる2022
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
            this.components = new System.ComponentModel.Container();
            this.titleLabel = new System.Windows.Forms.Label();
            this.startbutton = new System.Windows.Forms.Button();
            this.CPLabel = new System.Windows.Forms.Label();
            this.timeLabel = new System.Windows.Forms.Label();
            this.leftLabel = new System.Windows.Forms.Label();
            this.hiLabel = new System.Windows.Forms.Label();
            this.GameoverLabel = new System.Windows.Forms.Label();
            this.clearLabel = new System.Windows.Forms.Label();
            this.titileButton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tempLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.titleLabel.Font = new System.Drawing.Font("せのびゴシック Medium", 45F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.titleLabel.ForeColor = System.Drawing.Color.Blue;
            this.titleLabel.Location = new System.Drawing.Point(176, 80);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(446, 99);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "よけとる2022";
            this.titleLabel.UseMnemonic = false;
            // 
            // startbutton
            // 
            this.startbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.startbutton.Font = new System.Drawing.Font("Yu Gothic UI", 38F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.startbutton.Location = new System.Drawing.Point(314, 269);
            this.startbutton.Name = "startbutton";
            this.startbutton.Size = new System.Drawing.Size(172, 72);
            this.startbutton.TabIndex = 1;
            this.startbutton.Text = "Start";
            this.startbutton.UseVisualStyleBackColor = false;
            this.startbutton.Click += new System.EventHandler(this.startbutton_Click);
            // 
            // CPLabel
            // 
            this.CPLabel.Font = new System.Drawing.Font("Yu Gothic UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CPLabel.Location = new System.Drawing.Point(256, 406);
            this.CPLabel.Name = "CPLabel";
            this.CPLabel.Size = new System.Drawing.Size(269, 35);
            this.CPLabel.TabIndex = 2;
            this.CPLabel.Text = "copyright　©　2022荒川 龍　";
            // 
            // timeLabel
            // 
            this.timeLabel.Font = new System.Drawing.Font("Yu Gothic UI", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.timeLabel.Location = new System.Drawing.Point(12, 9);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(195, 71);
            this.timeLabel.TabIndex = 3;
            this.timeLabel.Text = "Time 100";
            // 
            // leftLabel
            // 
            this.leftLabel.Font = new System.Drawing.Font("Yu Gothic UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.leftLabel.Location = new System.Drawing.Point(668, 9);
            this.leftLabel.Name = "leftLabel";
            this.leftLabel.Size = new System.Drawing.Size(120, 71);
            this.leftLabel.TabIndex = 4;
            this.leftLabel.Text = "★:10";
            // 
            // hiLabel
            // 
            this.hiLabel.Font = new System.Drawing.Font("Yu Gothic UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.hiLabel.Location = new System.Drawing.Point(290, 216);
            this.hiLabel.Name = "hiLabel";
            this.hiLabel.Size = new System.Drawing.Size(235, 35);
            this.hiLabel.TabIndex = 5;
            this.hiLabel.Text = "High Score 100";
            // 
            // GameoverLabel
            // 
            this.GameoverLabel.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.GameoverLabel.Font = new System.Drawing.Font("Yu Gothic UI", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.GameoverLabel.ForeColor = System.Drawing.Color.Red;
            this.GameoverLabel.Location = new System.Drawing.Point(207, 149);
            this.GameoverLabel.Name = "GameoverLabel";
            this.GameoverLabel.Size = new System.Drawing.Size(403, 117);
            this.GameoverLabel.TabIndex = 6;
            this.GameoverLabel.Text = "Game Over";
            // 
            // clearLabel
            // 
            this.clearLabel.Font = new System.Drawing.Font("源ノ角ゴシック Code JP R", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.clearLabel.Location = new System.Drawing.Point(230, 173);
            this.clearLabel.Name = "clearLabel";
            this.clearLabel.Size = new System.Drawing.Size(361, 87);
            this.clearLabel.TabIndex = 7;
            this.clearLabel.Text = "CLEAR!!";
            // 
            // titileButton
            // 
            this.titileButton.Font = new System.Drawing.Font("Yu Gothic UI", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.titileButton.Location = new System.Drawing.Point(303, 269);
            this.titileButton.Name = "titileButton";
            this.titileButton.Size = new System.Drawing.Size(202, 84);
            this.titileButton.TabIndex = 8;
            this.titileButton.Text = "タイトルへ";
            this.titileButton.UseVisualStyleBackColor = true;
            this.titileButton.Click += new System.EventHandler(this.titileButton_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // tempLabel
            // 
            this.tempLabel.Font = new System.Drawing.Font("Yu Gothic UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tempLabel.Location = new System.Drawing.Point(81, 300);
            this.tempLabel.Name = "tempLabel";
            this.tempLabel.Size = new System.Drawing.Size(38, 55);
            this.tempLabel.TabIndex = 9;
            this.tempLabel.Text = "●";
            this.tempLabel.Visible = false;
            // 
            // よけとる2022
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tempLabel);
            this.Controls.Add(this.titileButton);
            this.Controls.Add(this.clearLabel);
            this.Controls.Add(this.GameoverLabel);
            this.Controls.Add(this.hiLabel);
            this.Controls.Add(this.leftLabel);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.CPLabel);
            this.Controls.Add(this.startbutton);
            this.Controls.Add(this.titleLabel);
            this.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Name = "よけとる2022";
            this.Text = "よけとる２０２２";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Button startbutton;
        private System.Windows.Forms.Label CPLabel;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Label leftLabel;
        private System.Windows.Forms.Label hiLabel;
        private System.Windows.Forms.Label GameoverLabel;
        private System.Windows.Forms.Label clearLabel;
        private System.Windows.Forms.Button titileButton;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label tempLabel;
    }
}

