using System;
namespace CarShowroom
{
    public class MercedesS600 : Component
    {
        public MercedesS600()
        {
            name = "Mercedes S600";
            price = 170000;
        }
        public override double GetCost()
        {
            return this.price;
        }

    }
}
