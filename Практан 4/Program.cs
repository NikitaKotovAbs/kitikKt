namespace Практан_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vubor();

        }
       
        static void Vubor()
        {
            DateTime date = DateTime.Now;
            string kra = "кря";
            

            int position = 2;
              while (true)
              {
                    
                        Console.WriteLine("Выбрана дата " + date.ToString("dd.MM.yyyy"));
                        Console.WriteLine("  Расписание пар");
                        Console.WriteLine("  кря");
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
                        if (position == 0)
                        {
                        position = position + 1;
                        }
                        if (position == 3)
                        {
                        position = position - 1;
                        }
                string[] list = { "Расписание пар\n---------------\nИстория\nЭлементы высшей математики\nОсновы программирования и алгоритмизации\nФизическая Культура", "Типа утка",};
                    if (key.Key == ConsoleKey.Enter )
                    {
                        Console.WriteLine(list[0]);
                        Console.ReadKey();
                        Console.Clear();
                    }
                    else
                    if (key.Key == ConsoleKey.Escape )
                    {
                        Console.WriteLine(list[1]);
                        Console.ReadKey();
                        Console.Clear();
                    }
                

                            

                        

                
                    

              }   
            
        }
    }
}