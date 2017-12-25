using System;
namespace CarShowroom
{
    public class Conditioner: Options
    {
        private readonly Component _component;

        public Conditioner(Component component)
        {
            this.name = "Conditioner";
            this.price = 500;

            _component = component;
            if(component != null) 
            {
                name = component.GetName() + " + " + this.name;
            }

        }
        public override double GetCost()
        {
            return _component.GetCost() + this.price;
        }
    }
}
//using System;
//namespace DecoratorCar
//{
//    public class Conditioner : Options
//    {
//        private readonly AutoBase _autoBase;

//        public Conditioner(AutoBase autoBase)
//        {
//            _autoBase = autoBase;
//            if (autoBase != null)
//            {
//                Description = autoBase.GetDescription() + " + Страховка на год";
//            }
//        }
//        public override double GetCost()
//        {
//            double cost = 900;
//            if (_autoBase != null)
//            {
//                cost += _autoBase.GetCost();
//            }
//            return cost;
//        }
//    }
//}
