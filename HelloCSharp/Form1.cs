using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloCSharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static string myText;
        private void cmdHello_Click(object sender, EventArgs e)
        {
            //if (txtName.Text == "")
            //    {
            //    ErrorProvider1.SetError(txtName, "Name Required");
            //    }
            //else
            //{
            //    ErrorProvider1.SetError(txtName, "");
            //    MessageBox.Show("Hello " + txtName.Text + "\nThe time is: " + DateTime.Now.ToString("h:mm:ss"));
            //    this.Text = "Hello " + txtName.Text;
            //}

            Form2 f2 = new Form2();
            f2.ShowDialog();
            txtName.Text = myText;


        }
    }
}
