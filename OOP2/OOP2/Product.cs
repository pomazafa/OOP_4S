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
        public string name { get; set; }

        [Required(ErrorMessage = "Отсутствует инвентарный номер\n")]
        [XmlElement(ElementName = "Number")]
        public string number { get; set; }

        [Required(ErrorMessage = "Отсутствуют размеры товара\n")]
        [XmlElement(ElementName = "Size")]
        public string size { get; set; }

        [Range(1, 10000, ErrorMessage = "Диапазон веса от 1 до 10000\n")]
        [XmlElement(ElementName = "Weight")]
        public int weight { get; set; }

        [Required(ErrorMessage = "Отсутствует тип товара\n")]
        [XmlElement(ElementName = "Type")]
        public string type { get; set; }

        [XmlElement(ElementName = "Date")]
        public DateTime date { get; set; }

        [Required(ErrorMessage = "Отсутствует количество товара\n")]
        [XmlElement(ElementName = "Amount")]
        public int amount { get; set; } // количество

        [Range(1, 100, ErrorMessage = "Диапазон цены от 1 до 100\n")]
        [XmlElement(ElementName = "Price")]
        public int price { get; set; }

        [XmlElement(ElementName = "Manufacturer")]
        public Manufacturer manufacturer { get; set; }

        private Product()
        {
            name = "";
        }
        public Product(string n, string num, string siz, int weig, string t, DateTime d, int am, int pr, Manufacturer man)
        {
            name = n;
            number = num;
            size = siz;
            weight = weig;
            type = t;
            date = d;
            amount = am;
            price = pr;
            manufacturer = man;
        }
    }
}
