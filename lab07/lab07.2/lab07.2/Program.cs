namespace lab07._2
{
    internal class Program
    {
        static void Main(string[] args)
        {

                try
                {
                    object obj = "Hello, world!";
                    int so = (int)obj;

                }

                catch (InvalidCastException ex)
                {
                    Console.WriteLine("loi InvalidCastException");
                    Console.WriteLine(ex.Message);
                }
                Console.WriteLine("------------------------------------");
                try
                {
                    int[] numbers = { 1, 2, 3 };
                    int outOfRangeValue = numbers[5];
                }
                catch (IndexOutOfRangeException ex)
                {
                    Console.WriteLine("loi IndexOutOfRangeException");
                    Console.WriteLine(ex.Message);
                }
                Console.WriteLine("------------------------------------");
                Console.WriteLine("------------------------------------");
                try
                {
                    object[] array = new string[3];
                    array[0] = 42;
                }
                catch (ArrayTypeMismatchException ex)
                {
                    Console.WriteLine("loi ArrayTypeMismatchException");
                    Console.WriteLine(ex.Message);
                }
        }
    }
}
