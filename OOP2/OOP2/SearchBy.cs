using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Xml.Serialization;

namespace OOP2
{
    public partial class SearchBy : Form
    {

        public SearchBy(Form1 f)
        {
            InitializeComponent();
            form = f;
        }

        public SearchBy(string methodName, Form1 f)                  //вывести в методы и вызвать соответствующий
        {
            InitializeComponent();
            form = f;
            Type t = typeof(SearchBy);
            MethodInfo mi = t.GetMethod(methodName);
            mi.Invoke(this, null);
            GetResButton();
        }

        public void ByName()
        {
            Label l2 = new Label();
            l2.Text = "Название товара";
            l2.Location = new Point(100, 160);
            TextBox NameText = new TextBox();
            NameText.Location = new Point(100, 190);

            NameText.Name = "NameValue";


            Controls.Add(NameText);
            Controls.Add(l2);

            checkBox1.Checked = true;
        }

        public void ByType()
        {
            Label l1 = new Label();
            l1.Text = "Тип";
            l1.Location = new Point(100, 220);
            RadioButton r1 = new RadioButton();
            r1.Text = "Продовольственный";
            r1.Name = "ValueType1";
            RadioButton r2 = new RadioButton();
            r2.Text = "Непродовольственный";
            r1.Location = new Point(100, 240);
            r2.Location = new Point(100, 270);
            r1.Width = 200;
            r2.Width = 200;
            r2.Name = "ValueType2";
            checkBox2.Checked = true;
            Controls.Add(r1);
            Controls.Add(r2);
            Controls.Add(l1);
        }

        public void ByPrice()
        {
            NumericUpDown n1 = new NumericUpDown();
            n1.Location = new Point(100, 325);
            Label l1 = new Label();
            l1.Location = new Point(100, 300);
            l1.Text = "Нижняя граница";
            n1.Name = "PriceValue1";
            Label l2 = new Label();
            l2.Text = "Верхняя граница";
            l2.Location = new Point(100, 350);
            NumericUpDown n2 = new NumericUpDown();
            n2.Location = new Point(100, 375);
            n2.Name = "PriceValue2";
            Control[] c = new Control[] { l1, n1, n2, l2 };
            Controls.AddRange(c);

            checkBox3.Checked = true;
        }

        void GetResButton()
        {
            Button getRes = new Button();
            getRes.Text = "Выполнить запрос";
            getRes.Click += new System.EventHandler(button_GetRes_Click);
            getRes.Location = new Point(100, 400);
            Controls.Add(getRes);
        }

        private void button_GetRes_Click(object sender, EventArgs e)
        {

            XDocument d = XDocument.Load("product.xml");

            d.Save("Helper.xml");

            if (checkBox1.Checked)
            {
                XDocument doc = XDocument.Load("Helper.xml");

                Control[] c = Controls.Find("NameValue", false);

                Regex regex = new Regex(@"(\w*)" + c[0].Text + @"(\w*)");

                var query = from product in doc.Descendants("ArrayOfProduct").Elements("Product")
                            where regex.Match(product.Element("Name").Value).Success
                            select product;

                form.Result = query.ToList();

                SafeRes();
            }

            if (checkBox2.Checked)
            {
                Control[] c = Controls.Find("ValueType1", false);
                XDocument doc = XDocument.Load("Helper.xml");

                if (c.Length != 0 && ((RadioButton)c[0]).Checked)
                {
                    var query = from product in doc.Descendants("ArrayOfProduct").Elements("Product")
                                where product.Element("Type").Value == "Продовольственный"
                                select product;


                    form.Result = query.ToList();
                }
                else
                {
                    var query = from product in doc.Descendants("ArrayOfProduct").Elements("Product")
                                where product.Element("Type").Value == "Непродовольственный"
                                select product;

                    form.Result = query.ToList();
                }

                SafeRes();

            }

            if (checkBox3.Checked)
            {
                Control[] c1 = Controls.Find("PriceValue1", false);
                Control[] c2 = Controls.Find("PriceValue2", false);

                XDocument doc = XDocument.Load("Helper.xml");

                if (c1.Length != 0 && c2.Length != 0)
                {
                    var query = from product in doc.Descendants("ArrayOfProduct").Elements("Product")
                                where int.Parse(product.Element("Price").Value) > int.Parse(c1[0].Text)
                                where int.Parse(product.Element("Price").Value) < int.Parse(c2[0].Text)
                                select product;

                    form.Result = query.ToList();
                }
            }

            Close();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            bool first = checkBox1.Checked;
            bool second = checkBox2.Checked;
            bool third = checkBox3.Checked;

            if (first || second || third)
            {
                if (first)
                {
                    ByName();
                }
                if (second)
                {
                    ByType();
                }
                if (third)
                {
                    ByPrice();
                }
                GetResButton();
            }
            else
            {
                MessageBox.Show("Элементы не выбраны", "Ошибка");
            }
        }



        void SafeRes()
        {
            XDocument resFile = XDocument.Load("Helper.xml");

            resFile.Descendants("Product").Remove();
            resFile.Descendants("ArrayOfProduct").First().Add(form.Result);
            resFile.Save("Helper.xml");
        }
    }
}
