﻿
namespace win_test
{
    partial class Form2
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
            this.SuspendLayout();
            // 
            // Form2
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Name = "Form2";
            this.Load += new System.EventHandler(this.ScreenBody_Load);
            this.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ScreenBody_MouseDoubleClick);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ScreenBody_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ScreenBody_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ScreenBody_MouseUp);
            this.ResumeLayout(false);

        }

        #endregion
    }
}