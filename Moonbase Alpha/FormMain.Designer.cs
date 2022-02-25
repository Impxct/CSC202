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
            this.groupBoxAreaInformation = new System.Windows.Forms.GroupBox();
            this.textBoxAreaDescription = new System.Windows.Forms.TextBox();
            this.textBoxAreaName = new System.Windows.Forms.TextBox();
            this.labelDesription = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.groupBoxNav = new System.Windows.Forms.GroupBox();
            this.buttonEast = new System.Windows.Forms.Button();
            this.buttonWest = new System.Windows.Forms.Button();
            this.buttonSouth = new System.Windows.Forms.Button();
            this.buttonNorth = new System.Windows.Forms.Button();
            this.groupBoxAreaInformation.SuspendLayout();
            this.groupBoxNav.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxAreaInformation
            // 
            this.groupBoxAreaInformation.Controls.Add(this.textBoxAreaDescription);
            this.groupBoxAreaInformation.Controls.Add(this.textBoxAreaName);
            this.groupBoxAreaInformation.Controls.Add(this.labelDesription);
            this.groupBoxAreaInformation.Controls.Add(this.labelName);
            this.groupBoxAreaInformation.Location = new System.Drawing.Point(738, 12);
            this.groupBoxAreaInformation.Name = "groupBoxAreaInformation";
            this.groupBoxAreaInformation.Size = new System.Drawing.Size(343, 353);
            this.groupBoxAreaInformation.TabIndex = 0;
            this.groupBoxAreaInformation.TabStop = false;
            this.groupBoxAreaInformation.Text = "Area Information";
            // 
            // textBoxAreaDescription
            // 
            this.textBoxAreaDescription.Location = new System.Drawing.Point(6, 149);
            this.textBoxAreaDescription.Multiline = true;
            this.textBoxAreaDescription.Name = "textBoxAreaDescription";
            this.textBoxAreaDescription.Size = new System.Drawing.Size(263, 134);
            this.textBoxAreaDescription.TabIndex = 4;
            // 
            // textBoxAreaName
            // 
            this.textBoxAreaName.Location = new System.Drawing.Point(6, 44);
            this.textBoxAreaName.Name = "textBoxAreaName";
            this.textBoxAreaName.ReadOnly = true;
            this.textBoxAreaName.Size = new System.Drawing.Size(263, 20);
            this.textBoxAreaName.TabIndex = 3;
            // 
            // labelDesription
            // 
            this.labelDesription.AutoSize = true;
            this.labelDesription.Location = new System.Drawing.Point(6, 133);
            this.labelDesription.Name = "labelDesription";
            this.labelDesription.Size = new System.Drawing.Size(85, 13);
            this.labelDesription.TabIndex = 2;
            this.labelDesription.Text = "Area Description";
            this.labelDesription.Click += new System.EventHandler(this.labelDesription_Click);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(6, 28);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(60, 13);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "Area Name";
            // 
            // groupBoxNav
            // 
            this.groupBoxNav.Controls.Add(this.buttonEast);
            this.groupBoxNav.Controls.Add(this.buttonWest);
            this.groupBoxNav.Controls.Add(this.buttonSouth);
            this.groupBoxNav.Controls.Add(this.buttonNorth);
            this.groupBoxNav.Location = new System.Drawing.Point(747, 371);
            this.groupBoxNav.Name = "groupBoxNav";
            this.groupBoxNav.Size = new System.Drawing.Size(315, 211);
            this.groupBoxNav.TabIndex = 1;
            this.groupBoxNav.TabStop = false;
            this.groupBoxNav.Text = "Navigation System";
            // 
            // buttonEast
            // 
            this.buttonEast.Location = new System.Drawing.Point(225, 59);
            this.buttonEast.Name = "buttonEast";
            this.buttonEast.Size = new System.Drawing.Size(75, 71);
            this.buttonEast.TabIndex = 3;
            this.buttonEast.Text = "East";
            this.buttonEast.UseVisualStyleBackColor = true;
            this.buttonEast.Click += new System.EventHandler(this.buttonEast_Click);
            // 
            // buttonWest
            // 
            this.buttonWest.Location = new System.Drawing.Point(6, 59);
            this.buttonWest.Name = "buttonWest";
            this.buttonWest.Size = new System.Drawing.Size(75, 71);
            this.buttonWest.TabIndex = 2;
            this.buttonWest.Text = "West";
            this.buttonWest.UseVisualStyleBackColor = true;
            this.buttonWest.Click += new System.EventHandler(this.buttonWest_Click);
            // 
            // buttonSouth
            // 
            this.buttonSouth.Location = new System.Drawing.Point(114, 141);
            this.buttonSouth.Name = "buttonSouth";
            this.buttonSouth.Size = new System.Drawing.Size(86, 54);
            this.buttonSouth.TabIndex = 1;
            this.buttonSouth.Text = "South";
            this.buttonSouth.UseVisualStyleBackColor = true;
            this.buttonSouth.Click += new System.EventHandler(this.buttonSouth_Click);
            // 
            // buttonNorth
            // 
            this.buttonNorth.Location = new System.Drawing.Point(114, 19);
            this.buttonNorth.Name = "buttonNorth";
            this.buttonNorth.Size = new System.Drawing.Size(86, 55);
            this.buttonNorth.TabIndex = 0;
            this.buttonNorth.Text = "North";
            this.buttonNorth.UseVisualStyleBackColor = true;
            this.buttonNorth.Click += new System.EventHandler(this.buttonNorth_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Moonbase_Alpha.Properties.Resources.moonbasept2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1093, 594);
            this.Controls.Add(this.groupBoxNav);
            this.Controls.Add(this.groupBoxAreaInformation);
            this.Name = "FormMain";
            this.Text = "Moonbase Alpha";
            this.groupBoxAreaInformation.ResumeLayout(false);
            this.groupBoxAreaInformation.PerformLayout();
            this.groupBoxNav.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxAreaInformation;
        private System.Windows.Forms.Label labelDesription;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxAreaDescription;
        private System.Windows.Forms.TextBox textBoxAreaName;
        private System.Windows.Forms.GroupBox groupBoxNav;
        private System.Windows.Forms.Button buttonEast;
        private System.Windows.Forms.Button buttonWest;
        private System.Windows.Forms.Button buttonSouth;
        private System.Windows.Forms.Button buttonNorth;
    }
}