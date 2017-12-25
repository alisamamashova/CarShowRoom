using System;
namespace CarShowroom
{
    public class CarShowroomOnCommand: ICommand
    {
        CarShowroom carShowroom;
        public CarShowroomOnCommand(CarShowroom _carShowroom)
        {
            carShowroom = _carShowroom;
        }
        public void Buy()
        {
            carShowroom.Buy();
        }
        public void PreOrder()
        {
            carShowroom.PreOrder();
        }
    }
}
