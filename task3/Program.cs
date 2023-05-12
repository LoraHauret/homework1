namespace task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            long? resultNumber = 0;
            int? temp;
            while (true)
            {
                Console.Clear();
                Console.WriteLine("\n\n\tВведите однозначную цифру или пустую строку (enter) для выхода: ");
                temp = Console.Read();      // забираю код клавиши

                if (temp == 13)
                    break;
                else if (temp >= 48 && temp <= 57)
                    resultNumber = resultNumber * 10 + (temp - 48);
                Console.ReadLine();
            }

            Console.Clear();
            Console.WriteLine("\n\n\tОбразованное число: {0}", resultNumber);
        }
    }
}