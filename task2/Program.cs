namespace task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число : ");
            double? number = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Введите число процента: ");
            double? divider = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();
            Console.Write("{0} процентов от {1} составляет ", divider, number);
            divider = divider > 0 ? divider / 100 : 0;
            Console.WriteLine(number * divider);
        }
    }
}