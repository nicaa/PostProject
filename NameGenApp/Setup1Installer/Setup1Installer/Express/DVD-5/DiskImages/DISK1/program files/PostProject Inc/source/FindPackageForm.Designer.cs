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
            this.recipientFirstNameLabel = new System.Windows.Forms.Label();
            this.recipientStreetLabel = new System.Windows.Forms.Label();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.streetTextBox = new System.Windows.Forms.TextBox();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.postalCodeTextBox = new System.Windows.Forms.TextBox();
            this.recipientCityLabel = new System.Windows.Forms.Label();
            this.recipientPostalCodeLabel = new System.Windows.Forms.Label();
            this.recipientLastNameLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(275, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            // recipientFirstNameLabel
            // 
            this.recipientFirstNameLabel.AutoSize = true;
            this.recipientFirstNameLabel.Location = new System.Drawing.Point(12, 54);
            this.recipientFirstNameLabel.Name = "recipientFirstNameLabel";
            this.recipientFirstNameLabel.Size = new System.Drawing.Size(108, 13);
            this.recipientFirstNameLabel.TabIndex = 3;
            this.recipientFirstNameLabel.Text = "Recipient First Name:";
            this.recipientFirstNameLabel.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // recipientStreetLabel
            // 
            this.recipientStreetLabel.AutoSize = true;
            this.recipientStreetLabel.Location = new System.Drawing.Point(12, 107);
            this.recipientStreetLabel.Name = "recipientStreetLabel";
            this.recipientStreetLabel.Size = new System.Drawing.Size(86, 13);
            this.recipientStreetLabel.TabIndex = 4;
            this.recipientStreetLabel.Text = "Recipient Street:";
            this.recipientStreetLabel.Click += new System.EventHandler(this.RecipientAddressLabel_Click);
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(153, 54);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(197, 20);
            this.firstNameTextBox.TabIndex = 5;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(153, 81);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(197, 20);
            this.lastNameTextBox.TabIndex = 6;
            // 
            // streetTextBox
            // 
            this.streetTextBox.Location = new System.Drawing.Point(153, 107);
            this.streetTextBox.Name = "streetTextBox";
            this.streetTextBox.Size = new System.Drawing.Size(197, 20);
            this.streetTextBox.TabIndex = 7;
            // 
            // cityTextBox
            // 
            this.cityTextBox.Location = new System.Drawing.Point(153, 135);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(197, 20);
            this.cityTextBox.TabIndex = 8;
            // 
            // postalCodeTextBox
            // 
            this.postalCodeTextBox.Location = new System.Drawing.Point(153, 161);
            this.postalCodeTextBox.Name = "postalCodeTextBox";
            this.postalCodeTextBox.Size = new System.Drawing.Size(197, 20);
            this.postalCodeTextBox.TabIndex = 9;
            // 
            // recipientCityLabel
            // 
            this.recipientCityLabel.AutoSize = true;
            this.recipientCityLabel.Location = new System.Drawing.Point(12, 135);
            this.recipientCityLabel.Name = "recipientCityLabel";
            this.recipientCityLabel.Size = new System.Drawing.Size(75, 13);
            this.recipientCityLabel.TabIndex = 10;
            this.recipientCityLabel.Text = "Recipient City:";
            // 
            // recipientPostalCodeLabel
            // 
            this.recipientPostalCodeLabel.AutoSize = true;
            this.recipientPostalCodeLabel.Location = new System.Drawing.Point(12, 161);
            this.recipientPostalCodeLabel.Name = "recipientPostalCodeLabel";
            this.recipientPostalCodeLabel.Size = new System.Drawing.Size(115, 13);
            this.recipientPostalCodeLabel.TabIndex = 11;
            this.recipientPostalCodeLabel.Text = "Recipient Postal Code:";
            // 
            // recipientLastNameLabel
            // 
            this.recipientLastNameLabel.AutoSize = true;
            this.recipientLastNameLabel.Location = new System.Drawing.Point(12, 81);
            this.recipientLastNameLabel.Name = "recipientLastNameLabel";
            this.recipientLastNameLabel.Size = new System.Drawing.Size(109, 13);
            this.recipientLastNameLabel.TabIndex = 12;
            this.recipientLastNameLabel.Text = "Recipient Last Name:";
            // 
            // FindPackageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 210);
            this.Controls.Add(this.recipientLastNameLabel);
            this.Controls.Add(this.recipientPostalCodeLabel);
            this.Controls.Add(this.recipientCityLabel);
            this.Controls.Add(this.postalCodeTextBox);
            this.Controls.Add(this.cityTextBox);
            this.Controls.Add(this.streetTextBox);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(this.recipientStreetLabel);
            this.Controls.Add(this.recipientFirstNameLabel);
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
        private System.Windows.Forms.Label recipientFirstNameLabel;
        private System.Windows.Forms.Label recipientStreetLabel;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox streetTextBox;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.TextBox postalCodeTextBox;
        private System.Windows.Forms.Label recipientCityLabel;
        private System.Windows.Forms.Label recipientPostalCodeLabel;
        private System.Windows.Forms.Label recipientLastNameLabel;
    }
}