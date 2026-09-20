using System;
using System.Collections.Generic;
using System.Text;

namespace Smart_Delivery_Management_System04
{
    public class InternationalShipment : Shipment, ITrackable
    {
        string _DestinationCountry;
        decimal _CustomsFee;
        public string DestinationCountry
        {
            get
            {
                return _DestinationCountry;
            }

            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    _DestinationCountry = value;
            }
        }

        public decimal CustomsFee
        {
            get
            {
                return _CustomsFee;
            }
            set
            {
                if (value >= 0)
                    _CustomsFee = value;
            }
        }

        public InternationalShipment(string tackingCode, string description, decimal weight, decimal deliveryFee, DeliveryAddress destination, string destinationcountry, decimal customsfee) : base(tackingCode, description, weight, deliveryFee, destination)
        {
            DestinationCountry = destinationcountry;
            CustomsFee = customsfee;
        }

        public override decimal EstimatedCost => DeliveryFee + (Weight * 5) + CustomsFee;

        public override void PrintShipment()
        {
            Console.WriteLine("International Shipment\n");

            Console.WriteLine($"Tracking Code: {TrackingCode}");
            Console.WriteLine($"Description: {Description}");
            Console.WriteLine($"Weight: {Weight} KG");
            Console.WriteLine($"Delivery Fee: {DeliveryFee} EGP ");
            Console.WriteLine($"Destination Countery: {DestinationCountry}");
            Console.WriteLine($"Customs Fee: {CustomsFee}");
            Console.WriteLine($"Estimated Cost: {EstimatedCost} EGP");
            Console.WriteLine("-------------------------------------------------");
        }

        public virtual void GenerateCustomsReport()
        {
            Console.WriteLine("This is from InternationalShipment Class!");
        }

        public string GetTrackingStatus()
        {
            return $"Shipment:{TrackingCode} has been Delivered";
        }
    }
}
