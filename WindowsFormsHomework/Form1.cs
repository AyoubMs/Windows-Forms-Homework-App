using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsHomework
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void sayHiButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Hi {firstName.Text} {lastName.Text}");
        }
    }
}
