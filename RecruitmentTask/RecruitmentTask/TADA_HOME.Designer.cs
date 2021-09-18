namespace RecruitmentTask
{
    partial class TADA_HOME
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
            this.btnTADA = new System.Windows.Forms.Button();
            this.btnHistory = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTADA
            // 
            this.btnTADA.Location = new System.Drawing.Point(68, 83);
            this.btnTADA.Name = "btnTADA";
            this.btnTADA.Size = new System.Drawing.Size(107, 23);
            this.btnTADA.TabIndex = 0;
            this.btnTADA.Text = "TADA ENTRY";
            this.btnTADA.UseVisualStyleBackColor = true;
            this.btnTADA.Click += new System.EventHandler(this.btnTADA_Click);
            // 
            // btnHistory
            // 
            this.btnHistory.Location = new System.Drawing.Point(218, 83);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnHistory.Size = new System.Drawing.Size(107, 23);
            this.btnHistory.TabIndex = 1;
            this.btnHistory.Text = "TADA HISTORY";
            this.btnHistory.UseVisualStyleBackColor = true;
            this.btnHistory.Click += new System.EventHandler(this.btnHistory_Click);
            // 
            // TADA_HOME
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 346);
            this.Controls.Add(this.btnHistory);
            this.Controls.Add(this.btnTADA);
            this.Name = "TADA_HOME";
            this.Text = "TADA";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTADA;
        private System.Windows.Forms.Button btnHistory;
    }
}

