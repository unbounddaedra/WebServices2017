namespace InClass3
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
            this.lblVersionNumDisplay = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblVersionDateDisplay = new System.Windows.Forms.Label();
            this.lblVersionNum = new System.Windows.Forms.Label();
            this.lblVersionDate = new System.Windows.Forms.Label();
            this.btnContactInfo = new System.Windows.Forms.Button();
            this.txtDisplay = new System.Windows.Forms.TextBox();
            this.btnMale = new System.Windows.Forms.Button();
            this.btnSearchLastName = new System.Windows.Forms.Button();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblVersionNumDisplay
            // 
            this.lblVersionNumDisplay.AutoSize = true;
            this.lblVersionNumDisplay.Location = new System.Drawing.Point(9, 9);
            this.lblVersionNumDisplay.Name = "lblVersionNumDisplay";
            this.lblVersionNumDisplay.Size = new System.Drawing.Size(85, 13);
            this.lblVersionNumDisplay.TabIndex = 0;
            this.lblVersionNumDisplay.Text = "Version Number:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(116, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 1;
            // 
            // lblVersionDateDisplay
            // 
            this.lblVersionDateDisplay.AutoSize = true;
            this.lblVersionDateDisplay.Location = new System.Drawing.Point(9, 31);
            this.lblVersionDateDisplay.Name = "lblVersionDateDisplay";
            this.lblVersionDateDisplay.Size = new System.Drawing.Size(71, 13);
            this.lblVersionDateDisplay.TabIndex = 4;
            this.lblVersionDateDisplay.Text = "Version Date:";
            // 
            // lblVersionNum
            // 
            this.lblVersionNum.AutoSize = true;
            this.lblVersionNum.Location = new System.Drawing.Point(94, 9);
            this.lblVersionNum.Name = "lblVersionNum";
            this.lblVersionNum.Size = new System.Drawing.Size(79, 13);
            this.lblVersionNum.TabIndex = 5;
            this.lblVersionNum.Text = "VersionNumber";
            // 
            // lblVersionDate
            // 
            this.lblVersionDate.AutoSize = true;
            this.lblVersionDate.Location = new System.Drawing.Point(86, 31);
            this.lblVersionDate.Name = "lblVersionDate";
            this.lblVersionDate.Size = new System.Drawing.Size(68, 13);
            this.lblVersionDate.TabIndex = 6;
            this.lblVersionDate.Text = "Version Date";
            // 
            // btnContactInfo
            // 
            this.btnContactInfo.Location = new System.Drawing.Point(13, 58);
            this.btnContactInfo.Name = "btnContactInfo";
            this.btnContactInfo.Size = new System.Drawing.Size(75, 23);
            this.btnContactInfo.TabIndex = 8;
            this.btnContactInfo.Text = "Contact Info";
            this.btnContactInfo.UseVisualStyleBackColor = true;
            this.btnContactInfo.Click += new System.EventHandler(this.btnContactInfo_Click);
            // 
            // txtDisplay
            // 
            this.txtDisplay.Location = new System.Drawing.Point(12, 88);
            this.txtDisplay.Multiline = true;
            this.txtDisplay.Name = "txtDisplay";
            this.txtDisplay.ReadOnly = true;
            this.txtDisplay.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDisplay.Size = new System.Drawing.Size(183, 165);
            this.txtDisplay.TabIndex = 11;
            // 
            // btnMale
            // 
            this.btnMale.Location = new System.Drawing.Point(94, 58);
            this.btnMale.Name = "btnMale";
            this.btnMale.Size = new System.Drawing.Size(75, 23);
            this.btnMale.TabIndex = 12;
            this.btnMale.Text = "Male Info";
            this.btnMale.UseVisualStyleBackColor = true;
            this.btnMale.Click += new System.EventHandler(this.btnMale_Click);
            // 
            // btnSearchLastName
            // 
            this.btnSearchLastName.Location = new System.Drawing.Point(175, 59);
            this.btnSearchLastName.Name = "btnSearchLastName";
            this.btnSearchLastName.Size = new System.Drawing.Size(119, 23);
            this.btnSearchLastName.TabIndex = 13;
            this.btnSearchLastName.Text = "Search Last Name:";
            this.btnSearchLastName.UseVisualStyleBackColor = true;
            this.btnSearchLastName.Click += new System.EventHandler(this.btnSearchLastName_Click);
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(301, 61);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(100, 20);
            this.txtLastName.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 299);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.btnSearchLastName);
            this.Controls.Add(this.btnMale);
            this.Controls.Add(this.txtDisplay);
            this.Controls.Add(this.btnContactInfo);
            this.Controls.Add(this.lblVersionDate);
            this.Controls.Add(this.lblVersionNum);
            this.Controls.Add(this.lblVersionDateDisplay);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblVersionNumDisplay);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblVersionNumDisplay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblVersionDateDisplay;
        private System.Windows.Forms.Label lblVersionNum;
        private System.Windows.Forms.Label lblVersionDate;
        private System.Windows.Forms.Button btnContactInfo;
        private System.Windows.Forms.TextBox txtDisplay;
        private System.Windows.Forms.Button btnMale;
        private System.Windows.Forms.Button btnSearchLastName;
        private System.Windows.Forms.TextBox txtLastName;
    }
}

