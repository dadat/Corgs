using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Corgs
{
    public partial class FormNotes : Form
    {
        public FormNotes()
        {
            InitializeComponent();
        }

        private void btnSubmitNote_Click(object sender, EventArgs e)
        {
            TreeNode treeNode = new TreeNode("Notes");
            
            //treeView1.Nodes.Add(treeNode);
            //treeNode = new TreeNode("Linux");
            //treeView1.Nodes.Add(treeNode);

            string d = "In: " + myDateNow().ToString();
            string inputNote = txtInputNote.Text;
            string typeNote = comboBoxNote.Text;

            TreeNode node1 = new TreeNode(typeNote);
            TreeNode node2 = new TreeNode(inputNote);

            writeLog(inputNote);

            TreeNode[] array = new TreeNode[] { node1, node2 };

            treeNode = new TreeNode(d, array);
            treeViewNotes.Nodes.Add(treeNode);
        }

        public DateTime myDateNow()
        {
            return getDate();
        }

        private DateTime getDate()
        {
            return DateTime.Now;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TreeNode treeNode = new TreeNode("Notes");
            string d = "Out: " + myDateNow().ToString();
            string inputNote = txtInputNote.Text;
            string typeNote = comboBoxNote.Text;

            TreeNode node1 = new TreeNode(typeNote);
            TreeNode node2 = new TreeNode(inputNote);

            TreeNode[] array = new TreeNode[] { node1, node2 };



            treeNode = new TreeNode(d, array);
            treeViewNotes.Nodes.Add(treeNode);
        }

        private void FormNotes_Load(object sender, EventArgs e)
        {
            comboBoxNote.SelectedIndex = 1;
        }

        public static void writeLog(string msg)
        {
            string lines = msg;
            string strPath = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
            // Write the string to a file.
            //System.IO.StreamWriter file = new System.IO.StreamWriter(strPath, true);
            StreamWriter file = new StreamWriter(strPath, true);
            file.WriteLine(lines);
            file.Flush();
            file.Close();
        }

    }
}
