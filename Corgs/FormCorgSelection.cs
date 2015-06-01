using Mindscape.Raygun4Net;
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
    public partial class FormCorgSelection : Form
    {

        public FormCorgSelection()
        {
            InitializeComponent();
        }

        //static RaygunClient _client = new RaygunClient("tXu6M1ixtrv1y+YWw3TMGQ==");

        private void button1_Click(object sender, EventArgs e)
        {
            FormPsxMain frmPsx = new FormPsxMain();
            frmPsx.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormCorgamble frmGamble = new FormCorgamble();
            frmGamble.ShowDialog();
        }

        private void FormCorgSelection_Load(object sender, EventArgs e)
        {

        }

        private void btnRaygun_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Page here.");
            
            new RaygunClient().Send(new Exception(string.Format("Dvd btnRaygun_Click2")));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormMainCorgs frmMainCorgs = new FormMainCorgs();
            frmMainCorgs.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
