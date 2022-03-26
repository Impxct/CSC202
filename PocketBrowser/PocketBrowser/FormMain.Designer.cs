namespace PocketBrowser
{
    partial class MainBrowser
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
            this.GoButton = new System.Windows.Forms.Button();
            this.textBoxURL = new System.Windows.Forms.TextBox();
            this.webBrowserDisplay = new System.Windows.Forms.WebBrowser();
            this.buttonPlaySpace = new System.Windows.Forms.Button();
            this.buttonStopSpace = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // GoButton
            // 
            this.GoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GoButton.Location = new System.Drawing.Point(12, 0);
            this.GoButton.Name = "GoButton";
            this.GoButton.Size = new System.Drawing.Size(134, 94);
            this.GoButton.TabIndex = 0;
            this.GoButton.Text = "Go";
            this.GoButton.UseVisualStyleBackColor = true;
            this.GoButton.Click += new System.EventHandler(this.GoButton_Click);
            // 
            // textBoxURL
            // 
            this.textBoxURL.Location = new System.Drawing.Point(152, 39);
            this.textBoxURL.Name = "textBoxURL";
            this.textBoxURL.Size = new System.Drawing.Size(1672, 20);
            this.textBoxURL.TabIndex = 1;
            // 
            // webBrowserDisplay
            // 
            this.webBrowserDisplay.Location = new System.Drawing.Point(12, 100);
            this.webBrowserDisplay.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowserDisplay.Name = "webBrowserDisplay";
            this.webBrowserDisplay.Size = new System.Drawing.Size(1812, 520);
            this.webBrowserDisplay.TabIndex = 2;
            // 
            // buttonPlaySpace
            // 
            this.buttonPlaySpace.Location = new System.Drawing.Point(152, 65);
            this.buttonPlaySpace.Name = "buttonPlaySpace";
            this.buttonPlaySpace.Size = new System.Drawing.Size(75, 23);
            this.buttonPlaySpace.TabIndex = 3;
            this.buttonPlaySpace.Text = "Space";
            this.buttonPlaySpace.UseVisualStyleBackColor = true;
            this.buttonPlaySpace.Click += new System.EventHandler(this.buttonPlaySpace_Click);
            // 
            // buttonStopSpace
            // 
            this.buttonStopSpace.Location = new System.Drawing.Point(233, 65);
            this.buttonStopSpace.Name = "buttonStopSpace";
            this.buttonStopSpace.Size = new System.Drawing.Size(75, 23);
            this.buttonStopSpace.TabIndex = 4;
            this.buttonStopSpace.Text = "Stop";
            this.buttonStopSpace.UseVisualStyleBackColor = true;
            this.buttonStopSpace.Click += new System.EventHandler(this.buttonStopSpace_Click);
            // 
            // MainBrowser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PocketBrowser.Properties.Resources.space_pulsar_homepage_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1836, 632);
            this.Controls.Add(this.buttonStopSpace);
            this.Controls.Add(this.buttonPlaySpace);
            this.Controls.Add(this.webBrowserDisplay);
            this.Controls.Add(this.textBoxURL);
            this.Controls.Add(this.GoButton);
            this.Name = "MainBrowser";
            this.Text = "Browser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        private System.Windows.Forms.Button GoButton;
        private System.Windows.Forms.TextBox textBoxURL;
        private System.Windows.Forms.WebBrowser webBrowserDisplay;
        private System.Windows.Forms.Button buttonPlaySpace;
        private System.Windows.Forms.Button buttonStopSpace;
    }
} 