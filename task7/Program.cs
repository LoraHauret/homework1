namespace task7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int min, max;
            Console.Write("Введите 1е число: ");
            min = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите 2е число: ");
            max = Convert.ToInt32(Console.ReadLine());
            if (min > max)
            {
                int temp = min;
                min = max;
                max = temp;
            }

            Console.WriteLine("Четные числа в диапазоне от {0} до {1}:", min, max);
            for (int i = min; i <= max; i++)
            {

                if (i % 2 == 0)
                    Console.Write("{0} ", i);
            }
            Console.WriteLine();
        }
    }
}