namespace flood_it
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
            this.btnStart = new System.Windows.Forms.Button();
            this.PBoxRed = new System.Windows.Forms.PictureBox();
            this.PBoxWhite = new System.Windows.Forms.PictureBox();
            this.PBoxBlack = new System.Windows.Forms.PictureBox();
            this.PBoxGray = new System.Windows.Forms.PictureBox();
            this.PBoxOrange = new System.Windows.Forms.PictureBox();
            this.PBoxYellow = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PBoxRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBoxWhite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBoxBlack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBoxGray)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBoxOrange)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBoxYellow)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnStart.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnStart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnStart.Location = new System.Drawing.Point(202, 3);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 32);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "START";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // PBoxRed
            // 
            this.PBoxRed.BackColor = System.Drawing.Color.Red;
            this.PBoxRed.Location = new System.Drawing.Point(5, 425);
            this.PBoxRed.Name = "PBoxRed";
            this.PBoxRed.Size = new System.Drawing.Size(73, 65);
            this.PBoxRed.TabIndex = 1;
            this.PBoxRed.TabStop = false;
            this.PBoxRed.Tag = "red";
            this.PBoxRed.Click += new System.EventHandler(this.PBox_Click);
            // 
            // PBoxWhite
            // 
            this.PBoxWhite.BackColor = System.Drawing.Color.White;
            this.PBoxWhite.Location = new System.Drawing.Point(84, 425);
            this.PBoxWhite.Name = "PBoxWhite";
            this.PBoxWhite.Size = new System.Drawing.Size(73, 65);
            this.PBoxWhite.TabIndex = 2;
            this.PBoxWhite.TabStop = false;
            this.PBoxWhite.Tag = "white";
            this.PBoxWhite.Click += new System.EventHandler(this.PBox_Click);
            // 
            // PBoxBlack
            // 
            this.PBoxBlack.BackColor = System.Drawing.Color.Black;
            this.PBoxBlack.Location = new System.Drawing.Point(163, 425);
            this.PBoxBlack.Name = "PBoxBlack";
            this.PBoxBlack.Size = new System.Drawing.Size(73, 65);
            this.PBoxBlack.TabIndex = 3;
            this.PBoxBlack.TabStop = false;
            this.PBoxBlack.Tag = "black";
            this.PBoxBlack.Click += new System.EventHandler(this.PBox_Click);
            // 
            // PBoxGray
            // 
            this.PBoxGray.BackColor = System.Drawing.Color.Gray;
            this.PBoxGray.Location = new System.Drawing.Point(242, 425);
            this.PBoxGray.Name = "PBoxGray";
            this.PBoxGray.Size = new System.Drawing.Size(73, 65);
            this.PBoxGray.TabIndex = 4;
            this.PBoxGray.TabStop = false;
            this.PBoxGray.Tag = "gray";
            this.PBoxGray.Click += new System.EventHandler(this.PBox_Click);
            // 
            // PBoxOrange
            // 
            this.PBoxOrange.BackColor = System.Drawing.Color.Orange;
            this.PBoxOrange.Location = new System.Drawing.Point(321, 425);
            this.PBoxOrange.Name = "PBoxOrange";
            this.PBoxOrange.Size = new System.Drawing.Size(73, 65);
            this.PBoxOrange.TabIndex = 5;
            this.PBoxOrange.TabStop = false;
            this.PBoxOrange.Tag = "orange";
            this.PBoxOrange.Click += new System.EventHandler(this.PBox_Click);
            // 
            // PBoxYellow
            // 
            this.PBoxYellow.BackColor = System.Drawing.Color.Yellow;
            this.PBoxYellow.Location = new System.Drawing.Point(400, 425);
            this.PBoxYellow.Name = "PBoxYellow";
            this.PBoxYellow.Size = new System.Drawing.Size(73, 65);
            this.PBoxYellow.TabIndex = 6;
            this.PBoxYellow.TabStop = false;
            this.PBoxYellow.Tag = "yellow";
            this.PBoxYellow.Click += new System.EventHandler(this.PBox_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(416, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "0/24";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Turquoise;
            this.ClientSize = new System.Drawing.Size(478, 502);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PBoxYellow);
            this.Controls.Add(this.PBoxOrange);
            this.Controls.Add(this.PBoxGray);
            this.Controls.Add(this.PBoxBlack);
            this.Controls.Add(this.PBoxWhite);
            this.Controls.Add(this.PBoxRed);
            this.Controls.Add(this.btnStart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Flood It";
            ((System.ComponentModel.ISupportInitialize)(this.PBoxRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBoxWhite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBoxBlack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBoxGray)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBoxOrange)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBoxYellow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.PictureBox PBoxRed;
        private System.Windows.Forms.PictureBox PBoxWhite;
        private System.Windows.Forms.PictureBox PBoxBlack;
        private System.Windows.Forms.PictureBox PBoxGray;
        private System.Windows.Forms.PictureBox PBoxOrange;
        private System.Windows.Forms.PictureBox PBoxYellow;
        private System.Windows.Forms.Label label1;

    }
}

