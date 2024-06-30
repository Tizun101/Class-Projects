namespace WorkshopApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

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
            this.WorkshopListBox = new System.Windows.Forms.ListBox();
            this.LocationListbox = new System.Windows.Forms.ListBox();
            this.WorkshopLabel = new System.Windows.Forms.Label();
            this.LocationLabel = new System.Windows.Forms.Label();
            this.CalcButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.RegCostOutputLabel = new System.Windows.Forms.Label();
            this.LodCostOutputLabel = new System.Windows.Forms.Label();
            this.TotalCostOutputLabel = new System.Windows.Forms.Label();
            this.ProgrammerLabel = new System.Windows.Forms.Label();
            this.RegCostLabel = new System.Windows.Forms.Label();
            this.LodCostLabel = new System.Windows.Forms.Label();
            this.TotalCostLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // WorkshopListBox
            // 
            this.WorkshopListBox.FormattingEnabled = true;
            this.WorkshopListBox.Items.AddRange(new object[] {
            "Handling Stress",
            "Time Management ",
            "Supervision Skills ",
            "Negotiation",
            "How to Interview "});
            this.WorkshopListBox.Location = new System.Drawing.Point(28, 50);
            this.WorkshopListBox.Name = "WorkshopListBox";
            this.WorkshopListBox.Size = new System.Drawing.Size(120, 95);
            this.WorkshopListBox.TabIndex = 0;
            // 
            // LocationListbox
            // 
            this.LocationListbox.FormattingEnabled = true;
            this.LocationListbox.Items.AddRange(new object[] {
            "Galway",
            "Dublin",
            "Limerick ",
            "Cork",
            "Athlone ",
            "Ennis "});
            this.LocationListbox.Location = new System.Drawing.Point(180, 50);
            this.LocationListbox.Name = "LocationListbox";
            this.LocationListbox.Size = new System.Drawing.Size(120, 95);
            this.LocationListbox.TabIndex = 1;
            // 
            // WorkshopLabel
            // 
            this.WorkshopLabel.AutoSize = true;
            this.WorkshopLabel.Location = new System.Drawing.Point(28, 31);
            this.WorkshopLabel.Name = "WorkshopLabel";
            this.WorkshopLabel.Size = new System.Drawing.Size(122, 13);
            this.WorkshopLabel.TabIndex = 2;
            this.WorkshopLabel.Text = "Please select Workshop";
            // 
            // LocationLabel
            // 
            this.LocationLabel.AutoSize = true;
            this.LocationLabel.Location = new System.Drawing.Point(180, 30);
            this.LocationLabel.Name = "LocationLabel";
            this.LocationLabel.Size = new System.Drawing.Size(110, 13);
            this.LocationLabel.TabIndex = 3;
            this.LocationLabel.Text = "Please select location";
            // 
            // CalcButton
            // 
            this.CalcButton.Location = new System.Drawing.Point(353, 50);
            this.CalcButton.Name = "CalcButton";
            this.CalcButton.Size = new System.Drawing.Size(75, 23);
            this.CalcButton.TabIndex = 4;
            this.CalcButton.Text = "Calculate";
            this.CalcButton.UseVisualStyleBackColor = true;
            this.CalcButton.Click += new System.EventHandler(this.CalcButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(353, 97);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(75, 23);
            this.ClearButton.TabIndex = 5;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(353, 144);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(75, 23);
            this.ExitButton.TabIndex = 6;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // RegCostOutputLabel
            // 
            this.RegCostOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RegCostOutputLabel.Location = new System.Drawing.Point(25, 231);
            this.RegCostOutputLabel.Name = "RegCostOutputLabel";
            this.RegCostOutputLabel.Size = new System.Drawing.Size(100, 23);
            this.RegCostOutputLabel.TabIndex = 7;
            // 
            // LodCostOutputLabel
            // 
            this.LodCostOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LodCostOutputLabel.Location = new System.Drawing.Point(142, 231);
            this.LodCostOutputLabel.Name = "LodCostOutputLabel";
            this.LodCostOutputLabel.Size = new System.Drawing.Size(100, 23);
            this.LodCostOutputLabel.TabIndex = 8;
            // 
            // TotalCostOutputLabel
            // 
            this.TotalCostOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TotalCostOutputLabel.Location = new System.Drawing.Point(259, 231);
            this.TotalCostOutputLabel.Name = "TotalCostOutputLabel";
            this.TotalCostOutputLabel.Size = new System.Drawing.Size(100, 23);
            this.TotalCostOutputLabel.TabIndex = 9;
            // 
            // ProgrammerLabel
            // 
            this.ProgrammerLabel.AutoSize = true;
            this.ProgrammerLabel.Location = new System.Drawing.Point(335, 281);
            this.ProgrammerLabel.Name = "ProgrammerLabel";
            this.ProgrammerLabel.Size = new System.Drawing.Size(165, 13);
            this.ProgrammerLabel.TabIndex = 10;
            this.ProgrammerLabel.Text = "Programmed by Merlin Bierekofen";
            // 
            // RegCostLabel
            // 
            this.RegCostLabel.AutoSize = true;
            this.RegCostLabel.Location = new System.Drawing.Point(22, 206);
            this.RegCostLabel.Name = "RegCostLabel";
            this.RegCostLabel.Size = new System.Drawing.Size(87, 13);
            this.RegCostLabel.TabIndex = 11;
            this.RegCostLabel.Text = "Registration Cost";
            // 
            // LodCostLabel
            // 
            this.LodCostLabel.AutoSize = true;
            this.LodCostLabel.Location = new System.Drawing.Point(139, 206);
            this.LodCostLabel.Name = "LodCostLabel";
            this.LodCostLabel.Size = new System.Drawing.Size(69, 13);
            this.LodCostLabel.TabIndex = 12;
            this.LodCostLabel.Text = "Lodging Cost";
            // 
            // TotalCostLabel
            // 
            this.TotalCostLabel.AutoSize = true;
            this.TotalCostLabel.Location = new System.Drawing.Point(256, 206);
            this.TotalCostLabel.Name = "TotalCostLabel";
            this.TotalCostLabel.Size = new System.Drawing.Size(60, 13);
            this.TotalCostLabel.TabIndex = 13;
            this.TotalCostLabel.Text = "Total Costs";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 303);
            this.Controls.Add(this.TotalCostLabel);
            this.Controls.Add(this.LodCostLabel);
            this.Controls.Add(this.RegCostLabel);
            this.Controls.Add(this.ProgrammerLabel);
            this.Controls.Add(this.TotalCostOutputLabel);
            this.Controls.Add(this.LodCostOutputLabel);
            this.Controls.Add(this.RegCostOutputLabel);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.CalcButton);
            this.Controls.Add(this.LocationLabel);
            this.Controls.Add(this.WorkshopLabel);
            this.Controls.Add(this.LocationListbox);
            this.Controls.Add(this.WorkshopListBox);
            this.Name = "Form1";
            this.Text = "Workshop Booking";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox WorkshopListBox;
        private System.Windows.Forms.ListBox LocationListbox;
        private System.Windows.Forms.Label WorkshopLabel;
        private System.Windows.Forms.Label LocationLabel;
        private System.Windows.Forms.Button CalcButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Label RegCostOutputLabel;
        private System.Windows.Forms.Label LodCostOutputLabel;
        private System.Windows.Forms.Label TotalCostOutputLabel;
        private System.Windows.Forms.Label ProgrammerLabel;
        private System.Windows.Forms.Label RegCostLabel;
        private System.Windows.Forms.Label LodCostLabel;
        private System.Windows.Forms.Label TotalCostLabel;
    }
}

