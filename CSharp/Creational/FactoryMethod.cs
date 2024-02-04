namespace DesignPatterns.Creational
{
    /*
     * ITransport is the product interface.
     * Truck and Ship are concrete products implementing ITransport.
     * TransportCompany is the creator, an abstract class with the abstract factory method CreateTransport.
     * RoadLogistics and SeaLogistics are concrete creators that implement CreateTransport to produce specific types of transport.
     */

    // Product Interface
    public interface ITransport
    {
        void Deliver();
    }

    // Concrete Products
    public class Truck : ITransport
    {
        public void Deliver()
        {
            Console.WriteLine("Delivery by Truck");
        }
    }

    public class Ship : ITransport
    {
        public void Deliver()
        {
            Console.WriteLine("Delivery by Ship");
        }
    }

    // Creator
    public abstract class TransportCompany
    {
        public abstract ITransport CreateTransport();

        public void PlanDelivery()
        {
            var transport = CreateTransport();
            transport.Deliver();
        }
    }

    // Concrete Creators
    public class RoadLogistics : TransportCompany
    {
        public override ITransport CreateTransport()
        {
            return new Truck();
        }
    }

    public class SeaLogistics : TransportCompany
    {
        public override ITransport CreateTransport()
        {
            return new Ship();
        }
    }
}
