namespace Corgs
{
    partial class FormNotes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNotes));
            this.txtInputNote = new System.Windows.Forms.TextBox();
            this.treeViewNotes = new System.Windows.Forms.TreeView();
            this.groupBoxNote = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnSubmitNote = new System.Windows.Forms.Button();
            this.comboBoxNote = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxNote.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtInputNote
            // 
            this.txtInputNote.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(72)))), ((int)(((byte)(83)))));
            this.txtInputNote.Location = new System.Drawing.Point(6, 21);
            this.txtInputNote.Name = "txtInputNote";
            this.txtInputNote.Size = new System.Drawing.Size(156, 22);
            this.txtInputNote.TabIndex = 1;
            // 
            // treeViewNotes
            // 
            this.treeViewNotes.BackColor = System.Drawing.SystemColors.Control;
            this.treeViewNotes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(72)))), ((int)(((byte)(83)))));
            this.treeViewNotes.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(72)))), ((int)(((byte)(83)))));
            this.treeViewNotes.Location = new System.Drawing.Point(6, 49);
            this.treeViewNotes.Name = "treeViewNotes";
            this.treeViewNotes.Size = new System.Drawing.Size(304, 155);
            this.treeViewNotes.TabIndex = 4;
            // 
            // groupBoxNote
            // 
            this.groupBoxNote.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxNote.Controls.Add(this.button1);
            this.groupBoxNote.Controls.Add(this.btnSubmitNote);
            this.groupBoxNote.Controls.Add(this.treeViewNotes);
            this.groupBoxNote.Controls.Add(this.txtInputNote);
            this.groupBoxNote.Location = new System.Drawing.Point(12, 39);
            this.groupBoxNote.Name = "groupBoxNote";
            this.groupBoxNote.Size = new System.Drawing.Size(316, 210);
            this.groupBoxNote.TabIndex = 2;
            this.groupBoxNote.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(246, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(64, 22);
            this.button1.TabIndex = 3;
            this.button1.Text = "Check out";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSubmitNote
            // 
            this.btnSubmitNote.Location = new System.Drawing.Point(168, 21);
            this.btnSubmitNote.Name = "btnSubmitNote";
            this.btnSubmitNote.Size = new System.Drawing.Size(72, 22);
            this.btnSubmitNote.TabIndex = 2;
            this.btnSubmitNote.Text = "Check In";
            this.btnSubmitNote.UseVisualStyleBackColor = true;
            this.btnSubmitNote.Click += new System.EventHandler(this.btnSubmitNote_Click);
            // 
            // comboBoxNote
            // 
            this.comboBoxNote.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxNote.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxNote.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(72)))), ((int)(((byte)(83)))));
            this.comboBoxNote.FormattingEnabled = true;
            this.comboBoxNote.Items.AddRange(new object[] {
            "IOMS",
            "SCCI"});
            this.comboBoxNote.Location = new System.Drawing.Point(18, 12);
            this.comboBoxNote.Name = "comboBoxNote";
            this.comboBoxNote.Size = new System.Drawing.Size(156, 21);
            this.comboBoxNote.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(72)))), ((int)(((byte)(83)))));
            this.label1.Location = new System.Drawing.Point(180, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Project";
            // 
            // FormNotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(340, 261);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxNote);
            this.Controls.Add(this.groupBoxNote);
            this.Font = new System.Drawing.Font("Leelawadee UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(128)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormNotes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Corgi Notes v1.0";
            this.Load += new System.EventHandler(this.FormNotes_Load);
            this.groupBoxNote.ResumeLayout(false);
            this.groupBoxNote.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInputNote;
        private System.Windows.Forms.TreeView treeViewNotes;
        private System.Windows.Forms.GroupBox groupBoxNote;
        private System.Windows.Forms.Button btnSubmitNote;
        private System.Windows.Forms.ComboBox comboBoxNote;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}