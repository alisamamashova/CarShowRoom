using System;
namespace CarShowroom.Properties
{
    public class Conditioner
    {
        public Conditioner()
        {
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
