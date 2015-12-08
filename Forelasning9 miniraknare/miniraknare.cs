using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forelasning9_miniraknare
{
    public partial class miniraknare : Form
    {
        public miniraknare()
        {
            InitializeComponent();
        }

        private void Miniraknare(object sender, EventArgs e)
        {

            Button button = new Button() { Visible = true };
            button.Bounds = new Rectangle(50, 190, 45, 30);
            button.Text = "/";

            Button button2 = new Button() { Visible = true };
            button2.Bounds = new Rectangle(100, 190, 45, 30);
            button2.Text = "*";

            Button button3 = new Button() { Visible = true, };
            button3.Bounds = new Rectangle(150, 190, 45, 30);
            button3.Text = "-";

            Button button4 = new Button() { Visible = true };
            button4.Bounds = new Rectangle(200, 190, 45, 30);
            button4.Text = "+";

            TextBox textbox = new TextBox() { BackColor = Color.Beige  };
            textbox.Bounds = new Rectangle(50, 50, 200, 30);
            textbox.Multiline = true;

            TextBox textbox2 = new TextBox() { BackColor = Color.Beige };
            textbox2.Bounds = new Rectangle(50, 90, 200, 30);
            textbox2.Multiline = true;

            TextBox textbox3 = new TextBox() { BackColor = Color.Beige };
            textbox3.Bounds = new Rectangle(50, 150, 200, 30);
            textbox3.Multiline = true;

            Controls.AddRange(new Control[] { button, button2, button3, button4 });
            Controls.AddRange(new Control[] { textbox, textbox2, textbox3 });


        }
    }
}
