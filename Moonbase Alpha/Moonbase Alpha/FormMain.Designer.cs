namespace Moonbase_Alpha
{
    partial class FormMain
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
            this.groupBoxLocationInformation = new System.Windows.Forms.GroupBox();
            this.LabelAreaName = new System.Windows.Forms.Label();
            this.textBoxAreaDescription = new System.Windows.Forms.TextBox();
            this.groupBoxLocationInformation.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxLocationInformation
            // 
            this.groupBoxLocationInformation.Controls.Add(this.textBoxAreaDescription);
            this.groupBoxLocationInformation.Controls.Add(this.LabelAreaName);
            this.groupBoxLocationInformation.Location = new System.Drawing.Point(282, 31);
            this.groupBoxLocationInformation.Name = "groupBoxLocationInformation";
            this.groupBoxLocationInformation.Size = new System.Drawing.Size(200, 199);
            this.groupBoxLocationInformation.TabIndex = 0;
            this.groupBoxLocationInformation.TabStop = false;
            this.groupBoxLocationInformation.Text = "Location Information";
            this.groupBoxLocationInformation.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // LabelAreaName
            // 
            this.LabelAreaName.AutoSize = true;
            this.LabelAreaName.Location = new System.Drawing.Point(6, 16);
            this.LabelAreaName.Name = "LabelAreaName";
            this.LabelAreaName.Size = new System.Drawing.Size(117, 13);
            this.LabelAreaName.TabIndex = 0;
            this.LabelAreaName.Text = "General Purpose Room";
            // 
            // textBoxAreaDescription
            // 
            this.textBoxAreaDescription.Location = new System.Drawing.Point(9, 32);
            this.textBoxAreaDescription.Multiline = true;
            this.textBoxAreaDescription.Name = "textBoxAreaDescription";
            this.textBoxAreaDescription.ReadOnly = true;
            this.textBoxAreaDescription.Size = new System.Drawing.Size(185, 161);
            this.textBoxAreaDescription.TabIndex = 1;
            this.textBoxAreaDescription.Text = "Welcome to my General Purpose Room! Here is the Radiomans desk, a dining table in" +
    " front, with a meeting and control room in the far back.";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Moonbase_Alpha.Properties.Resources.Moonbase_JPEG;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1192, 527);
            this.Controls.Add(this.groupBoxLocationInformation);
            this.Name = "FormMain";
            this.Text = "Moonbase IX";
            this.groupBoxLocationInformation.ResumeLayout(false);
            this.groupBoxLocationInformation.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxLocationInformation;
        private System.Windows.Forms.TextBox textBoxAreaDescription;
        private System.Windows.Forms.Label LabelAreaName;
    }
}