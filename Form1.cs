using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {

        private Random random;
        private List<Button> buttons = new List<Button>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, System.EventArgs e)
        {
            this.Size = new Size(600,600);
            for (int i = 0; i < 2; i++)
			{
                Thread.Sleep(11);
                random = new Random();
                int x = random.Next(0,this.Size.Width-50);
                int y = random.Next(0,this.Size.Height-50);
                Button button = new Button();
                button.Size = new Size(50,50);
                button.Location = new Point(x,y);
                if(buttons.Count == 0)
                {
                    if(random.Next(0,1) == 0)
                    {
                        button.BackColor = Color.Green;
                    }
                    else
                    {
                        button.BackColor = Color.Red;
                    }
                }
                else if(buttons[0].BackColor == Color.Green)
                {
                    button.BackColor = Color.Red;
                }
                else if(buttons[0].BackColor == Color.Red)
                {
                    button.BackColor = Color.Green;
                }
                buttons.Add(button);
                this.Controls.Add(button);
			}
        }
    }
}
