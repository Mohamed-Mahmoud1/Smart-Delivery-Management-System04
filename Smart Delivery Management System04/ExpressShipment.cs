using System;
using System.Collections.Generic;
using System.Text;

namespace Smart_Delivery_Management_System04
{
    public class ExpressShipment : Shipment, ITrackable, IInsurable
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
            Console.WriteLine($"Extra Fee: {ExtraFee} EGP");
            Console.WriteLine($"Estimated Cost: {EstimatedCost} EGP");
            Console.WriteLine("-------------------------------------------------");
        }

        public string GetTrackingStatus()
        {
            return $"Shipment:{TrackingCode} is Out for Delivery";
        }

        public decimal CalculateInsurance()
        {
            return 0.08m * EstimatedCost;
        }
    }
}
