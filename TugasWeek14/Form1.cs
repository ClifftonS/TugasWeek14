using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TugasWeek14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnkonversi_Click(object sender, EventArgs e)
        {
            string s1, s2, s3;
            char c1, c2;
            int i1, i2;
            s3 = "";
            s1 = "ABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZ";
            s2 = tboxkalimat.Text.ToUpper();
            c1 = Convert.ToChar(tboxhuruf1.Text); 
            c2 = Convert.ToChar(tboxhuruf2.Text);
            i1 = c2 - c1 + 26;
            for (int i = 0; i <= s2.Length-1; i++)
            {
                if (s2[i] == ' ')
                {
                    s3 = s3 + " ";
                }
                else
                {
                    i2 = s1.IndexOf(s2[i]) + i1;
                    s3 = s3 + s1.Substring(i2, 1);
                }
            }
            lbloutput.Text = s3;
        }
    }
}
