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
using System.Diagnostics;

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
            outputFile = File.AppendText(Environment.CurrentDirectory + "/Data/" + lastName_txtbox.Text + " " + firstName_txtbox.Text + ".txt");
            outputFile.WriteLine(firstName_txtbox.Text);
            outputFile.WriteLine("First Name: " + firstName_txtbox.Text);
            outputFile.WriteLine("Last Name: " + lastName_txtbox.Text);
            outputFile.WriteLine("Sex: " + sex_txtbox.Text);
            outputFile.WriteLine("Age: " + lastName_txtbox.Text);
            outputFile.WriteLine("Address: " + address_txtbox.Text);
            outputFile.WriteLine("Contact Number: " + contactNumber_txtbox.Text);
            outputFile.Write("");
            outputFile.Write("");
            outputFile.Close();

            firstName_txtbox.Clear();
            lastName_txtbox.Clear();
            sex_txtbox.Clear();
            age_txtbox.Clear();
            address_txtbox.Clear();
            contactNumber_txtbox.Clear();
        }

        private void data_btn_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", Environment.CurrentDirectory);
        }
    }
}
