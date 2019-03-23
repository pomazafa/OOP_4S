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
        public string Organization { get; set; }

        [RegularExpression(@"\D*", ErrorMessage = "Неверный формат в поле Страна\n")]
        [Required(ErrorMessage = "Отсутствует страна производителя\n")]
        public string Country { get; set; }

        [Required(ErrorMessage = "Отсутствует адрес производителя\n")]
        public string Address { get; set; }

        [Required(ErrorMessage = "Отсутствует телефон производителя\n")]
        public string TelephoneNumber { get; set; }

        private Manufacturer()
        {
            Organization = "";
        }

        public Manufacturer(string org, string coun, string addr, string telephone)
        {
            Organization = org;
            Country = coun;
            Address = addr;
            TelephoneNumber = telephone;
        }
    }
}
