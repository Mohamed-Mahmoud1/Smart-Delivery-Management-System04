using System;
using System.Collections.Generic;
using System.Text;

namespace Smart_Delivery_Management_System04
{
    public class ExpressShipment : Shipment
    {
        decimal _ExtraFee;
        public decimal ExtraFee
        {
            get
            {
                return _ExtraFee;
            }
            set
            {
                if (value >= 0)
                    _ExtraFee = value;
            }
        }

        public ExpressShipment(string tackingCode, string description, decimal weight, decimal deliveryFee, DeliveryAddress destination, decimal extrafee) : base(tackingCode, description, weight, deliveryFee, destination)

        {
            ExtraFee = extrafee;
        }
        public override decimal EstimatedCost => DeliveryFee + (Weight * 5) + ExtraFee;

        public override void PrintShipment()
        {
            Console.WriteLine("Express Shipment\n");

            Console.WriteLine($"Tracking Code: {TrackingCode}");
            Console.WriteLine($"Description: {Description}");
            Console.WriteLine($"Weight: {Weight} KG");
            Console.WriteLine($"Delivery Fee: {DeliveryFee} EGP ");
            Console.WriteLine($"Extra Fee: {ExtraFee} EGP");
            Console.WriteLine($"Estimated Cost: {EstimatedCost} EGP");
            Console.WriteLine("-------------------------------------------------");
        }

    }
}
