using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_App
{
    public partial class Form1 : Form
    {
        private string SARNEG;
        private string SARDOT;
        private char[] ltrSARNEG;
        private char[] ltrSARDOT;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnSARNEG_Click(object sender, EventArgs e)
        {
            var labels = new List<Label> { lbl0, lbl1, lbl2, lbl3, lbl4, lbl5, lbl6, lbl7, lbl8, lbl9 };

            SARNEG = txtSARNEG.Text;
            ltrSARNEG = SARNEG.ToCharArray();

            if (SARNEG.Length < 1)
            {
                return;
            }
            else
            {
                for (int n = 0; n < ltrSARNEG.Length; n++)
                {
                    labels[n].Text = ltrSARNEG[n].ToString().ToUpper();
                }
            }
        }

        private void btnDecode_Click(object sender, EventArgs e)
        {
            lblConverted.Text = "";

            SARDOT = txtSARDOT.Text;
            ltrSARDOT = SARDOT.ToCharArray();

            for (int n = 0; n < ltrSARDOT.Length; n++)
            {
                int loc = SARNEG.IndexOf(ltrSARDOT[n]);
                lblConverted.Text += loc;
            }
        }
    }
}
