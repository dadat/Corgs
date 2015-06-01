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
    public partial class FormCorgamble : Form
    {
        public FormCorgamble()
        {
            InitializeComponent();
        }

        private void btnGamblePP_Click(object sender, EventArgs e)
        {
                decimal pl1 = Convert.ToDecimal(txtP1.Text);
                decimal pl2 = Convert.ToDecimal(txtP2.Text);
                decimal pl3 = Convert.ToDecimal(txtP3.Text);

                Gambling oGambling = new Gambling(pl1, pl2, pl3);
                int win = oGambling.GamblePizza();

                if (win == 1)
                {
                    lblWinner.Text = "Winner: Player 1.";
                }
                else if (win == 2)
                {
                    lblWinner.Text = "Winner: Player 2.";
                }
                else if (win == 3)
                {
                    lblWinner.Text = "Winner: Player 3.";
                }

                MessageBox.Show("Test" + Convert.ToString(oGambling.GoldTotal));

                txtWinnings1.Text = Convert.ToString(oGambling.Gold1);
                txtWinnings2.Text = Convert.ToString(oGambling.Gold2);
                txtWinnings3.Text = Convert.ToString(oGambling.Gold3);
        }

        private void txtP1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
