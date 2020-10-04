namespace CourseProject
{
    partial class UsersControl
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.updateButton1 = new System.Windows.Forms.Button();
            this.deleteButton2 = new System.Windows.Forms.Button();
            this.addButton3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 21;
            this.listBox1.Location = new System.Drawing.Point(13, 13);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(426, 214);
            this.listBox1.TabIndex = 0;
            // 
            // updateButton1
            // 
            this.updateButton1.Location = new System.Drawing.Point(13, 280);
            this.updateButton1.Name = "updateButton1";
            this.updateButton1.Size = new System.Drawing.Size(75, 23);
            this.updateButton1.TabIndex = 1;
            this.updateButton1.Text = "Обновить";
            this.updateButton1.UseVisualStyleBackColor = true;
            this.updateButton1.Click += new System.EventHandler(this.updateButton1_Click);
            // 
            // deleteButton2
            // 
            this.deleteButton2.Location = new System.Drawing.Point(364, 280);
            this.deleteButton2.Name = "deleteButton2";
            this.deleteButton2.Size = new System.Drawing.Size(75, 23);
            this.deleteButton2.TabIndex = 2;
            this.deleteButton2.Text = "Удалить";
            this.deleteButton2.UseVisualStyleBackColor = true;
            this.deleteButton2.Click += new System.EventHandler(this.deleteButton2_Click);
            // 
            // addButton3
            // 
            this.addButton3.Location = new System.Drawing.Point(181, 280);
            this.addButton3.Name = "addButton3";
            this.addButton3.Size = new System.Drawing.Size(75, 23);
            this.addButton3.TabIndex = 3;
            this.addButton3.Text = "Добавить";
            this.addButton3.UseVisualStyleBackColor = true;
            this.addButton3.Click += new System.EventHandler(this.addButton3_Click);
            // 
            // UsersControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 315);
            this.Controls.Add(this.addButton3);
            this.Controls.Add(this.deleteButton2);
            this.Controls.Add(this.updateButton1);
            this.Controls.Add(this.listBox1);
            this.Name = "UsersControl";
            this.Text = "UsersControl";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UsersControl_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button updateButton1;
        private System.Windows.Forms.Button deleteButton2;
        private System.Windows.Forms.Button addButton3;
    }
}