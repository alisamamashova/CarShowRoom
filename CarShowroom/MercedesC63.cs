using System;
namespace CarShowroom
{
    public class MercedesC63 : Component
    {
        public MercedesC63()
        {
            name = "Mercedes C63";
            price = 120000;
        }
        public override double GetCost()
        {
            return this.price;
        }
    }
}
