namespace PostProjectClient
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
            this.findPackageBtn = new System.Windows.Forms.Button();
            this.getPackageBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // findPackageBtn
            // 
            this.findPackageBtn.Location = new System.Drawing.Point(84, 12);
            this.findPackageBtn.Name = "findPackageBtn";
            this.findPackageBtn.Size = new System.Drawing.Size(115, 23);
            this.findPackageBtn.TabIndex = 0;
            this.findPackageBtn.Text = "Find Package";
            this.findPackageBtn.UseVisualStyleBackColor = true;
            this.findPackageBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // getPackageBtn
            // 
            this.getPackageBtn.Location = new System.Drawing.Point(93, 113);
            this.getPackageBtn.Name = "getPackageBtn";
            this.getPackageBtn.Size = new System.Drawing.Size(106, 23);
            this.getPackageBtn.TabIndex = 1;
            this.getPackageBtn.Text = "Create Package";
            this.getPackageBtn.UseVisualStyleBackColor = true;
            this.getPackageBtn.Click += new System.EventHandler(this.getPackageBtn_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(49, 209);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(187, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Run City Statistics Gathering";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.getPackageBtn);
            this.Controls.Add(this.findPackageBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button findPackageBtn;
        private System.Windows.Forms.Button getPackageBtn;
        private System.Windows.Forms.Button button1;
    }
}

