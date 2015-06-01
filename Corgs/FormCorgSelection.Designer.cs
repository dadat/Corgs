namespace Corgs
{
    partial class FormCorgSelection
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
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRaygun = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 37);
            this.button1.TabIndex = 0;
            this.button1.Text = "Physx";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(6, 74);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(97, 37);
            this.button2.TabIndex = 1;
            this.button2.Text = "Patient";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(6, 129);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(97, 37);
            this.button3.TabIndex = 2;
            this.button3.Text = "Notes";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(6, 184);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(97, 37);
            this.button4.TabIndex = 3;
            this.button4.Text = "Gamble";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Location = new System.Drawing.Point(12, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(122, 228);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "David Windows";
            // 
            // btnRaygun
            // 
            this.btnRaygun.Location = new System.Drawing.Point(35, 31);
            this.btnRaygun.Name = "btnRaygun";
            this.btnRaygun.Size = new System.Drawing.Size(130, 39);
            this.btnRaygun.TabIndex = 5;
            this.btnRaygun.Text = "Raygun Tester";
            this.btnRaygun.UseVisualStyleBackColor = true;
            this.btnRaygun.Click += new System.EventHandler(this.btnRaygun_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnRaygun);
            this.groupBox2.Location = new System.Drawing.Point(140, 21);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tests Mindscape Raygun";
            // 
            // FormCorgSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 261);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormCorgSelection";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Programs";
            this.Load += new System.EventHandler(this.FormCorgSelection_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnRaygun;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}