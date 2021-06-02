using System.Drawing;

namespace MonitorApp
{
    partial class MainWindow
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
            this.box1 = new System.Windows.Forms.PictureBox();
            this.box2 = new System.Windows.Forms.PictureBox();
            this.box3 = new System.Windows.Forms.PictureBox();
            this.box4 = new System.Windows.Forms.PictureBox();
            this.box5 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.box1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.box2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.box3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.box4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.box5)).BeginInit();
            this.SuspendLayout();
            // 
            // box1
            // 
            this.box1.BackColor = System.Drawing.Color.Gray;
            this.box1.Location = new System.Drawing.Point(233, 62);
            this.box1.Name = "box1";
            this.box1.Size = new System.Drawing.Size(50, 30);
            this.box1.TabIndex = 0;
            this.box1.TabStop = false;
            // 
            // box2
            // 
            this.box2.BackColor = System.Drawing.Color.Gray;
            this.box2.Location = new System.Drawing.Point(177, 62);
            this.box2.Name = "box2";
            this.box2.Size = new System.Drawing.Size(50, 30);
            this.box2.TabIndex = 0;
            this.box2.TabStop = false;
            // 
            // box3
            // 
            this.box3.BackColor = System.Drawing.Color.Gray;
            this.box3.Location = new System.Drawing.Point(121, 62);
            this.box3.Name = "box3";
            this.box3.Size = new System.Drawing.Size(50, 30);
            this.box3.TabIndex = 0;
            this.box3.TabStop = false;
            // 
            // box4
            // 
            this.box4.BackColor = System.Drawing.Color.Gray;
            this.box4.Location = new System.Drawing.Point(65, 62);
            this.box4.Name = "box4";
            this.box4.Size = new System.Drawing.Size(50, 30);
            this.box4.TabIndex = 0;
            this.box4.TabStop = false;
            // 
            // box5
            // 
            this.box5.BackColor = System.Drawing.Color.Gray;
            this.box5.Location = new System.Drawing.Point(9, 62);
            this.box5.Name = "box5";
            this.box5.Size = new System.Drawing.Size(50, 30);
            this.box5.TabIndex = 0;
            this.box5.TabStop = false;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 159);
            this.Controls.Add(this.box5);
            this.Controls.Add(this.box4);
            this.Controls.Add(this.box3);
            this.Controls.Add(this.box2);
            this.Controls.Add(this.box1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Queue Application Monitor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_FormClosing);
            this.Shown += new System.EventHandler(this.MainWindow_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.box1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.box2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.box3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.box4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.box5)).EndInit();
            this.ResumeLayout(false);

        }


        #endregion

        private System.Windows.Forms.PictureBox box1;
        private System.Windows.Forms.PictureBox box2;
        private System.Windows.Forms.PictureBox box3;
        private System.Windows.Forms.PictureBox box4;
        private System.Windows.Forms.PictureBox box5;
    }
}

