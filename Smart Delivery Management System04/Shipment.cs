using System;
using System.Collections.Generic;
using System.Text;

namespace Smart_Delivery_Management_System04
{
    public abstract class Shipment
    {
        string _TackingCode;
        string _Description;
        decimal _Weight;
        decimal _DeliveryFee;

        public Shipment()
        {

        }
        public Shipment(string trackingCode)
        {
            TrackingCode = trackingCode;
            Description = "Unknown";
            Weight = 1;
            DeliveryFee = 50;
            Destination = default;
        }

        public Shipment(string tackingCode, string description, decimal weight, decimal deliveryFee, DeliveryAddress destination) : this()
        {
            _TackingCode = tackingCode;
            _Description = description;
            _Weight = weight;
            _DeliveryFee = deliveryFee;
            Destination = destination;
        }

        public string TrackingCode
        {
            get
            {
                return _TackingCode;
            }
            private set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    _TackingCode = value;
            }
        }

        public string Description
        {
            get
            {
                return _Description;
            }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    _Description = value;
            }
        }

        public decimal Weight
        {
            get
            {
                return _Weight;
            }
            set
            {
                if (value > 0)
                    _Weight = value;
            }
        }



        public decimal DeliveryFee
        {
            get
            {
                return _DeliveryFee;
            }
            private set
            {
                if (value > 0)
                    _DeliveryFee = value;
            }
        }

        public DeliveryAddress Destination { get; set; }

        public abstract decimal EstimatedCost { get;}//abstract property

        public override string ToString()
        {
            return
                $"Tracking Code: {TrackingCode}\n" +
                $"Description: {Description}\n" +
                $"Weight: {Weight}\n" +
                $"Delivery Fee: {DeliveryFee}\n" +
                $"Estimated Cost: {EstimatedCost}\n" +
                $"Destination: {Destination.City}, {Destination.Street}, {Destination.Building_Number}" +
                $"\n-------------------------------------------------";
        }

        public void UpdateDeliveryFee(decimal newFee)
        {
            if (newFee > 0)
                DeliveryFee = newFee;

        }

        public abstract void PrintShipment();//abstract method
    

        public void UpdateWeight(decimal newWeight)
        {
            Weight = newWeight;
        }

        public void UpdateWeight(decimal baseWeight, decimal extraPackingWeight)
        {

            Weight = baseWeight + extraPackingWeight;

        }



    }
}
