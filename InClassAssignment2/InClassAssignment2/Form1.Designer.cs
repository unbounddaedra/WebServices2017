namespace InClassAssignment2
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
            this.getRevisionDate = new System.Windows.Forms.Button();
            this.getStockNames = new System.Windows.Forms.Button();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // getRevisionDate
            // 
            this.getRevisionDate.Location = new System.Drawing.Point(61, 21);
            this.getRevisionDate.Name = "getRevisionDate";
            this.getRevisionDate.Size = new System.Drawing.Size(158, 23);
            this.getRevisionDate.TabIndex = 0;
            this.getRevisionDate.Text = "Get Revision Date";
            this.getRevisionDate.UseVisualStyleBackColor = true;
            this.getRevisionDate.Click += new System.EventHandler(this.getRevisionDate_Click);
            // 
            // getStockNames
            // 
            this.getStockNames.Location = new System.Drawing.Point(61, 66);
            this.getStockNames.Name = "getStockNames";
            this.getStockNames.Size = new System.Drawing.Size(158, 23);
            this.getStockNames.TabIndex = 2;
            this.getStockNames.Text = "Get Stock Names";
            this.getStockNames.UseVisualStyleBackColor = true;
            this.getStockNames.Click += new System.EventHandler(this.getStockNames_Click);
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(69, 120);
            this.txtOutput.Margin = new System.Windows.Forms.Padding(2);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ReadOnly = true;
            this.txtOutput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtOutput.Size = new System.Drawing.Size(150, 93);
            this.txtOutput.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.getStockNames);
            this.Controls.Add(this.getRevisionDate);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button getRevisionDate;
        private System.Windows.Forms.Button getStockNames;
        private System.Windows.Forms.TextBox txtOutput;
    }
}

