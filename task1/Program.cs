namespace task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int userNumber = 0;
            Console.Write("Введите число в диапазоне от 1 до 100: ");
            userNumber = Convert.ToInt32(Console.ReadLine());
            if (userNumber > 0 && userNumber < 100 + 1)
            {
                if (userNumber % 3 > 0 && userNumber % 5 > 0)
                {
                    Console.WriteLine(userNumber);
                    return;
                }

                string str = "";
                if (userNumber % 3 == 0)
                    str += "Fizz ";

                if (userNumber % 5 == 0)
                    str += "Fuzz";

                Console.WriteLine(str);

            }
            else
                Console.WriteLine("число {0} находится в недопутимых пределах", userNumber);

        }
    }
}