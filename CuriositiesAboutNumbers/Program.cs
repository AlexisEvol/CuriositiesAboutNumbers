using CuriositiesAboutNumbers.Screens;

namespace CuriositiesAboutNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MainScreen mainScreen = new MainScreen();
            mainScreen.mainMenu();
            mainScreen.mainMenuFunction();
        }
    }
}