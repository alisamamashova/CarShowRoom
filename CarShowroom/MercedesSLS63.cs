using System;
namespace CarShowroom
{
    public class MercedesSLS63 : Component
    {
        public MercedesSLS63()
        {
            name = "Mercedes SLS 63";
            price = 230000;
        }
        public override double GetCost()
        {
            return this.price;
        }
    }
}
