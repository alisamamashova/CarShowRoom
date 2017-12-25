using System;
namespace CarShowroom
{
    public abstract class Component
    {
        protected string name;
        protected double price;

        public virtual string GetName()
        {
            return this.name;
        }
        public virtual void Add(Component component) { }

        public virtual void Remove(Component component) { }

        public virtual double GetCost() 
        { 
            return this.price;
        }

        public virtual void Print()
        {
            Console.WriteLine(name);
        }

        public virtual void Buy() {}
        public virtual void PreOrder() {}
    }
}
