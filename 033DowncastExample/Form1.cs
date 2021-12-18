using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _033DowncastExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*sender is an object, here is button. but when we try to write "sender." we can not see button properties,
             so we should use downcasting.*/
            var button = (Button)sender; // now we have all properties for the button
            MessageBox.Show(button.Height.ToString());
            MessageBox.Show("Hello World!");

            /*or we can use in this way : */
            var button2 = sender as Button;
            if (button != null)
            {
                MessageBox.Show(button.Height.ToString());
            }
        }
    }
}
