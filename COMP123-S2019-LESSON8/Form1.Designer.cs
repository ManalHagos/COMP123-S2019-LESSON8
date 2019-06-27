namespace COMP123_S2019_LESSON8
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
            this.Lab8 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.AgeTextBox = new System.Windows.Forms.TextBox();
            this.age = new System.Windows.Forms.Label();
            this.info = new System.Windows.Forms.GroupBox();
            this.SumbitButton = new System.Windows.Forms.Button();
            this.OutputLabel1 = new System.Windows.Forms.Label();
            this.info.SuspendLayout();
            this.SuspendLayout();
            // 
            // Lab8
            // 
            this.Lab8.AutoSize = true;
            this.Lab8.Location = new System.Drawing.Point(270, 91);
            this.Lab8.Name = "Lab8";
            this.Lab8.Size = new System.Drawing.Size(49, 20);
            this.Lab8.TabIndex = 0;
            this.Lab8.Text = "Lab 8";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(6, 28);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(91, 20);
            this.name.TabIndex = 1;
            this.name.Text = "Your name:";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(115, 25);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(100, 26);
            this.NameTextBox.TabIndex = 2;
            // 
            // AgeTextBox
            // 
            this.AgeTextBox.Location = new System.Drawing.Point(115, 67);
            this.AgeTextBox.Name = "AgeTextBox";
            this.AgeTextBox.Size = new System.Drawing.Size(100, 26);
            this.AgeTextBox.TabIndex = 4;
            // 
            // age
            // 
            this.age.AutoSize = true;
            this.age.Location = new System.Drawing.Point(6, 70);
            this.age.Name = "age";
            this.age.Size = new System.Drawing.Size(78, 20);
            this.age.TabIndex = 3;
            this.age.Text = "Your age:";
            // 
            // info
            // 
            this.info.BackColor = System.Drawing.SystemColors.ControlLight;
            this.info.Controls.Add(this.NameTextBox);
            this.info.Controls.Add(this.AgeTextBox);
            this.info.Controls.Add(this.name);
            this.info.Controls.Add(this.age);
            this.info.Location = new System.Drawing.Point(240, 222);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(334, 153);
            this.info.TabIndex = 5;
            this.info.TabStop = false;
            this.info.Text = "info";
            this.info.TextChanged += new System.EventHandler(this.info_TextChanged);
            // 
            // SumbitButton
            // 
            this.SumbitButton.Location = new System.Drawing.Point(496, 381);
            this.SumbitButton.Name = "SumbitButton";
            this.SumbitButton.Size = new System.Drawing.Size(116, 29);
            this.SumbitButton.TabIndex = 6;
            this.SumbitButton.Text = "SumbitButton";
            this.SumbitButton.UseVisualStyleBackColor = true;
            this.SumbitButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // OutputLabel1
            // 
            this.OutputLabel1.AutoSize = true;
            this.OutputLabel1.Location = new System.Drawing.Point(288, 384);
            this.OutputLabel1.Name = "OutputLabel1";
            this.OutputLabel1.Size = new System.Drawing.Size(91, 20);
            this.OutputLabel1.TabIndex = 7;
            this.OutputLabel1.Text = "Your name:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.OutputLabel1);
            this.Controls.Add(this.SumbitButton);
            this.Controls.Add(this.info);
            this.Controls.Add(this.Lab8);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lab8";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.info.ResumeLayout(false);
            this.info.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lab8;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.TextBox AgeTextBox;
        private System.Windows.Forms.Label age;
        private System.Windows.Forms.GroupBox info;
        private System.Windows.Forms.Button SumbitButton;
        private System.Windows.Forms.Label OutputLabel1;
    }
}

