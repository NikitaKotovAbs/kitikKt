

namespace Ежедневник2._0
{
    internal class Program
    {
        private static string path;
        static void Main(string[] args)
        {
            string file_name = "text.txt";
            string state = null;
            Console.Clear();
            while (state != "3")
            {
                try
                {
                    Console.WriteLine("2 - посмотреть заметки  3 - выход");
                    state = Console.ReadLine();
                    switch (state)
                    {

                        case "2":
                            Vivod();
                            DATA();
                            break;
                        default:
                            break;

                    }

                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            Console.WriteLine("Нажмите клавишу для выхода . .");
            Console.ReadLine();
        }
        static void DATA()
        {

            Employee temp = new Employee();
            Console.Clear();
            DateTime date = new DateTime(2022, 10, 20);
            int position = 4;
            while (true)
            {

                string day = date.ToString("dd.MM.yyyy");
                string d = null;
                d = date.ToString("dd.MM.yyyy");
                Console.WriteLine(" 1 - добавить новую запись  3 - выход");
                Console.WriteLine("Выбрана дата:" + day);
                Employee.Time1 = day;
                string a = File.ReadAllText("text.txt");
                Vivod();
                Console.SetCursorPosition(0, position);
                Console.WriteLine("->");
                ConsoleKeyInfo key = Console.ReadKey();
                Console.Clear();

                if (key.Key == ConsoleKey.UpArrow)
                {
                    position = position - 1;
                }
                if (key.Key == ConsoleKey.DownArrow)
                {
                    position = position + 1;
                }
                if (position == 1)
                {
                    position = position + 1;
                }
                if (position == 20)
                {
                    position = position - 1;
                }
                if (position == 1)
                {
                    if (key.Key == ConsoleKey.Enter)
                    {

                    }
                }
                if (position == 2)
                {
                    if (key.Key == ConsoleKey.Enter)
                    {

                    }
                }
                if (key.Key == ConsoleKey.LeftArrow)
                {
                    date = date.AddDays(-1);
                }
                if (key.Key == ConsoleKey.RightArrow)
                {
                    date = date.AddDays(+1);
                }
                if (key.Key == ConsoleKey.NumPad1)
                {

                    Console.WriteLine("Введите заголовок заметки: ");
                    temp.State = Console.ReadLine();
                    Console.WriteLine("Введите Сообщение заметки ");
                    temp.BigState = Console.ReadLine();
                    temp.Time = day;

                    temp.WriteEmployee();
                    break;
                }
                if (key.Key == ConsoleKey.NumPad3)
                {

                    return;
                }

            }

        }
        static void Vivod()
        {
            string n = null;
            Employee.DisplayEmployee(n);
        }
        static void Search()
        {

        }
    }
}
