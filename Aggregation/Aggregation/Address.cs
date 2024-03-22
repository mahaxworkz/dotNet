using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aggregation
{
     public class Address
    {
        public int doorNo;
        public String streetName;
        public String city;
        public String postalCode;
        public String country;

        public Address(int doorNo, string streetName, string city, string postalCode, string country)
        {
            this.doorNo = doorNo;
            this.streetName = streetName;
            this.city = city;
            this.postalCode = postalCode;
            this.country = country;
        }

        /*public override String ToString()
        {
            return $"doorNo: {doorNo},street: {streetName},city: {city},postalCode: {postalCode}";
        }*/

    }
}
