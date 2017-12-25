using System;
namespace CarShowroom
{
    public class BMWX2 : Component
    {
        public BMWX2()
        {
            name = "BMW X2";
            price = 40000;
        }
        public override double GetCost()
        {
            return this.price;
        }

    }
}
