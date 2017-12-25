using System;
namespace CarShowroom
{
    public class BMWM5 : Component
    {
        public BMWM5()
        {
            name = "BMW M5";
            price = 100000;
        }
        public override double GetCost()
        {
            return this.price;
        }

    }
}
