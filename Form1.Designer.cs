
namespace SimpleCar
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.Engine_Switch = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.Engine_Status = new System.Windows.Forms.RadioButton();
            this.Gas_Pedal = new System.Windows.Forms.Button();
            this.Break_Pedal = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(84, 56);
            this.textBox1.Name = "textBox1";
            this.textBox1.PlaceholderText = "Make";
            this.textBox1.Size = new System.Drawing.Size(107, 23);
            this.textBox1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(294, 55);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(84, 85);
            this.textBox2.Name = "textBox2";
            this.textBox2.PlaceholderText = "Model";
            this.textBox2.Size = new System.Drawing.Size(107, 23);
            this.textBox2.TabIndex = 2;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(401, 55);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 23);
            this.textBox4.TabIndex = 3;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(84, 114);
            this.textBox3.Name = "textBox3";
            this.textBox3.PlaceholderText = "Production Year";
            this.textBox3.Size = new System.Drawing.Size(107, 23);
            this.textBox3.TabIndex = 4;
            // 
            // Engine_Switch
            // 
            this.Engine_Switch.Location = new System.Drawing.Point(84, 302);
            this.Engine_Switch.Name = "Engine_Switch";
            this.Engine_Switch.Size = new System.Drawing.Size(107, 23);
            this.Engine_Switch.TabIndex = 5;
            this.Engine_Switch.Text = "Start Engine";
            this.Engine_Switch.UseVisualStyleBackColor = true;
            this.Engine_Switch.Click += new System.EventHandler(this.Engine_Switch_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(84, 390);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(617, 23);
            this.progressBar1.TabIndex = 6;
            // 
            // Engine_Status
            // 
            this.Engine_Status.AutoSize = true;
            this.Engine_Status.Location = new System.Drawing.Point(198, 302);
            this.Engine_Status.Name = "Engine_Status";
            this.Engine_Status.Size = new System.Drawing.Size(57, 19);
            this.Engine_Status.TabIndex = 7;
            this.Engine_Status.TabStop = true;
            this.Engine_Status.Text = "Status";
            this.Engine_Status.UseVisualStyleBackColor = true;
            // 
            // Gas_Pedal
            // 
            this.Gas_Pedal.Location = new System.Drawing.Point(393, 302);
            this.Gas_Pedal.Name = "Gas_Pedal";
            this.Gas_Pedal.Size = new System.Drawing.Size(108, 23);
            this.Gas_Pedal.TabIndex = 8;
            this.Gas_Pedal.Text = "Gas Pedal";
            this.Gas_Pedal.UseVisualStyleBackColor = true;
            this.Gas_Pedal.Click += new System.EventHandler(this.Gas_Pedal_Click);
            // 
            // Break_Pedal
            // 
            this.Break_Pedal.Location = new System.Drawing.Point(507, 302);
            this.Break_Pedal.Name = "Break_Pedal";
            this.Break_Pedal.Size = new System.Drawing.Size(108, 23);
            this.Break_Pedal.TabIndex = 9;
            this.Break_Pedal.Text = "Break Pedal";
            this.Break_Pedal.UseVisualStyleBackColor = true;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Break_Pedal);
            this.Controls.Add(this.Gas_Pedal);
            this.Controls.Add(this.Engine_Status);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.Engine_Switch);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button Engine_Switch;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.RadioButton Engine_Status;
        private System.Windows.Forms.Button Gas_Pedal;
        private System.Windows.Forms.Button Break_Pedal;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

