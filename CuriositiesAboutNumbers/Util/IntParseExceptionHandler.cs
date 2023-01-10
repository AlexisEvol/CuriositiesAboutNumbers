namespace CuriositiesAboutNumbers.Util
{
    internal class IntParseExceptionHandler
    {
        public int handleException(string number)
        {
            try
            {
                return int.Parse(number);
            }
            catch (Exception e)
            {
                Console.WriteLine("Please, write a valid number.");
                return -404;
            }
        }
    }
}
