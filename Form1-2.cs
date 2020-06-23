using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CIS317_FinalExam_Roy
{
    public partial class SPoll : Form
    {
        private const string filePath = "poll.txt";
        private const int numberOfRatings = 10;
        private int[] responses = new int[numberOfRatings];
        public SPoll()
        {
            InitializeComponent();
        }

        private void Donebutton_Click(object sender, EventArgs e)
        {
            Close(); 
        }

        private void Displaybutton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("{0}", numberOfRatings); 
        }

        private void SPoll_Load(object sender, EventArgs e)
        {
            try
            {
                using (var sr = new StreamReader(filePath))
                {
                    var counter = 0;
                    while (!sr.EndOfStream)
                    {
                        var readLine = sr.ReadLine();
                        if(readLine !=null)
                        {
                            var line = readLine.Split(',');
                            responses[counter]=Convert.ToInt32(line[1]);
                            counter++;
                        }
                    }
                }
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {


        }
    }
}
