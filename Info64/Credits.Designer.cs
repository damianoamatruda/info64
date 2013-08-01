namespace Info64
{
    partial class Credits
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Credits));
            this.CreatedBy = new System.Windows.Forms.Label();
            this.Author = new System.Windows.Forms.LinkLabel();
            this.Version = new System.Windows.Forms.Label();
            this.Contribute = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // CreatedBy
            // 
            this.CreatedBy.AutoSize = true;
            this.CreatedBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.CreatedBy.ForeColor = System.Drawing.SystemColors.WindowText;
            this.CreatedBy.Location = new System.Drawing.Point(130, 40);
            this.CreatedBy.Name = "CreatedBy";
            this.CreatedBy.Size = new System.Drawing.Size(131, 16);
            this.CreatedBy.TabIndex = 0;
            this.CreatedBy.Text = "Info64 created by:";
            this.CreatedBy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Author
            // 
            this.Author.AutoSize = true;
            this.Author.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.Author.Location = new System.Drawing.Point(65, 65);
            this.Author.Name = "Author";
            this.Author.Size = new System.Drawing.Size(256, 16);
            this.Author.TabIndex = 1;
            this.Author.TabStop = true;
            this.Author.Text = "Damiano Amatruda (aka DamiHack)";
            this.Author.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Author_LinkClicked);
            // 
            // Version
            // 
            this.Version.AutoSize = true;
            this.Version.Location = new System.Drawing.Point(344, 140);
            this.Version.Name = "Version";
            this.Version.Size = new System.Drawing.Size(28, 13);
            this.Version.TabIndex = 5;
            this.Version.Text = "v0.9";
            // 
            // Contribute
            // 
            this.Contribute.AutoSize = true;
            this.Contribute.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Contribute.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.Contribute.Location = new System.Drawing.Point(12, 137);
            this.Contribute.Name = "Contribute";
            this.Contribute.Size = new System.Drawing.Size(76, 18);
            this.Contribute.TabIndex = 6;
            this.Contribute.TabStop = true;
            this.Contribute.Text = "Contribute";
            this.Contribute.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Contribute_LinkClicked);
            // 
            // Credits
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 162);
            this.Controls.Add(this.Contribute);
            this.Controls.Add(this.Version);
            this.Controls.Add(this.Author);
            this.Controls.Add(this.CreatedBy);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Credits";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Credits";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CreatedBy;
        private System.Windows.Forms.LinkLabel Author;
        private System.Windows.Forms.Label Version;
        private System.Windows.Forms.LinkLabel Contribute;
    }
}