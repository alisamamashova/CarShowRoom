using System;
namespace CarShowroom
{
    public class Engine: Options
    {
        private readonly Component _component;

        public Engine(Component component)
        {
            this.name = "Engine";
            this.price = 15000;

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
//    public class Engine : Options
//    {
//        private readonly AutoBase _autoBase;

//        public Engine(AutoBase autoBase)
//        {
//            _autoBase = autoBase;
//            if (autoBase != null)
//            {
//                Description = autoBase.GetDescription() + " + Усиленный двигатель";
//            }
//        }

//        public override double GetCost()
//        {
//            double cost = 25000;
//            if (_autoBase != null)
//            {
//                cost += _autoBase.GetCost();
//            }
//            return cost;
//        }
//    }
//}
