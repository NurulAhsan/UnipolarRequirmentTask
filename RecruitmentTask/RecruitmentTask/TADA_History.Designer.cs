namespace RecruitmentTask
{
    partial class TADA_History
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
            this.label1 = new System.Windows.Forms.Label();
            this.Backbtn = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.DatecolumnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NamecolumnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TVCcolumnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LCcolumnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ICcolumnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TotalCcolumnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PaidcolumnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(323, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "TADA HISTORY";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Backbtn
            // 
            this.Backbtn.Location = new System.Drawing.Point(841, 462);
            this.Backbtn.Name = "Backbtn";
            this.Backbtn.Size = new System.Drawing.Size(75, 23);
            this.Backbtn.TabIndex = 1;
            this.Backbtn.Text = "BACK";
            this.Backbtn.UseVisualStyleBackColor = true;
            this.Backbtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // listView1
            // 
            this.listView1.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listView1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.DatecolumnHeader1,
            this.NamecolumnHeader2,
            this.TVCcolumnHeader3,
            this.LCcolumnHeader4,
            this.ICcolumnHeader5,
            this.TotalCcolumnHeader6,
            this.PaidcolumnHeader7});
            this.listView1.GridLines = true;
            this.listView1.HoverSelection = true;
            this.listView1.Location = new System.Drawing.Point(172, 86);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(502, 350);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            
            // 
            // DatecolumnHeader1
            // 
            this.DatecolumnHeader1.Text = "Date";
            this.DatecolumnHeader1.Width = 70;
            // 
            // NamecolumnHeader2
            // 
            this.NamecolumnHeader2.Text = "Name";
            this.NamecolumnHeader2.Width = 70;
            // 
            // TVCcolumnHeader3
            // 
            this.TVCcolumnHeader3.Text = "Travel Cost";
            this.TVCcolumnHeader3.Width = 70;
            // 
            // LCcolumnHeader4
            // 
            this.LCcolumnHeader4.Text = "Lunch Cost";
            this.LCcolumnHeader4.Width = 70;
            // 
            // ICcolumnHeader5
            // 
            this.ICcolumnHeader5.Text = "Instrument Cost";
            this.ICcolumnHeader5.Width = 120;
            // 
            // TotalCcolumnHeader6
            // 
            this.TotalCcolumnHeader6.Text = "Total Cost";
            // 
            // PaidcolumnHeader7
            // 
            this.PaidcolumnHeader7.Text = "Paid";
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.Location = new System.Drawing.Point(34, 86);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "SHOW HISTORY";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // TADA_History
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 497);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.Backbtn);
            this.Controls.Add(this.label1);
            this.Name = "TADA_History";
            this.Text = "TADA_History";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Backbtn;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader DatecolumnHeader1;
        private System.Windows.Forms.ColumnHeader NamecolumnHeader2;
        private System.Windows.Forms.ColumnHeader TVCcolumnHeader3;
        private System.Windows.Forms.ColumnHeader LCcolumnHeader4;
        private System.Windows.Forms.ColumnHeader ICcolumnHeader5;
        private System.Windows.Forms.ColumnHeader TotalCcolumnHeader6;
        private System.Windows.Forms.ColumnHeader PaidcolumnHeader7;
        private System.Windows.Forms.Button button1;
    }
}