namespace ListDemo1
{
    partial class timeZones
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
            this.lbxCities = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTimeZone = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbxCities
            // 
            this.lbxCities.FormattingEnabled = true;
            this.lbxCities.Items.AddRange(new object[] {
            "Honolulu",
            "San Franscisco",
            "Minneapolis",
            "New York",
            "Mailman\'s House",
            "Jimmy Johns",
            "Mordor"});
            this.lbxCities.Location = new System.Drawing.Point(80, 25);
            this.lbxCities.Name = "lbxCities";
            this.lbxCities.Size = new System.Drawing.Size(120, 69);
            this.lbxCities.TabIndex = 0;
            this.lbxCities.SelectedIndexChanged += new System.EventHandler(this.lbxCities_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Time Zone:";
            // 
            // lblTimeZone
            // 
            this.lblTimeZone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTimeZone.Location = new System.Drawing.Point(80, 97);
            this.lblTimeZone.Name = "lblTimeZone";
            this.lblTimeZone.Size = new System.Drawing.Size(100, 23);
            this.lblTimeZone.TabIndex = 2;
            this.lblTimeZone.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Select a City and See the Time Zone";
            // 
            // timeZones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 140);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTimeZone);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbxCities);
            this.Name = "timeZones";
            this.Text = "Time Zones";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbxCities;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTimeZone;
        private System.Windows.Forms.Label label2;
    }
}

