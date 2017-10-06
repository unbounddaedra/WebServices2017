namespace Lab1pt1
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
            this.parseContactInfo = new System.Windows.Forms.Button();
            this.txtResults = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // parseContactInfo
            // 
            this.parseContactInfo.Location = new System.Drawing.Point(75, 27);
            this.parseContactInfo.Name = "parseContactInfo";
            this.parseContactInfo.Size = new System.Drawing.Size(132, 23);
            this.parseContactInfo.TabIndex = 0;
            this.parseContactInfo.Text = "Parse Contact Info";
            this.parseContactInfo.UseVisualStyleBackColor = true;
            this.parseContactInfo.Click += new System.EventHandler(this.parseContactInfo_Click);
            // 
            // txtResults
            // 
            this.txtResults.Location = new System.Drawing.Point(11, 55);
            this.txtResults.Margin = new System.Windows.Forms.Padding(2);
            this.txtResults.Multiline = true;
            this.txtResults.Name = "txtResults";
            this.txtResults.ReadOnly = true;
            this.txtResults.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtResults.Size = new System.Drawing.Size(262, 196);
            this.txtResults.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.txtResults);
            this.Controls.Add(this.parseContactInfo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button parseContactInfo;
        private System.Windows.Forms.TextBox txtResults;
    }
}

