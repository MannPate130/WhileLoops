using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WhileLoops
{
    public partial class Form1 : Form
    {
        int start;
        int end;
        public Form1()
        {
            InitializeComponent();
        }

        private void convertButton_Click(object sender, EventArgs e)
        {
            start = Convert.ToInt32(startInputbox.Text);
            end = Convert.ToInt32(endingInputbox.Text);

            while (start <= end)
            {
                outputLabel.Text += $" {start}";
                start++;
            }

        }
        private void resetButton_Click(object sender, EventArgs e)
        {
            outputLabel.Text = $"";
            start = 0;
            end = 0;  
        }
    }
}
