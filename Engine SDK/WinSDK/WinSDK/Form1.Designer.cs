﻿namespace WinSDK
{
    partial class DevMenu
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
            this.label1 = new System.Windows.Forms.Label();
            this.DEV_Beep = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Developer Menu";
            // 
            // DEV_Beep
            // 
            this.DEV_Beep.AutoSize = true;
            this.DEV_Beep.Location = new System.Drawing.Point(13, 37);
            this.DEV_Beep.Name = "DEV_Beep";
            this.DEV_Beep.Size = new System.Drawing.Size(75, 30);
            this.DEV_Beep.TabIndex = 1;
            this.DEV_Beep.Text = "Beep";
            this.DEV_Beep.UseVisualStyleBackColor = true;
            this.DEV_Beep.Click += new System.EventHandler(this.DEV_Beep_Click);
            // 
            // DevMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DEV_Beep);
            this.Controls.Add(this.label1);
            this.Name = "DevMenu";
            this.Text = "DevMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button DEV_Beep;
    }
}