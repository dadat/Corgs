namespace Corgs
{
    partial class FormMainCorgs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMainCorgs));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtLastNameField = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxTop = new System.Windows.Forms.GroupBox();
            this.btnSearchList = new System.Windows.Forms.Button();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtMiddleName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBoxDetails = new System.Windows.Forms.GroupBox();
            this.btnSearchToListview = new System.Windows.Forms.Button();
            this.dateTimePickerDetails = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCaseNum = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.listDetails = new System.Windows.Forms.ListBox();
            this.listViewPerson = new System.Windows.Forms.ListView();
            this.lastNameLV = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.firstNameLV = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.middleNameLV = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ageLV = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.caseLV = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1.SuspendLayout();
            this.groupBoxTop.SuspendLayout();
            this.groupBoxDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(134)))), ((int)(((byte)(140)))));
            this.panel1.Controls.Add(this.label7);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(584, 65);
            this.panel1.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Leelawadee UI Semilight", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(220, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(144, 30);
            this.label7.TabIndex = 13;
            this.label7.Text = "Person Details";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(78)))), ((int)(((byte)(82)))));
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSearch.Font = new System.Drawing.Font("Leelawadee UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(235)))));
            this.btnSearch.Location = new System.Drawing.Point(59, 59);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 30);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Case";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtLastNameField
            // 
            this.txtLastNameField.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtLastNameField.Location = new System.Drawing.Point(59, 26);
            this.txtLastNameField.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtLastNameField.Name = "txtLastNameField";
            this.txtLastNameField.Size = new System.Drawing.Size(156, 25);
            this.txtLastNameField.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(162, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Name:";
            // 
            // groupBoxTop
            // 
            this.groupBoxTop.Controls.Add(this.btnSearchList);
            this.groupBoxTop.Controls.Add(this.btnSearch);
            this.groupBoxTop.Controls.Add(this.txtLastNameField);
            this.groupBoxTop.Location = new System.Drawing.Point(12, 72);
            this.groupBoxTop.Name = "groupBoxTop";
            this.groupBoxTop.Size = new System.Drawing.Size(273, 107);
            this.groupBoxTop.TabIndex = 4;
            this.groupBoxTop.TabStop = false;
            this.groupBoxTop.Text = "Search by last name or reference number:";
            // 
            // btnSearchList
            // 
            this.btnSearchList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(78)))), ((int)(((byte)(82)))));
            this.btnSearchList.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSearchList.Font = new System.Drawing.Font("Leelawadee UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(235)))));
            this.btnSearchList.Location = new System.Drawing.Point(140, 59);
            this.btnSearchList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSearchList.Name = "btnSearchList";
            this.btnSearchList.Size = new System.Drawing.Size(75, 30);
            this.btnSearchList.TabIndex = 11;
            this.btnSearchList.Text = "List";
            this.btnSearchList.UseVisualStyleBackColor = false;
            this.btnSearchList.Click += new System.EventHandler(this.btnSearchList_Click);
            // 
            // txtFirstName
            // 
            this.txtFirstName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtFirstName.Location = new System.Drawing.Point(19, 48);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(165, 25);
            this.txtFirstName.TabIndex = 5;
            // 
            // txtMiddleName
            // 
            this.txtMiddleName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtMiddleName.Location = new System.Drawing.Point(19, 97);
            this.txtMiddleName.Name = "txtMiddleName";
            this.txtMiddleName.Size = new System.Drawing.Size(165, 25);
            this.txtMiddleName.TabIndex = 6;
            // 
            // txtLastName
            // 
            this.txtLastName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtLastName.Location = new System.Drawing.Point(19, 146);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(165, 25);
            this.txtLastName.TabIndex = 7;
            // 
            // txtAge
            // 
            this.txtAge.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtAge.Location = new System.Drawing.Point(19, 195);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(165, 25);
            this.txtAge.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "First Name:";
            // 
            // groupBoxDetails
            // 
            this.groupBoxDetails.Controls.Add(this.btnSearchToListview);
            this.groupBoxDetails.Controls.Add(this.dateTimePickerDetails);
            this.groupBoxDetails.Controls.Add(this.label9);
            this.groupBoxDetails.Controls.Add(this.label8);
            this.groupBoxDetails.Controls.Add(this.txtCaseNum);
            this.groupBoxDetails.Controls.Add(this.label6);
            this.groupBoxDetails.Controls.Add(this.label5);
            this.groupBoxDetails.Controls.Add(this.label4);
            this.groupBoxDetails.Controls.Add(this.txtFirstName);
            this.groupBoxDetails.Controls.Add(this.label2);
            this.groupBoxDetails.Controls.Add(this.txtMiddleName);
            this.groupBoxDetails.Controls.Add(this.txtAge);
            this.groupBoxDetails.Controls.Add(this.txtLastName);
            this.groupBoxDetails.Location = new System.Drawing.Point(12, 185);
            this.groupBoxDetails.Name = "groupBoxDetails";
            this.groupBoxDetails.Size = new System.Drawing.Size(409, 264);
            this.groupBoxDetails.TabIndex = 10;
            this.groupBoxDetails.TabStop = false;
            this.groupBoxDetails.Text = "Details";
            // 
            // btnSearchToListview
            // 
            this.btnSearchToListview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(78)))), ((int)(((byte)(82)))));
            this.btnSearchToListview.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSearchToListview.Font = new System.Drawing.Font("Leelawadee UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchToListview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(235)))));
            this.btnSearchToListview.Location = new System.Drawing.Point(19, 227);
            this.btnSearchToListview.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSearchToListview.Name = "btnSearchToListview";
            this.btnSearchToListview.Size = new System.Drawing.Size(165, 30);
            this.btnSearchToListview.TabIndex = 19;
            this.btnSearchToListview.Text = "Search to Listview";
            this.btnSearchToListview.UseVisualStyleBackColor = false;
            this.btnSearchToListview.Click += new System.EventHandler(this.btnSearchToListview_Click);
            // 
            // dateTimePickerDetails
            // 
            this.dateTimePickerDetails.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDetails.Location = new System.Drawing.Point(213, 48);
            this.dateTimePickerDetails.Name = "dateTimePickerDetails";
            this.dateTimePickerDetails.Size = new System.Drawing.Size(142, 25);
            this.dateTimePickerDetails.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(210, 77);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 17);
            this.label9.TabIndex = 16;
            this.label9.Text = "Case:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(210, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 17);
            this.label8.TabIndex = 13;
            this.label8.Text = "Date Last Visit:";
            // 
            // txtCaseNum
            // 
            this.txtCaseNum.Location = new System.Drawing.Point(213, 97);
            this.txtCaseNum.Name = "txtCaseNum";
            this.txtCaseNum.ReadOnly = true;
            this.txtCaseNum.Size = new System.Drawing.Size(142, 25);
            this.txtCaseNum.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 174);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Age:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Last Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Middle Name:";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(78)))), ((int)(((byte)(82)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClose.Font = new System.Drawing.Font("Leelawadee UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(235)))));
            this.btnClose.Location = new System.Drawing.Point(427, 422);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(145, 27);
            this.btnClose.TabIndex = 11;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(78)))), ((int)(((byte)(82)))));
            this.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNew.Font = new System.Drawing.Font("Leelawadee UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(235)))));
            this.btnNew.Location = new System.Drawing.Point(427, 384);
            this.btnNew.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(145, 30);
            this.btnNew.TabIndex = 11;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // listDetails
            // 
            this.listDetails.FormattingEnabled = true;
            this.listDetails.ItemHeight = 17;
            this.listDetails.Location = new System.Drawing.Point(291, 80);
            this.listDetails.Name = "listDetails";
            this.listDetails.Size = new System.Drawing.Size(281, 106);
            this.listDetails.TabIndex = 17;
            // 
            // listViewPerson
            // 
            this.listViewPerson.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.lastNameLV,
            this.firstNameLV,
            this.middleNameLV,
            this.ageLV,
            this.caseLV});
            this.listViewPerson.FullRowSelect = true;
            this.listViewPerson.Location = new System.Drawing.Point(12, 456);
            this.listViewPerson.Name = "listViewPerson";
            this.listViewPerson.Size = new System.Drawing.Size(560, 181);
            this.listViewPerson.TabIndex = 18;
            this.listViewPerson.UseCompatibleStateImageBehavior = false;
            this.listViewPerson.View = System.Windows.Forms.View.Details;
            this.listViewPerson.SelectedIndexChanged += new System.EventHandler(this.listViewPerson_SelectedIndexChanged);
            // 
            // lastNameLV
            // 
            this.lastNameLV.Text = "Last Name";
            this.lastNameLV.Width = 143;
            // 
            // firstNameLV
            // 
            this.firstNameLV.Text = "First Name";
            this.firstNameLV.Width = 144;
            // 
            // middleNameLV
            // 
            this.middleNameLV.Text = "Middle Name";
            this.middleNameLV.Width = 106;
            // 
            // ageLV
            // 
            this.ageLV.Text = "Age";
            // 
            // caseLV
            // 
            this.caseLV.Text = "Case Number";
            this.caseLV.Width = 102;
            // 
            // FormMainCorgs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(584, 649);
            this.Controls.Add(this.listViewPerson);
            this.Controls.Add(this.listDetails);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.groupBoxDetails);
            this.Controls.Add(this.groupBoxTop);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormMainCorgs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Window";
            this.Load += new System.EventHandler(this.FormMainCorgs_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBoxTop.ResumeLayout(false);
            this.groupBoxTop.PerformLayout();
            this.groupBoxDetails.ResumeLayout(false);
            this.groupBoxDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtLastNameField;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBoxTop;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtMiddleName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBoxDetails;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DateTimePicker dateTimePickerDetails;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtCaseNum;
        private System.Windows.Forms.ListBox listDetails;
        private System.Windows.Forms.Button btnSearchList;
        private System.Windows.Forms.Button btnSearchToListview;
        private System.Windows.Forms.ListView listViewPerson;
        private System.Windows.Forms.ColumnHeader lastNameLV;
        private System.Windows.Forms.ColumnHeader firstNameLV;
        private System.Windows.Forms.ColumnHeader middleNameLV;
        private System.Windows.Forms.ColumnHeader ageLV;
        private System.Windows.Forms.ColumnHeader caseLV;
    }
}

