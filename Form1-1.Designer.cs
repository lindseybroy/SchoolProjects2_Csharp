namespace CIS317_FinalExam_Roy
{
    partial class SPoll
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
            this.Donebutton = new System.Windows.Forms.Button();
            this.Displaybutton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Donebutton
            // 
            this.Donebutton.Location = new System.Drawing.Point(183, 44);
            this.Donebutton.Name = "Donebutton";
            this.Donebutton.Size = new System.Drawing.Size(75, 23);
            this.Donebutton.TabIndex = 0;
            this.Donebutton.Text = "Done";
            this.Donebutton.UseVisualStyleBackColor = true;
            this.Donebutton.Click += new System.EventHandler(this.Donebutton_Click);
            // 
            // Displaybutton
            // 
            this.Displaybutton.Location = new System.Drawing.Point(69, 98);
            this.Displaybutton.Name = "Displaybutton";
            this.Displaybutton.Size = new System.Drawing.Size(117, 23);
            this.Displaybutton.TabIndex = 1;
            this.Displaybutton.Text = "View Survey Results";
            this.Displaybutton.UseVisualStyleBackColor = true;
            this.Displaybutton.Click += new System.EventHandler(this.Displaybutton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(33, 44);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(135, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Enter an integer result (1-10) and press Enter";
            // 
            // SPoll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Displaybutton);
            this.Controls.Add(this.Donebutton);
            this.Name = "SPoll";
            this.Text = "Student Poll";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Donebutton;
        private System.Windows.Forms.Button Displaybutton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
    }
}

