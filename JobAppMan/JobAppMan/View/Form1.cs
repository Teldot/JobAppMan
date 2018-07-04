using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JobAppMan.View
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            Image i1 = Properties.Resources.email_compose;
                       
            exListBox1.Items.Add(new exListBoxItem(14, "John, the Tester", @"First details text is used to check it out, if text fits correctly the bounds of an item.
As you can see, everything fits nicely.
If it's shown correctly, that's should be last line, that you see.
If you can see this line, it looks like it overlaps something and there's a bug in the code.
", i1));
            exListBox1.Items.Add(new exListBoxItem(99, "Bill", "phone +345645464, fax +6546546546, email email@email.com", i1));
            exListBox1.Items.Add(new exListBoxItem(71, "Peter", "ICQ 56465464, msn hot@hotmail.com, phone +5465464654", i1));

        }

        private void exListBox1_DrawItem(object sender, DrawItemEventArgs e)
        {

        }

        private void exListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //this.Text = ((exListBoxItem)exListBox1.SelectedItem).Id.ToString();
        }
    }
}
