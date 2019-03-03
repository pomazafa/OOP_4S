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
    public class Manufacturer
    {
        [Required(ErrorMessage = "Отсутвует название организации\n", AllowEmptyStrings = false)]
        public string organization { get; set; }
        [RegularExpression(@"\D*", ErrorMessage = "Неверный формат в поле Страна\n")]
        [Required(ErrorMessage = "Отсутствует страна производителя\n")]
        public string country { get; set; }
        [Required(ErrorMessage = "Отсутствует адрес производителя\n")]
        public string address { get; set; }
        [Required(ErrorMessage = "Отсутствует телефон производителя\n")]
        public string telephoneNumber { get; set; }

        private Manufacturer()
        {
            organization = "";
        }

        public Manufacturer(string org, string coun, string addr, string telephone)
        {
            organization = org;
            country = coun;
            address = addr;
            telephoneNumber = telephone;
        }
    }
}
