using System;
namespace CarShowroom
{
    public class Client : ICommand
    {
        ICommand command;

        public Client() { }

        public void SetCommand(ICommand com)
        {
            command = com;
        }

        public void Buy()
        {
            command.Buy();
        }
        public void PreOrder()
        {
            command.PreOrder();
        }
    }
}
