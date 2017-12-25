using System;
using System.Collections.Generic;

namespace CarShowroom
{
    public class Mercedes : Component
    {

        public List<Component> components = new List<Component>();

        public Mercedes()
        {
            this.name = "Mercedes";
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
        public override void Print()
        {
            for (int i = 0; i < components.Count; i++)
            {
                int iteration = i + 1;
                Console.Write("{0})", iteration);
                Console.Write(components[i].GetName() + " ");
            }
            Console.WriteLine();
        }
    }
}
