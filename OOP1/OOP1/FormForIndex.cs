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
    public partial class FormForIndex : Form
    {

        public FormForIndex(TextBox t)
        {
            InitializeComponent();
            text = t;
        }

        private void GetLetter(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("Буква с заданным индексом: "+Convert.ToString(text.Text[Convert.ToInt32(textBox1.Text)]));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally {
                Close();
            }
        }
    }
}
