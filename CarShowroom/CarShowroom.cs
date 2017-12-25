using System;
using System.Collections.Generic;

namespace CarShowroom
{
    public class CarShowroom: Component
    {
        private List<Component> components = new List<Component>();
        public string clientChoice;

        public CarShowroom(string name)//: base(name)
        {
            this.name = "Mamashova cars";
            this.clientChoice = "";
        }

        public override void Add(Component component)
        {
            components.Add(component);
        }

        public override void Remove(Component component)
        {
            components.Remove(component);
        }
        public override string GetName()
        {
            return this.name;
        }

        public void PrintMarks() 
        { 
            for (int i = 0; i < components.Count; i++)
            {
                int iteration = i + 1;
                Console.Write("{0})",iteration);
                Console.Write(components[i].GetName() + " ");
            }   
            Console.WriteLine();
        }
        public override void Print()
        {
            Console.WriteLine("Узел " + name);
            Console.WriteLine("Подузлы:");
            for (int i = 0; i < components.Count; i++)
            {
               components[i].Print();
            }
        }
        public override void Buy()
        {
            this.clientChoice = "Покупка";
        }

        public override void PreOrder()
        {
            this.clientChoice = "Предзаказ";
        }
    }
}
