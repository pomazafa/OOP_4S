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
    public partial class FormForString : Form
    {
        public FormForString(MainForm f)
        {
            InitializeComponent();
            form = f;
        }

        private void Remove(object sender, EventArgs e)
        {
            FormForRemove formRomove = new FormForRemove(form, textBox1.Text);
            formRomove.Show();
            Close();
        }

        private void Delete(object sender, EventArgs e)
        {
            string result = form.textBox1.Text;
            try
            {
                if (!result.Contains(textBox1.Text))
                {
                    throw new Exception("Ошибка! Подстрока не найдена.");
                }
                else
                {
                    result = result.Remove(result.IndexOf(textBox1.Text), textBox1.Text.Length);
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
