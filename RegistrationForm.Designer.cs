namespace CourseProject
{
    partial class RegistrationForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.saveUserButton = new System.Windows.Forms.Button();
            this.regLoginTextBox = new System.Windows.Forms.TextBox();
            this.regPasswordTextBox = new System.Windows.Forms.TextBox();
            this.regFioTextBox = new System.Windows.Forms.TextBox();
            this.regGroupTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(203, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите свои данные";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Логин";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Пароль";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ф.И.О.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Группа";
            // 
            // saveUserButton
            // 
            this.saveUserButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.saveUserButton.Location = new System.Drawing.Point(442, 281);
            this.saveUserButton.Name = "saveUserButton";
            this.saveUserButton.Size = new System.Drawing.Size(75, 23);
            this.saveUserButton.TabIndex = 5;
            this.saveUserButton.Text = "Сохранить";
            this.saveUserButton.UseVisualStyleBackColor = true;
            this.saveUserButton.Click += new System.EventHandler(this.saveUserButton_Click);
            // 
            // regLoginTextBox
            // 
            this.regLoginTextBox.Location = new System.Drawing.Point(103, 72);
            this.regLoginTextBox.Name = "regLoginTextBox";
            this.regLoginTextBox.Size = new System.Drawing.Size(326, 22);
            this.regLoginTextBox.TabIndex = 6;
            // 
            // regPasswordTextBox
            // 
            this.regPasswordTextBox.Location = new System.Drawing.Point(103, 111);
            this.regPasswordTextBox.Name = "regPasswordTextBox";
            this.regPasswordTextBox.Size = new System.Drawing.Size(326, 22);
            this.regPasswordTextBox.TabIndex = 7;
            // 
            // regFioTextBox
            // 
            this.regFioTextBox.Location = new System.Drawing.Point(103, 149);
            this.regFioTextBox.Name = "regFioTextBox";
            this.regFioTextBox.Size = new System.Drawing.Size(326, 22);
            this.regFioTextBox.TabIndex = 8;
            // 
            // regGroupTextBox
            // 
            this.regGroupTextBox.Location = new System.Drawing.Point(103, 187);
            this.regGroupTextBox.Name = "regGroupTextBox";
            this.regGroupTextBox.Size = new System.Drawing.Size(326, 22);
            this.regGroupTextBox.TabIndex = 9;
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 316);
            this.Controls.Add(this.regGroupTextBox);
            this.Controls.Add(this.regFioTextBox);
            this.Controls.Add(this.regPasswordTextBox);
            this.Controls.Add(this.regLoginTextBox);
            this.Controls.Add(this.saveUserButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "RegistrationForm";
            this.Text = "RegistrationForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button saveUserButton;
        private System.Windows.Forms.TextBox regLoginTextBox;
        private System.Windows.Forms.TextBox regPasswordTextBox;
        private System.Windows.Forms.TextBox regFioTextBox;
        private System.Windows.Forms.TextBox regGroupTextBox;
    }
}