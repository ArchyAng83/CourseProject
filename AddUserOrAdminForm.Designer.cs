namespace CourseProject
{
    partial class AddUserOrAdminForm
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
            this.addUsersTextBox1 = new System.Windows.Forms.TextBox();
            this.adminCheckBox1 = new System.Windows.Forms.CheckBox();
            this.okButton1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addUsersTextBox1
            // 
            this.addUsersTextBox1.Location = new System.Drawing.Point(13, 13);
            this.addUsersTextBox1.Multiline = true;
            this.addUsersTextBox1.Name = "addUsersTextBox1";
            this.addUsersTextBox1.Size = new System.Drawing.Size(322, 121);
            this.addUsersTextBox1.TabIndex = 0;
            // 
            // adminCheckBox1
            // 
            this.adminCheckBox1.AutoSize = true;
            this.adminCheckBox1.Location = new System.Drawing.Point(13, 150);
            this.adminCheckBox1.Name = "adminCheckBox1";
            this.adminCheckBox1.Size = new System.Drawing.Size(110, 17);
            this.adminCheckBox1.TabIndex = 1;
            this.adminCheckBox1.Text = "Администратор";
            this.adminCheckBox1.UseVisualStyleBackColor = true;
            // 
            // okButton1
            // 
            this.okButton1.Location = new System.Drawing.Point(260, 154);
            this.okButton1.Name = "okButton1";
            this.okButton1.Size = new System.Drawing.Size(75, 23);
            this.okButton1.TabIndex = 2;
            this.okButton1.Text = "OK";
            this.okButton1.UseVisualStyleBackColor = true;
            this.okButton1.Click += new System.EventHandler(this.okButton1_Click);
            // 
            // AddUserOrAdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 189);
            this.Controls.Add(this.okButton1);
            this.Controls.Add(this.adminCheckBox1);
            this.Controls.Add(this.addUsersTextBox1);
            this.Name = "AddUserOrAdminForm";
            this.Text = "AddUserOrAdminForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox addUsersTextBox1;
        private System.Windows.Forms.CheckBox adminCheckBox1;
        private System.Windows.Forms.Button okButton1;
    }
}