using System;
namespace CarShowroom
{
    public class AudiR8: Component
    {
        public AudiR8()
        {
            name = "Audi R8";
            price = 120000;
        }
        public override double GetCost()
        {
            return this.price;
        }
    }
}
