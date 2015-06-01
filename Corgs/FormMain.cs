using Mindscape.LightSpeed;
using Mindscape.LightSpeed.Linq;
using Mindscape.LightSpeed.Querying;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Corgs
{
    public partial class FormMainCorgs : Form
    {
        public FormMainCorgs()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string lastname = txtLastNameField.Text;

            DateTime dateVisit = dateTimePickerDetails.Value;
            PersonDetails objPersonDetails = new PersonDetails();
            if (objPersonDetails.searchByCase(lastname) == true)
            {
                txtFirstName.Text = objPersonDetails.myFName;
                txtMiddleName.Text = objPersonDetails.myMName;
                txtLastName.Text = objPersonDetails.myLName;
                txtAge.Text = objPersonDetails.myAge.ToString();
                dateTimePickerDetails.Value = objPersonDetails.myDateVisit;
                txtCaseNum.Text = objPersonDetails.myCase;

                listDetails.Items.Add(objPersonDetails.myLName + ", " + objPersonDetails.myFName + " " + objPersonDetails.myMName);
            }
            else
            {
                MessageBox.Show("Record does not exist.", "Message.", MessageBoxButtons.OK, MessageBoxIcon.None);
            }


        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            string firstname = txtFirstName.Text;
            string middlename = txtMiddleName.Text;
            string lastname = txtLastName.Text;

            var age = txtAge.Text;

            //Check for null or string in Age field
            int ageChecked;
            bool isNumeric = int.TryParse(age, out ageChecked);
            if (isNumeric == false)
            {
                MessageBox.Show("Need number for age.");
                return;
            }

            DateTime dateVisit = dateTimePickerDetails.Value;
            PersonDetails objPersonDetails = new PersonDetails(firstname, middlename, lastname, ageChecked, dateVisit);
            if (objPersonDetails.addRecords().Equals(false))
            {
                MessageBox.Show("Error adding record.", "Error message.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                clearItems();
                MessageBox.Show("Successfully added record.", "Message", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
        }

        private void clearItems()
        {
            foreach (var groupBox in Controls.OfType<GroupBox>())
            {
                foreach (var textBox in groupBox.Controls.OfType<TextBox>())
                {
                    textBox.Clear();
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSearchList_Click(object sender, EventArgs e)
        {
            listDetails.Items.Clear();
            PersonDetails objPersonDetails = new PersonDetails();
            string lname = txtLastNameField.Text;
            var tListRecords = objPersonDetails.searchRecordsLINQ(lname);
            try
            {
                foreach (var item in tListRecords)
                {
                    listDetails.Items.Add(item.Lname + ", " + item.Fname + " " + item.Mname);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return;
            }

        }

        public string caseSelected { get; set; }

        private void btnSearchToListview_Click(object sender, EventArgs e)
        {
            try
            {
                listViewPerson.Items.Clear();
                string lastNameField = txtLastNameField.Text;
                PersonDetails objP = new PersonDetails();
                var tListRecords = objP.searchToListview(lastNameField);

                //Iterate through tListRecords
                foreach (var item in tListRecords)
                {
                    ListViewItem listItem = new ListViewItem(item.Lname);
                    listItem.SubItems.Add(item.Fname);
                    listItem.SubItems.Add(item.Mname);
                    listItem.SubItems.Add(Convert.ToString(item.Age));
                    listItem.SubItems.Add(item.CaseId);

                    //Adds each listItem to ListView listViewPerson
                    listViewPerson.Items.Add(listItem);
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("btnSearchToListview_Click error: " + err);
                throw;
            }
            
        }

        private void listViewPerson_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewPerson.SelectedItems.Count > 0)
            {
                for (int i = 0; i < listViewPerson.Items.Count; i++)
                {
                    //MessageBox.Show("Test: " + listViewPerson.Items[i].SubItems[listViewPerson.Items].Text);
                }
            }
            else
            {
                MyLVItem = "";
            }
        }

        public string MyLVItem { get; set; }
        public ListView.SelectedListViewItemCollection SelectedLVItem { get; set; }

        private void FormMainCorgs_Load(object sender, EventArgs e)
        {

        }
    }
}
