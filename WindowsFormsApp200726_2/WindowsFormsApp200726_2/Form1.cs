using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp200726_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_input_Click(object sender, EventArgs e)
        {
            string oldText = tBox_main.Text;
            string newText = tBox_input.Text;

            if (newText.Trim() != "")
            {
                tBox_main.Text = oldText + Environment.NewLine + newText;
            }

            tBox_input.Text = "";
        }
    }
}
