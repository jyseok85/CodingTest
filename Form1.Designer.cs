
namespace CodingTest
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.전화번호목록 = new System.Windows.Forms.Button();
            this.입국심사 = new System.Windows.Forms.Button();
            this.체육복 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // 전화번호목록
            // 
            this.전화번호목록.Location = new System.Drawing.Point(93, 12);
            this.전화번호목록.Name = "전화번호목록";
            this.전화번호목록.Size = new System.Drawing.Size(75, 23);
            this.전화번호목록.TabIndex = 1;
            this.전화번호목록.Text = "전화번호목록";
            this.전화번호목록.UseVisualStyleBackColor = true;
            this.전화번호목록.Click += new System.EventHandler(this.전화번호목록_Click);
            // 
            // 입국심사
            // 
            this.입국심사.Location = new System.Drawing.Point(174, 12);
            this.입국심사.Name = "입국심사";
            this.입국심사.Size = new System.Drawing.Size(75, 23);
            this.입국심사.TabIndex = 2;
            this.입국심사.Text = "입국심사";
            this.입국심사.UseVisualStyleBackColor = true;
            this.입국심사.Click += new System.EventHandler(this.입국심사_Click);
            // 
            // 체육복
            // 
            this.체육복.Location = new System.Drawing.Point(255, 12);
            this.체육복.Name = "체육복";
            this.체육복.Size = new System.Drawing.Size(75, 23);
            this.체육복.TabIndex = 3;
            this.체육복.Text = "체육복";
            this.체육복.UseVisualStyleBackColor = true;
            this.체육복.Click += new System.EventHandler(this.체육복_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 213);
            this.Controls.Add(this.체육복);
            this.Controls.Add(this.입국심사);
            this.Controls.Add(this.전화번호목록);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button 전화번호목록;
        private System.Windows.Forms.Button 입국심사;
        private System.Windows.Forms.Button 체육복;
    }
}

