using System;
namespace CarShowroom
{
    public class Mehendi: Options
    {
        private readonly Component _component;

        public Mehendi(Component component)
        {
            this.name = "Mehendi";
            this.price = 2000;

            _component = component;
            if (component != null)
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
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace DecoratorCar
//{
//    public class Mehendi : Options
//    {
//        private readonly AutoBase _autoBase;

//        public Mehendi(AutoBase autoBase)
//        {
//            _autoBase = autoBase;
//            if (autoBase != null)
//            {
//                Description = autoBase.GetDescription() + " + Роспись автомобиля";
//            }
//        }

//        public override double GetCost()
//        {
//            double cost = 500;
//            if (_autoBase != null)
//            {
//                cost += _autoBase.GetCost();
//            }
//            return cost;
//        }
//    }
//}
