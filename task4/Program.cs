namespace task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int index1, index2;
            Console.WriteLine("Введите шестизначное число: ");
            var userNumber = Console.ReadLine().ToArray();
            if (userNumber.Length > 6 || userNumber.Length < 6)
            {
                Console.WriteLine("Число не шестизначноею");
            }
            else
            {
                Console.WriteLine("Введите рязряды числа для изменения:\n1й разряд:");
                index1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("2й разряд:");
                index2 = Convert.ToInt32(Console.ReadLine());
                if (index1 < 1 || index1 > userNumber.Length || index2 < 1 || index2 > userNumber.Length)
                    Console.WriteLine("неверное значение разряда числа.");
                else
                {
                    --index1;
                    --index2;
                    char temp = userNumber[index1];
                    userNumber[index1] = userNumber[index2];
                    userNumber[index2] = temp;
                    Console.WriteLine(userNumber);
                }
            }
        }
    }
}