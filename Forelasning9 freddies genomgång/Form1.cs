using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forelasning9_freddies_genomgång
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TrixSome(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            button.Text = "klickad";
            //labelResult.Text = textBoxInputName.Text;
        }
    }
}
