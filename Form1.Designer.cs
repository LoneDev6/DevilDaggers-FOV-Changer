namespace DevilDaggers_FOV_Changer
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
            this.components = new System.ComponentModel.Container();
            this.numericUpDown_fov = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label_ddOpened = new System.Windows.Forms.Label();
            this.timer_ddRunning = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_fov)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDown_fov
            // 
            this.numericUpDown_fov.Location = new System.Drawing.Point(67, 35);
            this.numericUpDown_fov.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.numericUpDown_fov.Minimum = new decimal(new int[] {
            99999,
            0,
            0,
            -2147483648});
            this.numericUpDown_fov.Name = "numericUpDown_fov";
            this.numericUpDown_fov.Size = new System.Drawing.Size(56, 20);
            this.numericUpDown_fov.TabIndex = 0;
            this.numericUpDown_fov.ValueChanged += new System.EventHandler(this.numericUpDown_fov_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "FOV:";
            // 
            // label_ddOpened
            // 
            this.label_ddOpened.AutoSize = true;
            this.label_ddOpened.Location = new System.Drawing.Point(12, 9);
            this.label_ddOpened.Name = "label_ddOpened";
            this.label_ddOpened.Size = new System.Drawing.Size(135, 13);
            this.label_ddOpened.TabIndex = 2;
            this.label_ddOpened.Text = "DevilDaggers NOT running";
            // 
            // timer_ddRunning
            // 
            this.timer_ddRunning.Enabled = true;
            this.timer_ddRunning.Tick += new System.EventHandler(this.timer_ddRunning_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(155, 77);
            this.Controls.Add(this.label_ddOpened);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDown_fov);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.ShowIcon = false;
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_fov)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDown_fov;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_ddOpened;
        private System.Windows.Forms.Timer timer_ddRunning;
    }
}

