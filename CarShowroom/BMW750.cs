using System;
namespace CarShowroom
{
    public class BMW750 : Component
    {
        public BMW750()
        {
            name = "BMW 750";
            price = 120000;
        }
        public override double GetCost()
        {
            return this.price;
        }

    }
}
