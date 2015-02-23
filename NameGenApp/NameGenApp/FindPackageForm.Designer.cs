namespace NameGenApp
{
    partial class FindPackageForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.PackageIdLabel = new System.Windows.Forms.Label();
            this.packageIdTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 59);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // PackageIdLabel
            // 
            this.PackageIdLabel.AutoSize = true;
            this.PackageIdLabel.Location = new System.Drawing.Point(12, 13);
            this.PackageIdLabel.Name = "PackageIdLabel";
            this.PackageIdLabel.Size = new System.Drawing.Size(67, 13);
            this.PackageIdLabel.TabIndex = 1;
            this.PackageIdLabel.Text = "Package ID:";
            this.PackageIdLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // packageIdTextBox
            // 
            this.packageIdTextBox.Location = new System.Drawing.Point(86, 13);
            this.packageIdTextBox.Name = "packageIdTextBox";
            this.packageIdTextBox.Size = new System.Drawing.Size(167, 20);
            this.packageIdTextBox.TabIndex = 2;
            this.packageIdTextBox.Text = "Please Enter PackageId";
            this.packageIdTextBox.TextChanged += new System.EventHandler(this.packageIdTextBox_TextChanged);
            // 
            // FindPackageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 375);
            this.Controls.Add(this.packageIdTextBox);
            this.Controls.Add(this.PackageIdLabel);
            this.Controls.Add(this.button1);
            this.Name = "FindPackageForm";
            this.Text = "FindPackageForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label PackageIdLabel;
        private System.Windows.Forms.TextBox packageIdTextBox;
    }
}