namespace TOH
{
    partial class GameForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameForm));
            this.panel = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.StepsNote = new System.Windows.Forms.RichTextBox();
            this.destinationPole = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.noDisks = new System.Windows.Forms.NumericUpDown();
            this.reset = new System.Windows.Forms.Button();
            this.play = new System.Windows.Forms.Button();
            this.GameMode = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.animateTimer = new System.Windows.Forms.Timer(this.components);
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.destinationPole)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.noDisks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.PowderBlue;
            this.panel.Controls.Add(this.button2);
            this.panel.Controls.Add(this.label3);
            this.panel.Controls.Add(this.trackBar1);
            this.panel.Controls.Add(this.label2);
            this.panel.Controls.Add(this.label1);
            this.panel.Controls.Add(this.StepsNote);
            this.panel.Controls.Add(this.destinationPole);
            this.panel.Controls.Add(this.pictureBox3);
            this.panel.Controls.Add(this.pictureBox2);
            this.panel.Controls.Add(this.noDisks);
            this.panel.Controls.Add(this.reset);
            this.panel.Controls.Add(this.play);
            this.panel.Controls.Add(this.GameMode);
            this.panel.Controls.Add(this.pictureBox1);
            this.panel.Location = new System.Drawing.Point(-3, 0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(997, 406);
            this.panel.TabIndex = 11;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(759, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 27);
            this.button2.TabIndex = 114;
            this.button2.Text = "Exit";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label3.Location = new System.Drawing.Point(544, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 21);
            this.label3.TabIndex = 113;
            this.label3.Text = "Speed";
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(607, 12);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(104, 45);
            this.trackBar1.TabIndex = 112;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Light", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(447, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 28);
            this.label2.TabIndex = 111;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(352, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 28);
            this.label1.TabIndex = 110;
            this.label1.Text = "Moves : ";
            // 
            // StepsNote
            // 
            this.StepsNote.Dock = System.Windows.Forms.DockStyle.Right;
            this.StepsNote.Location = new System.Drawing.Point(843, 0);
            this.StepsNote.Name = "StepsNote";
            this.StepsNote.Size = new System.Drawing.Size(154, 406);
            this.StepsNote.TabIndex = 109;
            this.StepsNote.Text = "";
            // 
            // destinationPole
            // 
            this.destinationPole.Image = ((System.Drawing.Image)(resources.GetObject("destinationPole.Image")));
            this.destinationPole.Location = new System.Drawing.Point(696, 143);
            this.destinationPole.Name = "destinationPole";
            this.destinationPole.Size = new System.Drawing.Size(15, 217);
            this.destinationPole.TabIndex = 99;
            this.destinationPole.TabStop = false;
            this.destinationPole.Click += new System.EventHandler(this.destinationPole_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(425, 143);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(16, 217);
            this.pictureBox3.TabIndex = 98;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(163, 143);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(16, 217);
            this.pictureBox2.TabIndex = 97;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // noDisks
            // 
            this.noDisks.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.noDisks.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noDisks.Location = new System.Drawing.Point(12, 5);
            this.noDisks.Name = "noDisks";
            this.noDisks.Size = new System.Drawing.Size(56, 27);
            this.noDisks.TabIndex = 96;
            this.noDisks.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.noDisks.ValueChanged += new System.EventHandler(this.disks_ValueChanged_1);
            // 
            // reset
            // 
            this.reset.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.reset.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reset.Location = new System.Drawing.Point(304, 3);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(75, 27);
            this.reset.TabIndex = 95;
            this.reset.Text = "Reset";
            this.reset.UseVisualStyleBackColor = false;
            this.reset.Click += new System.EventHandler(this.reset_Click_1);
            // 
            // play
            // 
            this.play.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.play.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.play.Location = new System.Drawing.Point(203, 3);
            this.play.Name = "play";
            this.play.Size = new System.Drawing.Size(75, 27);
            this.play.TabIndex = 94;
            this.play.Text = "Play";
            this.play.UseVisualStyleBackColor = false;
            this.play.Click += new System.EventHandler(this.play_Click_1);
            // 
            // GameMode
            // 
            this.GameMode.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.GameMode.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GameMode.FormattingEnabled = true;
            this.GameMode.Items.AddRange(new object[] {
            "Play",
            "Simulation"});
            this.GameMode.Location = new System.Drawing.Point(74, 3);
            this.GameMode.Name = "GameMode";
            this.GameMode.Size = new System.Drawing.Size(123, 28);
            this.GameMode.TabIndex = 93;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 361);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(822, 20);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 92;
            this.pictureBox1.TabStop = false;
            // 
            // animateTimer
            // 
            this.animateTimer.Interval = 300;
            this.animateTimer.Tick += new System.EventHandler(this.animateTimer_Tick);
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 406);
            this.Controls.Add(this.panel);
            this.MaximizeBox = false;
            this.Name = "GameForm";
            this.Text = "Tower Of Hanoi";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.destinationPole)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.noDisks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.RichTextBox StepsNote;
        private System.Windows.Forms.PictureBox destinationPole;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.NumericUpDown noDisks;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.Button play;
        private System.Windows.Forms.ComboBox GameMode;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer animateTimer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar trackBar1;


    }
}

