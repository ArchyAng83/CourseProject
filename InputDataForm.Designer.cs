namespace CourseProject
{
    partial class InputDataForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InputDataForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.inputTempretureTextBox = new System.Windows.Forms.TextBox();
            this.inputZoneTextBox = new System.Windows.Forms.TextBox();
            this.okInputButton = new System.Windows.Forms.Button();
            this.inputAllDatasbutton1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Температура (K):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ширина зоны (eV):";
            // 
            // inputTempretureTextBox
            // 
            this.inputTempretureTextBox.Location = new System.Drawing.Point(133, 22);
            this.inputTempretureTextBox.Name = "inputTempretureTextBox";
            this.inputTempretureTextBox.Size = new System.Drawing.Size(100, 22);
            this.inputTempretureTextBox.TabIndex = 2;
            // 
            // inputZoneTextBox
            // 
            this.inputZoneTextBox.Location = new System.Drawing.Point(133, 84);
            this.inputZoneTextBox.Name = "inputZoneTextBox";
            this.inputZoneTextBox.Size = new System.Drawing.Size(100, 22);
            this.inputZoneTextBox.TabIndex = 3;
            // 
            // okInputButton
            // 
            this.okInputButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.okInputButton.Location = new System.Drawing.Point(153, 168);
            this.okInputButton.Name = "okInputButton";
            this.okInputButton.Size = new System.Drawing.Size(108, 23);
            this.okInputButton.TabIndex = 4;
            this.okInputButton.Text = "Ввод";
            this.okInputButton.UseVisualStyleBackColor = true;
            this.okInputButton.Click += new System.EventHandler(this.okInputButton_Click);
            // 
            // inputAllDatasbutton1
            // 
            this.inputAllDatasbutton1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.inputAllDatasbutton1.Location = new System.Drawing.Point(13, 168);
            this.inputAllDatasbutton1.Name = "inputAllDatasbutton1";
            this.inputAllDatasbutton1.Size = new System.Drawing.Size(106, 23);
            this.inputAllDatasbutton1.TabIndex = 5;
            this.inputAllDatasbutton1.Text = "Завершить ввод";
            this.inputAllDatasbutton1.UseVisualStyleBackColor = true;
            this.inputAllDatasbutton1.Click += new System.EventHandler(this.inputAllDatasbutton1_Click);
            // 
            // InputDataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(273, 203);
            this.Controls.Add(this.inputAllDatasbutton1);
            this.Controls.Add(this.okInputButton);
            this.Controls.Add(this.inputZoneTextBox);
            this.Controls.Add(this.inputTempretureTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(289, 241);
            this.MinimumSize = new System.Drawing.Size(289, 241);
            this.Name = "InputDataForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InputDataForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox inputTempretureTextBox;
        private System.Windows.Forms.TextBox inputZoneTextBox;
        private System.Windows.Forms.Button okInputButton;
        private System.Windows.Forms.Button inputAllDatasbutton1;
    }
}