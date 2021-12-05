using System;

namespace Decorator
{
    class Program
    {
        static void Main()
        {
            // Create ConcreteComponent and two Decorators
            ChristmasTree c = new ChristmasTree();
            Toys d1 = new Toys();
            Garlands d2 = new Garlands();

            // Link decorators
            d1.SetChristmasTree(c);
            d2.SetChristmasTree(d1);

            d2.Decorate();

            // Wait for user
            Console.Read();
        }
    }
    // "Component"
    abstract class Tree
    {
        public abstract void Decorate();
    }
    // "ConcreteComponent"
    class ChristmasTree : Tree
    {
        public override void Decorate()
        {
            Console.WriteLine("DecoratedChristmasTree.Decorate()");
        }
    }
    // "Decorator"
    abstract class ChristmasTreeDecorator : Tree
    {
        protected Tree christmasTree;

        public void SetChristmasTree(Tree christmasTree)
        {
            this.christmasTree = christmasTree;
        }
        public override void Decorate()
        {
            if (christmasTree != null)
            {
                christmasTree.Decorate();
            }
        }
    }
    // "ConcreteDecoratorA"
    class Toys : ChristmasTreeDecorator
    {
        private string addedDecoration;

        public override void Decorate()
        {
            base.Decorate();
            addedDecoration = "Decorated with toys";
            Console.WriteLine("Toys.Decorate()");
        }
    }
    // "ConcreteDecoratorB" 
    class Garlands : ChristmasTreeDecorator
    {
        public override void Decorate()
        {
            base.Decorate();
            Lighten();
            Console.WriteLine("Garlands.Decorate()");
        }
        void Lighten()
        {

        }
    }

}