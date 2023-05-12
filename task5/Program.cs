namespace task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите дату в формате год.месяц.день");
            try
            {
                DateTime date = DateTime.Parse(Console.ReadLine());

                if (date != null)
                {
                    string season;
                    switch (date.Month)
                    {
                        case 1:
                        case 2:
                        case 12:
                            season = "Winter";
                            break;
                        case 3:
                        case 4:
                        case 5:
                            season = "Spring";
                            break;
                        case 6:
                        case 7:
                        case 8:
                            season = "Summer";
                            break;
                        default:
                            season = "Autumn";
                            break;

                    }
                    Console.WriteLine("{0} {1}", season, date.DayOfWeek);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}