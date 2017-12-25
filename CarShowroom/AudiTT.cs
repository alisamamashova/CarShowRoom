using System;
namespace CarShowroom
{
    public class AudiTT : Component
    {
        public AudiTT()
        {
            name = "Audi TT";
            price = 80000;
        }
        public override double GetCost()
        {
            return this.price;
        }
    }
}
