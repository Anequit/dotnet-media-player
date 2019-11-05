﻿namespace media_player
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
            this.Start_BTN = new System.Windows.Forms.Button();
            this.Stop_BTN = new System.Windows.Forms.Button();
            this.Next_BTN = new System.Windows.Forms.Button();
            this.Back_BTN = new System.Windows.Forms.Button();
            this.Songname_LBL = new System.Windows.Forms.TextBox();
            this.Volume = new System.Windows.Forms.TrackBar();
            this.volume_lbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Repeat_BTN = new System.Windows.Forms.CheckBox();
            this.Shuffle_BTN = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.Volume)).BeginInit();
            this.SuspendLayout();
            // 
            // Start_BTN
            // 
            this.Start_BTN.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Start_BTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Start_BTN.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.Start_BTN.Location = new System.Drawing.Point(106, 154);
            this.Start_BTN.Name = "Start_BTN";
            this.Start_BTN.Size = new System.Drawing.Size(173, 23);
            this.Start_BTN.TabIndex = 0;
            this.Start_BTN.Text = "▶";
            this.Start_BTN.UseVisualStyleBackColor = true;
            this.Start_BTN.Click += new System.EventHandler(this.Start_BTN_Click);
            // 
            // Stop_BTN
            // 
            this.Stop_BTN.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Stop_BTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Stop_BTN.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.Stop_BTN.Location = new System.Drawing.Point(284, 154);
            this.Stop_BTN.Name = "Stop_BTN";
            this.Stop_BTN.Size = new System.Drawing.Size(84, 23);
            this.Stop_BTN.TabIndex = 1;
            this.Stop_BTN.Text = "❙❙";
            this.Stop_BTN.UseVisualStyleBackColor = true;
            this.Stop_BTN.Click += new System.EventHandler(this.Stop_BTN_Click);
            // 
            // Next_BTN
            // 
            this.Next_BTN.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Next_BTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Next_BTN.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.Next_BTN.Location = new System.Drawing.Point(373, 154);
            this.Next_BTN.Name = "Next_BTN";
            this.Next_BTN.Size = new System.Drawing.Size(89, 23);
            this.Next_BTN.TabIndex = 2;
            this.Next_BTN.Text = "↪";
            this.Next_BTN.UseVisualStyleBackColor = true;
            this.Next_BTN.Click += new System.EventHandler(this.Next_BTN_Click);
            // 
            // Back_BTN
            // 
            this.Back_BTN.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Back_BTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Back_BTN.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.Back_BTN.Location = new System.Drawing.Point(12, 154);
            this.Back_BTN.Name = "Back_BTN";
            this.Back_BTN.Size = new System.Drawing.Size(89, 23);
            this.Back_BTN.TabIndex = 3;
            this.Back_BTN.Text = "↩";
            this.Back_BTN.UseVisualStyleBackColor = true;
            this.Back_BTN.Click += new System.EventHandler(this.Back_BTN_Click);
            // 
            // Songname_LBL
            // 
            this.Songname_LBL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Songname_LBL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.Songname_LBL.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Songname_LBL.Cursor = System.Windows.Forms.Cursors.Default;
            this.Songname_LBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Songname_LBL.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.Songname_LBL.Location = new System.Drawing.Point(12, 12);
            this.Songname_LBL.Name = "Songname_LBL";
            this.Songname_LBL.ReadOnly = true;
            this.Songname_LBL.Size = new System.Drawing.Size(450, 23);
            this.Songname_LBL.TabIndex = 5;
            this.Songname_LBL.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Volume
            // 
            this.Volume.Location = new System.Drawing.Point(12, 41);
            this.Volume.Maximum = 100;
            this.Volume.Name = "Volume";
            this.Volume.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.Volume.Size = new System.Drawing.Size(45, 104);
            this.Volume.TabIndex = 6;
            this.Volume.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.Volume.Value = 50;
            this.Volume.Scroll += new System.EventHandler(this.Volume_Scroll);
            // 
            // volume_lbl
            // 
            this.volume_lbl.AutoSize = true;
            this.volume_lbl.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.volume_lbl.Location = new System.Drawing.Point(50, 51);
            this.volume_lbl.Name = "volume_lbl";
            this.volume_lbl.Size = new System.Drawing.Size(13, 13);
            this.volume_lbl.TabIndex = 7;
            this.volume_lbl.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(370, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Made by Anequit";
            // 
            // Repeat_BTN
            // 
            this.Repeat_BTN.Appearance = System.Windows.Forms.Appearance.Button;
            this.Repeat_BTN.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Repeat_BTN.FlatAppearance.BorderColor = System.Drawing.SystemColors.ScrollBar;
            this.Repeat_BTN.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.Repeat_BTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Repeat_BTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Repeat_BTN.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.Repeat_BTN.Location = new System.Drawing.Point(373, 125);
            this.Repeat_BTN.Name = "Repeat_BTN";
            this.Repeat_BTN.Size = new System.Drawing.Size(89, 23);
            this.Repeat_BTN.TabIndex = 9;
            this.Repeat_BTN.Text = "Repeat Track";
            this.Repeat_BTN.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Repeat_BTN.UseVisualStyleBackColor = true;
            this.Repeat_BTN.CheckedChanged += new System.EventHandler(this.Repeat_BTN_CheckedChanged);
            // 
            // Shuffle_BTN
            // 
            this.Shuffle_BTN.Appearance = System.Windows.Forms.Appearance.Button;
            this.Shuffle_BTN.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Shuffle_BTN.FlatAppearance.BorderColor = System.Drawing.SystemColors.ScrollBar;
            this.Shuffle_BTN.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.Shuffle_BTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Shuffle_BTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Shuffle_BTN.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.Shuffle_BTN.Location = new System.Drawing.Point(373, 96);
            this.Shuffle_BTN.Name = "Shuffle_BTN";
            this.Shuffle_BTN.Size = new System.Drawing.Size(89, 23);
            this.Shuffle_BTN.TabIndex = 10;
            this.Shuffle_BTN.Text = "Shuffle";
            this.Shuffle_BTN.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Shuffle_BTN.UseVisualStyleBackColor = true;
            this.Shuffle_BTN.CheckedChanged += new System.EventHandler(this.Shuffle_BTN_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(474, 189);
            this.Controls.Add(this.Shuffle_BTN);
            this.Controls.Add(this.Repeat_BTN);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.volume_lbl);
            this.Controls.Add(this.Volume);
            this.Controls.Add(this.Songname_LBL);
            this.Controls.Add(this.Back_BTN);
            this.Controls.Add(this.Next_BTN);
            this.Controls.Add(this.Stop_BTN);
            this.Controls.Add(this.Start_BTN);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(490, 228);
            this.MinimumSize = new System.Drawing.Size(490, 228);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MP3 PLAYER";
            ((System.ComponentModel.ISupportInitialize)(this.Volume)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Start_BTN;
        private System.Windows.Forms.Button Stop_BTN;
        private System.Windows.Forms.Button Next_BTN;
        private System.Windows.Forms.Button Back_BTN;
        private System.Windows.Forms.TextBox Songname_LBL;
        private System.Windows.Forms.TrackBar Volume;
        private System.Windows.Forms.Label volume_lbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox Repeat_BTN;
        private System.Windows.Forms.CheckBox Shuffle_BTN;
    }
}

