using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP1_2
{
    public partial class Form1 : Form
    {
        delegate void Comparator();
        Comparator comp;
        public Form1()
        {
            InitializeComponent();

            Label n = new Label();
            this.Controls.Add(n);
            n.Text = "Enter size";
            n.Location = new Point(50, 20);
            n.Show();
        }

        private void Generate_Click(object sender, EventArgs e)
        {
            list = null;
            richTextBox1.Text = "";
            list = new List<int>();
            Random x = new Random(); 
           
            for (int i = 0; i < number.Value; i++)
            {
                int num = x.Next(-100, 100);
                list.Add(num);
                richTextBox1.Text += $"{num}\n";
            }

        }

        private void query1_Click(object sender, EventArgs e)
        {
            var numbers = list.Where(n => n > 0);
            richTextBox2.Text = "";
            foreach (int num in numbers)
            {
                richTextBox2.Text += $"{num}\n";
            }
        }

        private void query2_Click(object sender, EventArgs e)
        {
            var numbers = list.Where(n => n * n < 625);
            richTextBox2.Text = "";
            foreach (int num in numbers)
            {
                richTextBox2.Text += $"{num}\n";
            }
        }

        private void query3_Click(object sender, EventArgs e)
        {
            var numbers = list.Where(n => n < 0).Select(n => n * n);
            richTextBox2.Text = "";
            foreach (int num in numbers)
            {
                richTextBox2.Text += $"{num}\n";
            }
        }

        private void Sort_Click(object sender, EventArgs e)
        {
            if(((Button)sender).Equals(AscendingButton))
                {
                var orderedNumbers = from i in list
                                     orderby i
                                     select i;
                comp = delegate ()
                {
                    richTextBox2.Text = "";
                    foreach (int num in orderedNumbers)
                    {
                        richTextBox2.Text += $"{num}\n";
                    }
                };
            }

            if (((Button)sender).Equals(DescendingButton))
            {
                var orderedNumbers = list.OrderByDescending(i => i);
                comp = delegate ()
                {
                    richTextBox2.Text = "";
                    foreach (int num in orderedNumbers)
                    {
                        richTextBox2.Text += $"{num}\n";
                    }
                };
            }


            comp();
        }
    }
}
