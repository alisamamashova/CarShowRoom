using System;
namespace CarShowroom
{
    public class Tires : Options
    {
        private readonly Component _component;

        public Tires(Component component)
        {
            this.name = "Tires";
            this.price = 900;

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
//    public class Tires : Options
//    {
//        private readonly AutoBase _autoBase;

//        public Tires(AutoBase autoBase)
//        {
//            _autoBase = autoBase;
//            if (autoBase != null)
//            {
//                Description = autoBase.GetDescription() + " + Покрышки на зиму";
//            }
//        }

//        public override double GetCost()
//        {
//            double cost = 600;
//            if (_autoBase != null)
//            {
//                cost += _autoBase.GetCost();
//            }
//            return cost;
//        }
//    }
//}

