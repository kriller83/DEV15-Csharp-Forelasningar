using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NyMiniraknare
{
    public partial class NyMiniraknare : Form
    {
        public NyMiniraknare()
        {
            InitializeComponent();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            button.Text = "klickad";
        }

        private void button19_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            button.Text = "klickad";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            button.Text = "klickad";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            button.Text = "klickad";
        }
    }
}
