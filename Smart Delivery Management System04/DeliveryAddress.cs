using System;
using System.Collections.Generic;
using System.Text;

namespace Smart_Delivery_Management_System04
{
    public struct DeliveryAddress
    {

        public string City { get; set; }
        public string Street { get; set; }
        public int Building_Number { get; set; }

        public DeliveryAddress(string city, string street, int building_number)
        {
            City = city;
            Street = street;
            Building_Number = building_number;
        }

        public void GetFullAddress()
        {
            Console.WriteLine($"City: {City}\nStreet: {Street}\nBuilding Number: {Building_Number}\n----------------");
        }

    }
}
