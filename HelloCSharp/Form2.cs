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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {

                var selectedtext = listView1.SelectedItems[0].SubItems[1].Text;
                Form1.myText = selectedtext.ToString();
                this.Close();
        }
        
    }
}
