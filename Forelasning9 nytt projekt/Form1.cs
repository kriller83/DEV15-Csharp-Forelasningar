﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forelasning9_nytt_projekt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void AddText(object sender, EventArgs e)
        {
            Button theButtonThatIsClicked = (Button)sender;
            Label.Text += theButtonThatIsClicked.Text;
        }
    }
}
