using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP8
{
    public class Address
    {
        int id;
        string street;
        string house;
        string housing;
        int flat;

        public Address(int id, string street, string house, string housing, int flat)
        {
            this.id = id;
            this.street = street;
            this.house = house;
            this.housing = housing;
            this.flat = flat;
        }
    }
}
