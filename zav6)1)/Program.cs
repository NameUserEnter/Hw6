using System;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            Driver driver = new Driver();
            Car car = new Car();
            driver.Travel(car);
            Camel camel = new Camel();
            ITransport camelTransport = new CamelToTransportAdapter(camel);
            driver.Travel(camelTransport);
            Console.Read();
        }
    }
    interface ITransport
    {
        void Drive();
    }
    class Car : ITransport
    {
        public void Drive()
        {
            Console.WriteLine("The car drive on the road");
        }
    }
    class Driver
    {
        public void Travel(ITransport transport)
        {
            transport.Drive();
        }
    }
    interface IAnimal
    {
        void Move();
    }

    class Camel : IAnimal
    {
        public void Move()
        {
            Console.WriteLine("A camel walks through the desert");
        }
    }
    class CamelToTransportAdapter : ITransport
    {
        Camel camel;
        public CamelToTransportAdapter(Camel c)
        {
            camel = c;
        }

        public void Drive()
        {
            camel.Move();
        }
    }
}
