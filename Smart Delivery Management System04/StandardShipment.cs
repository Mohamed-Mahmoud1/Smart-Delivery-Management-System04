using System;
using System.Collections.Generic;
using System.Text;

namespace Smart_Delivery_Management_System04
{
    public class StandardShipment : Shipment, ITrackable, IInsurable
    {
        public StandardShipment(string tackingCode, string description, decimal weight, decimal deliveryFee, DeliveryAddress destination) : base(tackingCode, description, weight, deliveryFee, destination)
        {

        }

        public override decimal EstimatedCost => DeliveryFee + (Weight * 5);

        public decimal CalculateInsurance()
        {
            return 0.05m * EstimatedCost;
        }

        public  string  GetTrackingStatus()
        {
            return $"Shipment:{TrackingCode} is Ready";
        }

        public override void PrintShipment()
        {
            Console.WriteLine("Standard Shipment\n");

            Console.WriteLine($"Tracking Code: {TrackingCode}");
            Console.WriteLine($"Description: {Description}");
            Console.WriteLine($"Weight: {Weight} KG");
            Console.WriteLine($"Delivery Fee: {DeliveryFee} EGP ");
            Console.WriteLine($"Estimated Cost: {EstimatedCost} EGP");
            Console.WriteLine("-------------------------------------------------");
        }
    }
}
