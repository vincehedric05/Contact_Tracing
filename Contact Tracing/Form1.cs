using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Contact_Tracing
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        private void confirm_click(object sender, EventArgs e)
        {
            StreamWriter outputFile;
            outputFile = File.CreateText("data.txt");
            outputFile.WriteLine(firstName_txtbox.Text);
            outputFile.Close();
        }
    }
}
