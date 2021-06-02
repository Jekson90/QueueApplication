namespace ActionApp
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
            this.buttonCamera = new System.Windows.Forms.Button();
            this.buttonPush = new System.Windows.Forms.Button();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.radioUnfit = new System.Windows.Forms.RadioButton();
            this.radioFit = new System.Windows.Forms.RadioButton();
            this.buttonOpenMonitor = new System.Windows.Forms.Button();
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonCamera
            // 
            this.buttonCamera.Location = new System.Drawing.Point(12, 93);
            this.buttonCamera.Name = "buttonCamera";
            this.buttonCamera.Size = new System.Drawing.Size(270, 23);
            this.buttonCamera.TabIndex = 0;
            this.buttonCamera.Text = "Камера";
            this.buttonCamera.UseVisualStyleBackColor = true;
            this.buttonCamera.Click += new System.EventHandler(this.buttonCamera_Click);
            // 
            // buttonPush
            // 
            this.buttonPush.Location = new System.Drawing.Point(12, 122);
            this.buttonPush.Name = "buttonPush";
            this.buttonPush.Size = new System.Drawing.Size(270, 23);
            this.buttonPush.TabIndex = 1;
            this.buttonPush.Text = "Толкатель";
            this.buttonPush.UseVisualStyleBackColor = true;
            this.buttonPush.Click += new System.EventHandler(this.buttonPush_Click);
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.radioUnfit);
            this.groupBox.Controls.Add(this.radioFit);
            this.groupBox.Location = new System.Drawing.Point(12, 12);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(186, 75);
            this.groupBox.TabIndex = 2;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Пригодность";
            // 
            // radioUnfit
            // 
            this.radioUnfit.AutoSize = true;
            this.radioUnfit.Location = new System.Drawing.Point(7, 46);
            this.radioUnfit.Name = "radioUnfit";
            this.radioUnfit.Size = new System.Drawing.Size(74, 19);
            this.radioUnfit.TabIndex = 1;
            this.radioUnfit.TabStop = true;
            this.radioUnfit.Text = "Не годен";
            this.radioUnfit.UseVisualStyleBackColor = true;
            // 
            // radioFit
            // 
            this.radioFit.AutoSize = true;
            this.radioFit.Checked = true;
            this.radioFit.Location = new System.Drawing.Point(7, 23);
            this.radioFit.Name = "radioFit";
            this.radioFit.Size = new System.Drawing.Size(57, 19);
            this.radioFit.TabIndex = 0;
            this.radioFit.TabStop = true;
            this.radioFit.Text = "Годен";
            this.radioFit.UseVisualStyleBackColor = true;
            // 
            // buttonOpenMonitor
            // 
            this.buttonOpenMonitor.Location = new System.Drawing.Point(204, 12);
            this.buttonOpenMonitor.Name = "buttonOpenMonitor";
            this.buttonOpenMonitor.Size = new System.Drawing.Size(78, 75);
            this.buttonOpenMonitor.TabIndex = 3;
            this.buttonOpenMonitor.Text = "Открыть монитор";
            this.buttonOpenMonitor.UseVisualStyleBackColor = true;
            this.buttonOpenMonitor.Click += new System.EventHandler(this.buttonOpenMonitor_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 159);
            this.Controls.Add(this.buttonOpenMonitor);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.buttonPush);
            this.Controls.Add(this.buttonCamera);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Queue Application Action";
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonCamera;
        private System.Windows.Forms.Button buttonPush;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.RadioButton radioUnfit;
        private System.Windows.Forms.RadioButton radioFit;
        private System.Windows.Forms.Button buttonOpenMonitor;
    }
}

