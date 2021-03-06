using Microsoft.Toolkit.Forms.UI.Controls;

namespace DStrm
{
    partial class DStrm
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
            this.debugInstructionsLabel = new System.Windows.Forms.Label();
            this.Shuffle = new System.Windows.Forms.Button();
            this.webBrowser1 = new WebViewCompatible();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // debugInstructionsLabel
            // 
            this.debugInstructionsLabel.AutoSize = true;
            this.debugInstructionsLabel.Location = new System.Drawing.Point(11, 24);
            this.debugInstructionsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.debugInstructionsLabel.Name = "debugInstructionsLabel";
            this.debugInstructionsLabel.Size = new System.Drawing.Size(16, 13);
            this.debugInstructionsLabel.TabIndex = 1;
            this.debugInstructionsLabel.Text = "...";
            this.debugInstructionsLabel.Click += new System.EventHandler(this.debugInstructionsLabel_Click);
            // 
            // Shuffle
            // 
            this.Shuffle.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Shuffle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Shuffle.Location = new System.Drawing.Point(9, 107);
            this.Shuffle.Margin = new System.Windows.Forms.Padding(0);
            this.Shuffle.Name = "Shuffle";
            this.Shuffle.Size = new System.Drawing.Size(93, 40);
            this.Shuffle.TabIndex = 2;
            this.Shuffle.Text = "Random";
            this.Shuffle.UseVisualStyleBackColor = false;
            this.Shuffle.Click += new System.EventHandler(this.Shuffle_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(9, 164);
            this.webBrowser1.Margin = new System.Windows.Forms.Padding(2);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(15, 16);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(356, 66);
            this.webBrowser1.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.button1.Location = new System.Drawing.Point(262, 107);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 40);
            this.button1.TabIndex = 4;
            this.button1.Text = "PLAY | PAUSE";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.retry_Click);
            // 
            // DStrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 241);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.Shuffle);
            this.Controls.Add(this.debugInstructionsLabel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "DStrm";
            this.Text = "DStrm";
            this.Load += new System.EventHandler(this.DStrm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label debugInstructionsLabel;
        private System.Windows.Forms.Button Shuffle;
        private WebView2 webBrowser1;
        private System.Windows.Forms.Button button1;
    }
}

