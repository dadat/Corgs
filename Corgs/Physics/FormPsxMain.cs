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
    public partial class FormPsxMain : Form
    {
        public FormPsxMain()
        {
            InitializeComponent();
        }

        private void btnHelpPHSX_Click(object sender, EventArgs e)
        {
            MessageBox.Show("David Barredo Physics Tool v2.12.0203" + Environment.NewLine + "© 2015", "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                double displacement = Convert.ToDouble(txtVDisplacement.Text);
                double time = Convert.ToDouble(txtVTime.Text);
                Physics.Physx phys = new Physics.Physx();
                double velocity = phys.getVelocity(displacement, time);
                txtVelocity.Text = Convert.ToString(velocity);
            }
            catch (Exception e1)
            {
                Console.WriteLine(e1);
                Console.WriteLine("Make sure input is integer.");
            }

            try
            {
                double deltaV = Convert.ToDouble(txtADeltaV.Text);
                double timeAcceleration = Convert.ToDouble(txtATime.Text);
                Physics.Physx phys = new Physics.Physx();
                double acceleration = phys.getAcceleration(deltaV, timeAcceleration);
                txtAcceleration.Text = Convert.ToString(acceleration);
            }
            catch (Exception e2)
            {
                Console.WriteLine(e2);
                Console.WriteLine("Make sure input is integer.");
            }

            try
            {
                double mass = Convert.ToDouble(txtFMass.Text);
                double accelerationF = Convert.ToDouble(txtFAcceleration.Text);
                Physics.Physx phys = new Physics.Physx();
                double force = phys.getForce(mass, accelerationF);
                txtForce.Text = Convert.ToString(force);
            }
            catch (Exception e3)
            {
                Console.WriteLine(e3);
                Console.WriteLine("Make sure input is integer.");
            }

            try
            {
                string exprsn = txtPolynomialField.Text;
                Physics.Physx phys = new Physics.Physx();
                float polynomial = phys.getPolynomial(exprsn);
                txtPolynomial.Text = Convert.ToString(polynomial);
            }
            catch (Exception e4)
            {
                Console.WriteLine(e4);
            }
        }
    }
}
