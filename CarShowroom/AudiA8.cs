using System;
namespace CarShowroom
{
    public class AudiA8 : Component
    {
        public AudiA8()
        {
            name = "Audi A8";
            price = 100000;
        }
        public override double GetCost() 
        {
            return this.price;
        }



    }
}
