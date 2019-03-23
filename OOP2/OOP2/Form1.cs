using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml.Linq;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;


namespace OOP2
{
    public partial class Form1 : Form
    {
        public List<XElement> Result;

        XmlSerializeWrapper<Product> XmlS;
        public Form1()
        {
            InitializeComponent();
            XmlS = new XmlSerializeWrapper<Product>();
            Result = new List<XElement>();
        }

        private void VeighyBox_ValueChanged(object sender, EventArgs e)
        {
            ValueWeight.Text = Convert.ToString(WeightBox.Value);
        }

        bool Check(object o)
        {
            // старая реализация
            #region
            //if (NameBox.Text == "")
            //{
            //    NameBox.BackColor = System.Drawing.Color.LightCoral;
            //    return false;
            //}
            //else
            //{
            //    NameBox.BackColor = System.Drawing.Color.LightGreen;
            //}

            //if (NumberBox.Text == "")
            //{
            //    NumberBox.BackColor = System.Drawing.Color.LightCoral;
            //    return false;
            //}
            //else
            //{
            //    NumberBox.BackColor = System.Drawing.Color.LightGreen;
            //}

            //if (SizeBox.Text == "")
            //{
            //    SizeBox.BackColor = System.Drawing.Color.LightCoral;
            //    return false;
            //}
            //else
            //{
            //    SizeBox.BackColor = System.Drawing.Color.LightGreen;
            //}

            //if (WeightBox.Value == 0)
            //{
            //    WeightBox.BackColor = System.Drawing.Color.LightCoral;
            //    return false;
            //}
            //else
            //{
            //    WeightBox.BackColor = System.Drawing.Color.LightGreen;
            //}

            //if (!(TypeProdBox.Checked || TypeNotProdBox.Checked))
            //{
            //    TypeProdBox.BackColor = System.Drawing.Color.LightCoral;
            //    TypeNotProdBox.BackColor = System.Drawing.Color.LightCoral;
            //    return false;
            //}
            //else
            //{
            //    TypeProdBox.BackColor = System.Drawing.Color.LightGreen;
            //    TypeNotProdBox.BackColor = System.Drawing.Color.LightGreen;
            //}

            //if (CountBox.Value == 0)
            //{
            //    CountBox.BackColor = System.Drawing.Color.LightCoral;
            //    return false;
            //}
            //else
            //{
            //    CountBox.BackColor = System.Drawing.Color.LightGreen;
            //}

            //if (PriceBox.Value == 0)
            //{
            //    PriceBox.BackColor = System.Drawing.Color.LightCoral;
            //    return false;
            //}
            //else
            //{
            //    PriceBox.BackColor = System.Drawing.Color.LightGreen;
            //}

            //if (OrganizationBox.Text == "")
            //{
            //    OrganizationBox.BackColor = System.Drawing.Color.LightCoral;
            //    return false;
            //}
            //else
            //{
            //    OrganizationBox.BackColor = System.Drawing.Color.LightGreen;
            //}

            //if (CountryBox.Text == "")
            //{
            //    CountryBox.BackColor = System.Drawing.Color.LightCoral;
            //    return false;
            //}
            //else
            //{
            //    CountryBox.BackColor = System.Drawing.Color.LightGreen;
            //}

            //if (AddressBox.Text == "")
            //{
            //    AddressBox.BackColor = System.Drawing.Color.LightCoral;
            //    return false;
            //}
            //else
            //{
            //    AddressBox.BackColor = System.Drawing.Color.LightGreen;
            //}

            //if (TelephoneBox.Text.Length != 13)
            //{
            //    TelephoneBox.BackColor = System.Drawing.Color.LightCoral;
            //    return false;
            //}
            //else
            //{
            //    TelephoneBox.BackColor = System.Drawing.Color.LightGreen;
            //}
            #endregion

            var results = new List<ValidationResult>();

            var context = new ValidationContext(o);

            if (!Validator.TryValidateObject(o, context, results, true))
            {
                string strWithError = "";
                foreach (var error in results)
                {
                    strWithError += error.ErrorMessage;
                }

                MessageBox.Show(strWithError);
                return false;
            }
            else
                return true;
        }

        private void SerButton_Click(object sender, EventArgs e)
        {

            Manufacturer man = new Manufacturer(OrganizationBox.Text, CountryBox.Text, AddressBox.Text, TelephoneBox.Text);
            string type = "";
            if (TypeProdBox.Checked)
                type = "Продовольственный";
            else
            {
                if (TypeNotProdBox.Checked)
                    type = "Непродовольственный";
            }
            Product product = new Product(NameBox.Text, NumberBox.Text, SizeBox.Text, WeightBox.Value, type, DateBox.Value, (int)CountBox.Value, (int)PriceBox.Value, man);

            if (Check(product) && Check(man))
                XmlS.Serialize(product, "product.xml");
            XDocument doc = XDocument.Load("product.xml");
            var query = from prod in doc.Descendants("ArrayOfProduct").Elements("Product")
                        select prod;

            Result = query.ToList();
            toolStripStatusLabel1.Text = Result.Count + " объектов, время " + DateTime.Now.ToString();
        }

        private void DeserButton_Click(object sender, EventArgs e)
        {
            Product desProduct = XmlS.Deserialize("product.xml");

            richTextBox1.Text = "Наименование товара: " + desProduct.Name + "\n";
            richTextBox1.Text += "Идентификационный номер: " + desProduct.Number + "\n";
            richTextBox1.Text += "Размер: " + desProduct.Size + "\n";
            richTextBox1.Text += "Вес: " + desProduct.Weight + "\n";
            richTextBox1.Text += "Тип: " + desProduct.TypeProduct + "\n";
            richTextBox1.Text += "Дата поставки: " + desProduct.DateP.ToShortDateString() + "\n";
            richTextBox1.Text += "Количество: " + desProduct.Amount + "\n";
            richTextBox1.Text += "Цена: " + desProduct.Price + "\n";
            richTextBox1.Text += "Организация-производитель: " + desProduct.manufacturer.Organization + "\n";
            richTextBox1.Text += "Страна производителя: " + desProduct.manufacturer.Country + "\n";
            richTextBox1.Text += "Адрес: " + desProduct.manufacturer.Address + "\n";
            richTextBox1.Text += "Телефонный номер: " + desProduct.manufacturer.TelephoneNumber + "\n";
        }

        private void AboutProgramMenu_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Разработчик: Дубень Полина\nВерсия: 0.1 Аlpha", "Информация о программе");
        }

        private void поНазваниюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchBy s = new SearchBy("ByName", this);
            s.Show();
        }

        private void поТипуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchBy s = new SearchBy("ByType", this);
            s.Show();
        }

        private void поДиапазонуЦеныToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchBy s = new SearchBy("ByPrice", this);
            s.Show();
        }

        private void поНесколькимКритериямToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchBy search = new SearchBy(this);
            search.Show();
        }

        private void датеПроизводстваToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XDocument doc = XDocument.Load("product.xml");

            var query = from product in doc.Descendants("ArrayOfProduct").Elements("Product")
                        orderby (product.Element("Date").Value)
                        select product;

            Result = query.ToList();
        }

        private void странеПроизводителяToolStripMenuItem_Click(object sender, EventArgs e)
        {


            XDocument doc = XDocument.Load("product.xml");

            var query = from product in doc.Descendants("ArrayOfProduct").Elements("Product")
                        orderby (product.Element("Manufacturer").Element("country").Value)
                        select product;

            Result = query.ToList();

        }

        private void названиюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XDocument doc = XDocument.Load("product.xml");

            var query = from product in doc.Descendants("ArrayOfProduct").Elements("Product")
                        orderby (product.Element("Name").Value)
                        select product;

            Result = query.ToList();
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XDocument resFile = XDocument.Load("product.xml");
            resFile.Descendants("Product").Remove();
            resFile.Descendants("ArrayOfProduct").First().Add(Result);
            resFile.Save("Result.xml");
           
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            toolStripStatusLabel1.Text = Result.Count + " объектов, " + DateTime.Today.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            XDocument doc = XDocument.Load("product.xml");
            var query = from product in doc.Descendants("ArrayOfProduct").Elements("Product")
                        select product;

            Result = query.ToList();

            toolStripStatusLabel1.Text = Result.Count + " объектов, время " + DateTime.Now.ToString();
        }
    }
}
