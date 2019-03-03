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
    public partial class FormForRemove : Form
    {
        public FormForRemove(MainForm f, string t)
        {
            InitializeComponent();
            form = f;
            text = t;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string result = form.textBox1.Text;
            try
            {
                if (!result.Contains(text))
                {
                    throw new Exception("Ошибка! Подстрока не найдена.");
                }
                else
                {
                    int index = result.IndexOf(text);
                    result = result.Remove(index, text.Length).Insert(index, textBox1.Text);
                    form.textBox1.Text = result;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Close();
            }
        }
    }
}
