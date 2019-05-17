using System;
using System.Collections.Generic;
using System.Text;

namespace Mid_HIMRegister
{
    public class MainMenu
    {
        private int _currentScreen;
        private bool _workingOrder;

        public void Run()
        {
            _currentScreen = 0;
            _workingOrder = false;
            DisplayHeader(_currentScreen);
            Console.WriteLine("Main Menu: What would you like to do?");
            Console.WriteLine("1 - Create New Order, q - Exit");
            //var input = Console.ReadLine();
            //switch (input)
            //{
            //    case 1:

            //        OrderManagement();
            //        break;
            //    default:
            //        return;
            //}

        }
        private void DisplayHeader(int screen)
        {
            Console.WriteLine("+------------------+");
            Console.WriteLine("| It's the Header! |");
            Console.WriteLine("+------------------+");
        }

    }
}
