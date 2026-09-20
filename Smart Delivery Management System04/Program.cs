namespace Smart_Delivery_Management_System04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part 01 — Theoretical Questions


            #region Question01

            //a) What is Abstraction in Object - Oriented Programming ?
            //Answer:Abstraction means hiding implementation details and showing only essential features to the user, focusing on what an object does, not how it works.

            //b)  Why is abstraction considered one of the four pillars of OOP?
            //Answer:Because it provides maintainability, hides complex details, and shows essential information only.
            #endregion

            #region Question02
            //a)  What is the difference between an Abstract Class and an Interface?
            //Answer:An abstract class can have fields and constructors, whereas an interface cannot

            //b)  When would you choose an Interface instead of an Abstract Class?
            //Answer:When you want to support multiple inheritance of types.

            //c)  Can a class inherit from multiple abstract classes? Can it implement multiple interfaces?
            //Answer: class cannot inherit from multiple classes, but it can implement multiple interfaces.
            #endregion


            #endregion


            #region Part 02 — Practical

            #region 1.Convert Shipment into an Abstract Class && 2.Create Abstract Members
            #endregion

            #region 3.Update All Shipment Types
            #endregion

            #region 4.Create ITrackable
            #endregion

            #region 5.Create IInsurable
            #endregion

            #region 6.Create DeliveryReport
            #endregion

            #region 7.Update DeliveryCenter
            #endregion

            #region 8.Main() Checklist

            DeliveryAddress deliveryadders = new DeliveryAddress("Germany","",0);

            StandardShipment standardshipment = new StandardShipment("SH001", "Laptop",3,80,deliveryadders);

            ExpressShipment expressshipment = new ExpressShipment("SH002", "Mobile Phone", 2, 60, deliveryadders,30);

            InternationalShipment internationalshipment = new InternationalShipment("SH003", "Television", 8, 120, deliveryadders, "Germany", 100);

            DeliveryCenter deliveryCenter = new DeliveryCenter();
            deliveryCenter.AddShipment(standardshipment);
            deliveryCenter.AddShipment(expressshipment);
            deliveryCenter.AddShipment(internationalshipment);

            deliveryCenter.PrintAllShipments();

            deliveryCenter.PrintTrackingStatuses();

            deliveryCenter.PrintInsurance();


            #endregion

            #endregion
        }
    }
}
