using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace AbstractFactory
{
    public class AbstractFactory
    {
        // AbstractProductA
        public abstract class Car
        {
            public abstract void Info();

        }

        // ConcreteProductA1
        public class Ford : Car
        {
            public override void Info()
            {
                Console.WriteLine("Ford");
            }
        }

        //ConcreteProductA2
        public class Toyota : Car
        {
            public override void Info()
            {
                Console.WriteLine("Toyota");
            }
        }

        //ConcreteProductA3
        class Mersedes : Car
        {
            public override void Info()
            {
                Console.WriteLine("Mersedes");
            }
        }

        // AbstractProductB
        public abstract class Engine
        {
            public virtual void GetPower() { }
        }

        // ConcreteProductB1
        class FordEngine : Engine
        {
            public override void GetPower()
            {
                Console.WriteLine("Ford Engine 4.4");
            }
        }

        //ConcreteProductB2
        class ToyotaEngine : Engine
        {
            public override void GetPower()
            {
                Console.WriteLine("Toyota Engine 3.2");
            }
        }
        //ConcreteProductB3
        class MersedesEngine : Engine
        {
            public override void GetPower()
            {
                Console.WriteLine("Mersedes Engine 6.7");
            }
        }
        // AbstractFactory
        public interface ICarFactory
        {
            Car CreateCar();
            Engine CreateEngine();
        }

        // ConcreteFactory1
        public class FordFactory : ICarFactory
        {
            // from CarFactory
            Car ICarFactory.CreateCar()
            {
                return new Ford();
            }

            Engine ICarFactory.CreateEngine()
            {
                return new FordEngine();
            }
        }

        // ConcreteFactory2
        public class ToyotaFactory : ICarFactory
        {
            // from CarFactory
            Car ICarFactory.CreateCar()
            {
                return new Toyota();
            }

            Engine ICarFactory.CreateEngine()
            {
                return new ToyotaEngine();
            }
        }
        // ConcreteFactory3
        class MersedesFactory : ICarFactory
        {
            // from CarFactory
            Car ICarFactory.CreateCar()
            {
                return new Mersedes();
            }
            Engine ICarFactory.CreateEngine()
            {
                return new MersedesEngine();
            }
        }

        class AbstractFactoryApp
        {
            static void Main(string[] args)
            {
                ICarFactory carFactory = new ToyotaFactory();
                Car myCar = carFactory.CreateCar();
                myCar.Info();
                Engine myEngine = carFactory.CreateEngine();
                myEngine.GetPower();

                carFactory = new FordFactory();
                myCar = carFactory.CreateCar();
                myCar.Info();
                myEngine = carFactory.CreateEngine();
                myEngine.GetPower();

                carFactory = new MersedesFactory();
                myCar = carFactory.CreateCar();
                myCar.Info();
                myEngine = carFactory.CreateEngine();
                myEngine.GetPower();
                Console.ReadKey();
            }
        }
    }
}
