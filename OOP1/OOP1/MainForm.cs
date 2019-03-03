using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP1
{
    public partial class MainForm : System.Windows.Forms.Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void DeleteOrReplaceButton(object sender, EventArgs e)
        {
            FormForString form2 = new FormForString(this);
            form2.Show();
        }

        private void GetByIndex(object sender, EventArgs e)
        {
            FormForIndex newForm2 = new FormForIndex(textBox1);
            newForm2.Show();
        }

        private void GetLength(object sender, EventArgs e)
        {
            MessageBox.Show("Размер исходной строки: " + Convert.ToString(textBox1.Text.Length));
        }

        private void GetCountWords(object sender, EventArgs e)
        {
            MessageBox.Show("Количество слов: " + Convert.ToString(textBox1.Text.Split(' ').Length));
        }

        private void GetCountConson(object sender, EventArgs e)
        {
            string con = "qwrtpsdfghjklzxcvbnmQWRTPSDFGHJKLZXCVBNM";
            int counter = 0;
            for (int i = 0; i < textBox1.Text.Length; i++)
            {
                if (con.Contains(textBox1.Text[i]))
                    counter++;
            }
            MessageBox.Show("Количество согласных: " + Convert.ToString(counter));
        }

        private void GetCountVovels(object sender, EventArgs e)
        {
            string vovels = "AYEUIOayeuio";
            int counter = 0;
            for(int i = 0; i < textBox1.Text.Length; i++)
            {
                if (vovels.Contains(textBox1.Text[i]))
                    counter++;
            }
            MessageBox.Show("Количество гласных: " + Convert.ToString(counter));
        }

        private void GetCountSenten(object sender, EventArgs e)
        {
            int counter = 0;
            for (int i = 0; i < textBox1.Text.Length; i++)
            {
                if (textBox1.Text[i] == '.' || textBox1.Text[i] == '!' || textBox1.Text[i] == '?')
                    counter++;
            }
            MessageBox.Show("Количество предложений: " + Convert.ToString(counter));
        }

        //private void button2_Click(object sender, EventArgs e)
        //{
        //    FormForIndex newForm2 = new FormForIndex(textBox1);
        //    newForm2.Show();
        //}
    }
}
