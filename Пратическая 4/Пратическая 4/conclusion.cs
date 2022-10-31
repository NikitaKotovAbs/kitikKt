using System.Collections;
using System;
using System.Reflection.PortableExecutable;
using System.Text;

public class Employee
{
    public static string Time1 { get; set; }
    public string State { get; set; }
    public string BigState { get; set; }
    public string Time { get; set; }
    public Employee() { }
    public void WriteEmployee()
    {
        using (StreamWriter sw = File.AppendText("text.txt"))
        {
            sw.WriteLine(this.State);
            sw.WriteLine(this.BigState);
            sw.WriteLine(this.Time);
        }
    }
    public static void DisplayEmployee(string name)
    {
        using (StreamReader sr = File.OpenText("text.txt"))
        {
            string below = Time1;
            int count = System.IO.File.ReadAllLines("text.txt").Length;
            string[] NewFile = File.ReadAllLines("text.txt");
            for (int i = 1; i < count; i += 1)
            {
                string line = File.ReadLines("text.txt").Skip(i).Take(1).First();
                
                string b = (line);
                
                string temp;
                
                if (b == below)
                {
                    Console.WriteLine(b);


                }
            }
        }
    }
}