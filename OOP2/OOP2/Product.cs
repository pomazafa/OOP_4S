using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;


namespace OOP2
{
    [Serializable]
    [XmlType("Product")]
    public class Product
    {
        [Required(ErrorMessage = "Отсутствует название товара\n")]
        [XmlElement(ElementName = "Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Отсутствует инвентарный номер\n")]
        [XmlElement(ElementName = "Number")]
        [MyAttribute]
        public string Number { get; set; }

        [Required(ErrorMessage = "Отсутствуют размеры товара\n")]
        [XmlElement(ElementName = "Size")]
        public string Size { get; set; }

        [Range(1, 10000, ErrorMessage = "Диапазон веса от 1 до 10000\n")]
        [XmlElement(ElementName = "Weight")]
        public int Weight { get; set; }

        [Required(ErrorMessage = "Отсутствует тип товара\n")]
        [XmlElement(ElementName = "Type")]
        public string TypeProduct { get; set; }

        [XmlElement(ElementName = "Date")]
        public DateTime DateP { get; set; }

        [Required(ErrorMessage = "Отсутствует количество товара\n")]
        [XmlElement(ElementName = "Amount")]
        public int Amount { get; set; } // количество

        [Range(1, 100, ErrorMessage = "Диапазон цены от 1 до 100\n")]
        [XmlElement(ElementName = "Price")]
        public int Price { get; set; }

        [XmlElement(ElementName = "Manufacturer")]
        public Manufacturer manufacturer { get; set; }

        private Product()
        {
            Name = "";
        }
        public Product(string n, string num, string siz, int weig, string t, DateTime d, int am, int pr, Manufacturer man)
        {
            Name = n;
            Number = num;
            Size = siz;
            Weight = weig;
            TypeProduct = t;
            DateP = d;
            Amount = am;
            Price = pr;
            manufacturer = man;
        }
    }


    public class MyAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            if(value != null)
            {
                string str = value.ToString();

                if (str.Length == 4)
                    return true;
                else
                    this.ErrorMessage = "В номере должно быть 4 символа";
            }

            return false;
        }
    }
}
