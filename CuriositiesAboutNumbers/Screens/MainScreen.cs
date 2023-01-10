using CuriositiesAboutNumbers.Util;

namespace CuriositiesAboutNumbers.Screens
{
    internal class MainScreen
    {
        private IntParseExceptionHandler intParseExceptionHandler = new IntParseExceptionHandler();
        private NumberRequest numberRequest = new NumberRequest();
        public void mainMenu()
        {
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("- 1. Give me a fact about a random number. -");
            Console.WriteLine("- 2. Give me a fact about a number.        -");
            Console.WriteLine("--------------------------------------------");
        }

        public void mainMenuFunction()
        {
            int selectedOption = intParseExceptionHandler.handleException(Console.ReadLine());// Makes sure you don't write a character that could break the program.

            switch (selectedOption)
            {
                case 1:
                    {
                        Console.WriteLine();
                    }
                break;

                case 2:
                    {
                        Console.WriteLine("Please, write the number you want to.");
                        int number = intParseExceptionHandler.handleException(Console.ReadLine());
                        Console.WriteLine(numberRequest.requestNumber(number).Result);
                    }
                break;

                default:
                    {
                        Console.WriteLine("Write down 1 or 2 as an option, please.");
                        mainMenuFunction();
                    }
                break;
            }
        }
    }
}
