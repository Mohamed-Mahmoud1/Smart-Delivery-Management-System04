using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Smart_Delivery_Management_System04
{
    public class DeliveryCenter
    {
        public Driver Driver { get; set; }
        public string CenterName { get; set; }
        private Shipment[] shipments;
        public DeliveryCenter()
        {

            shipments = new Shipment[20];
        }


        public Shipment this[int index]
        {
            get
            {
                if (index < 0 || index >= shipments.Length)
                    return default;

                return shipments[index];
            }
            set
            {
                if (index >= 0 && index < shipments.Length)
                {
                    shipments[index] = value;
                }
            }
        }

        public Shipment this[string trackingCode]
        {
            get
            {
                for (int i = 0; i < shipments.Length; i++)
                {
                    if (shipments[i] == null) continue;
                    if (shipments[i].TrackingCode == trackingCode)
                    {
                        return shipments[i];
                    }
                }
                return null;
            }
        }

        public bool AddShipment(Shipment shipment)
        {
            for (int i = 0; i < shipments.Length; i++)
            {
                if (shipments[i] == null)
                {
                    shipments[i] = shipment;
                    return true;
                }
            }
            return false;
        }

        public bool RemoveShipment(string trackingCode)
        {
            for (int i = 0; i < shipments.Length; i++)
            {
                if (shipments[i] == null) continue;

                if (shipments[i].TrackingCode == trackingCode)
                {
                    shipments[i] = null;
                    return true;
                }
            }
            return false;
        }

        public void PrintAllShipments()
        {
            foreach (Shipment ship in shipments)
            {
                if (ship == null)
                    continue;

                ship.PrintShipment();
            }
        }

       public void PrintTrackingStatuses()
        {
            foreach(ITrackable t in shipments)
            {
                t.GetTrackingStatus();
            }
        }

      public void PrintInsurance()
        {
            foreach(IInsurable t in shipments)
            {
                t.CalculateInsurance();
            }
        }
    }
}
